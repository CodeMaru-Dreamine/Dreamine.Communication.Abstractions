using Dreamine.Communication.Abstractions.Enums;
using Dreamine.Communication.Abstractions.Exceptions;
using Dreamine.Communication.Abstractions.Interfaces;
using Dreamine.Communication.Abstractions.Models;
using Dreamine.Communication.Abstractions.Options;
using Xunit;

namespace Dreamine.Communication.Abstractions.Tests;

public sealed class CommunicationContractsTests
{
    [Fact]
    public void MessageEnvelope_UsesSafeDefaults()
    {
        var createdBefore = DateTimeOffset.UtcNow.AddSeconds(-1);
        var envelope = new MessageEnvelope();
        var createdAfter = DateTimeOffset.UtcNow.AddSeconds(1);

        Assert.False(string.IsNullOrWhiteSpace(envelope.MessageId));
        Assert.Equal(32, envelope.MessageId.Length);
        Assert.Equal(string.Empty, envelope.Name);
        Assert.Equal(string.Empty, envelope.Route);
        Assert.Empty(envelope.Payload);
        Assert.Empty(envelope.Headers);
        Assert.InRange(envelope.CreatedAt, createdBefore, createdAfter);
    }

    [Fact]
    public void MessageEnvelope_AllowsImmutableInitialization()
    {
        var payload = new byte[] { 1, 2, 3 };
        var headers = new Dictionary<string, string> { ["trace-id"] = "abc" };
        var createdAt = new DateTimeOffset(2026, 7, 30, 10, 0, 0, TimeSpan.Zero);

        var envelope = new MessageEnvelope
        {
            MessageId = "message-1",
            Name = "Created",
            Route = "orders.created",
            Payload = payload,
            Headers = headers,
            CreatedAt = createdAt
        };

        Assert.Equal("message-1", envelope.MessageId);
        Assert.Equal("Created", envelope.Name);
        Assert.Equal("orders.created", envelope.Route);
        Assert.Same(payload, envelope.Payload);
        Assert.Equal("abc", envelope.Headers["trace-id"]);
        Assert.Equal(createdAt, envelope.CreatedAt);
    }

    [Fact]
    public void CommunicationError_UsesSafeDefaults()
    {
        var createdBefore = DateTimeOffset.UtcNow.AddSeconds(-1);
        var error = new CommunicationError();
        var createdAfter = DateTimeOffset.UtcNow.AddSeconds(1);

        Assert.Equal(string.Empty, error.Code);
        Assert.Equal(string.Empty, error.Message);
        Assert.Equal(string.Empty, error.Source);
        Assert.Null(error.Exception);
        Assert.InRange(error.CreatedAt, createdBefore, createdAfter);
    }

    [Fact]
    public void CommunicationError_CarriesErrorDetails()
    {
        var exception = new InvalidOperationException("broken");
        var createdAt = new DateTimeOffset(2026, 7, 30, 11, 0, 0, TimeSpan.Zero);

        var error = new CommunicationError
        {
            Code = "transport.failed",
            Message = "Transport failed.",
            Source = "tcp-client",
            Exception = exception,
            CreatedAt = createdAt
        };

        Assert.Equal("transport.failed", error.Code);
        Assert.Equal("Transport failed.", error.Message);
        Assert.Equal("tcp-client", error.Source);
        Assert.Same(exception, error.Exception);
        Assert.Equal(createdAt, error.CreatedAt);
    }

    [Fact]
    public void CommunicationOptions_ExposeExpectedDefaults()
    {
        var options = new CommunicationOptions();

        Assert.Equal("DefaultCommunication", options.Name);
        Assert.False(options.AutoConnect);
        Assert.False(options.EnableAutoReconnect);
        Assert.Equal(3000, options.ReconnectIntervalMs);
    }

    [Fact]
    public void TransportOptions_ExposeExpectedDefaults()
    {
        var options = new TransportOptions();

        Assert.Equal(TransportKind.Tcp, options.Kind);
        Assert.Equal("127.0.0.1", options.Host);
        Assert.Equal(0, options.Port);
        Assert.Equal("COM1", options.PortName);
        Assert.Equal(9600, options.BaudRate);
        Assert.Equal(3000, options.ReadTimeoutMs);
        Assert.Equal(3000, options.WriteTimeoutMs);
    }

    [Fact]
    public void MessageBusOptions_ExposeExpectedDefaults()
    {
        var options = new MessageBusOptions();

        Assert.Equal(TransportKind.InMemory, options.Kind);
        Assert.Equal(string.Empty, options.DefaultRoute);
        Assert.True(options.ThrowOnHandlerError);
        Assert.False(options.EnableParallelHandlers);
    }

    [Fact]
    public void OutboundQueueOptions_ExposeExpectedDefaults()
    {
        var options = new OutboundQueueOptions();

        Assert.Equal(DisconnectedSendPolicy.Queue, options.DisconnectedSendPolicy);
        Assert.Equal(10_000, options.MaxQueueSize);
        Assert.True(options.DropOldestWhenFull);
        Assert.Equal(TimeSpan.FromSeconds(30), options.MaxMessageAge);
        Assert.True(options.FlushOnReconnect);
    }

    [Fact]
    public void ReconnectPolicy_ExposeExpectedDefaults()
    {
        var policy = new ReconnectPolicy();

        Assert.True(policy.Enabled);
        Assert.Equal(TimeSpan.FromSeconds(1), policy.InitialDelay);
        Assert.Equal(TimeSpan.FromSeconds(10), policy.MaxDelay);
        Assert.Equal(1.5, policy.BackoffFactor);
        Assert.Null(policy.MaxRetryCount);
        Assert.Equal(TimeSpan.FromMilliseconds(500), policy.WatchInterval);
    }

    [Fact]
    public void Exceptions_PreserveMessagesAndInnerExceptions()
    {
        var inner = new TimeoutException("timeout");

        var baseException = new CommunicationException("failed", inner);
        var connectionException = new CommunicationConnectionException("connect failed", inner);

        Assert.Equal("failed", baseException.Message);
        Assert.Same(inner, baseException.InnerException);
        Assert.Equal("connect failed", connectionException.Message);
        Assert.Same(inner, connectionException.InnerException);
        Assert.IsAssignableFrom<CommunicationException>(connectionException);
    }

    [Fact]
    public async Task InterfaceContracts_CanBeImplementedByAdapters()
    {
        await using var adapter = new FakeMessageBus();
        var message = new MessageEnvelope { Name = "Ping", Route = "ping" };

        await adapter.ConnectAsync();
        await adapter.SubscribeAsync("ping", (_, _) => Task.CompletedTask);
        await adapter.PublishAsync(message);

        Assert.Equal(ConnectionState.Connected, adapter.State);
        Assert.Equal(TransportKind.InMemory, adapter.Kind);
        Assert.Same(message, adapter.Published.Single());

        await adapter.DisconnectAsync();

        Assert.Equal(ConnectionState.Disconnected, adapter.State);
    }

    private sealed class FakeMessageBus : IMessageBus
    {
        private readonly List<MessageEnvelope> _published = [];

        public TransportKind Kind => TransportKind.InMemory;

        public ConnectionState State { get; private set; } = ConnectionState.Disconnected;

        public IReadOnlyList<MessageEnvelope> Published => _published;

        public Task ConnectAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            State = ConnectionState.Connected;
            return Task.CompletedTask;
        }

        public Task DisconnectAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            State = ConnectionState.Disconnected;
            return Task.CompletedTask;
        }

        public Task PublishAsync(MessageEnvelope message, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            _published.Add(message);
            return Task.CompletedTask;
        }

        public Task SubscribeAsync(
            string route,
            Func<MessageEnvelope, CancellationToken, Task> handler,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            Assert.Equal("ping", route);
            Assert.NotNull(handler);
            return Task.CompletedTask;
        }

        public ValueTask DisposeAsync()
        {
            State = ConnectionState.Disconnected;
            return ValueTask.CompletedTask;
        }
    }
}

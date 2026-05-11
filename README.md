# Dreamine.Communication.Abstractions

`Dreamine.Communication.Abstractions` provides the core contracts, models, options, and lifecycle interfaces for the Dreamine Communication package family.

This package does not implement any concrete communication protocol.  
It defines the common foundation used by TCP, Serial, RabbitMQ, and future communication adapters.

[➡️ 한국어 문서 보기](./README_KO.md)

## Purpose

The purpose of this package is to keep communication-dependent code isolated from application logic.

Application code should depend on abstractions such as `IMessageBus`, `IMessageTransport`, and `MessageEnvelope`, instead of depending directly on TCP, SerialPort, RabbitMQ, or any other specific technology.

## Included Components

### Interfaces

- `IConnectionLifecycle`
- `IMessageBus`
- `IMessageTransport`
- `IMessageRouter`
- `IMessageSerializer`

### Models

- `MessageEnvelope`
- `CommunicationError`

### Options

- `CommunicationOptions`
- `MessageBusOptions`
- `TransportOptions`

### Enums

- `ConnectionState`
- `TransportKind`

### Exceptions

- `CommunicationException`
- `CommunicationConnectionException`

## Design Principles

- Keep abstractions independent from concrete implementations.
- Prevent the core application layer from depending on transport-specific libraries.
- Allow transport adapters such as TCP, Serial, RabbitMQ, MQTT, and HTTP to be added without changing the upper layers.
- Follow dependency inversion and interface-based design.
- Keep the package lightweight and framework-independent.

## Package Role

This package is the lowest-level contract package in the Dreamine Communication architecture.

```text
Dreamine.Communication.Abstractions
    ↑
Dreamine.Communication.Core
    ↑
Sockets / Serial / RabbitMQ / WPF
```

`Abstractions` must not reference `Core`, `Sockets`, `Serial`, `RabbitMQ`, or `WPF`.

## Target Framework

```text
net8.0
```

This package does not require WPF and does not depend on any Windows-specific UI framework.

## Example

```csharp
using Dreamine.Communication.Abstractions.Interfaces;
using Dreamine.Communication.Abstractions.Models;

public sealed class MachineMessageService
{
    private readonly IMessageBus _messageBus;

    public MachineMessageService(IMessageBus messageBus)
    {
        _messageBus = messageBus;
    }

    public Task PublishStartAsync(CancellationToken cancellationToken = default)
    {
        var message = new MessageEnvelope
        {
            Name = "Machine.Start",
            Route = "machine.command.start",
            Payload = Array.Empty<byte>()
        };

        return _messageBus.PublishAsync(message, cancellationToken);
    }
}
```

## Related Packages

- `Dreamine.Communication.Core`
- `Dreamine.Communication.Sockets`
- `Dreamine.Communication.Serial`
- `Dreamine.Communication.RabbitMQ`
- `Dreamine.Communication.FullKit`

## License

This project is licensed under the MIT License.

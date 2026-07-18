using System;
using System.Threading;
using System.Threading.Tasks;
using Dreamine.Communication.Abstractions.Enums;
using Dreamine.Communication.Abstractions.Models;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// \if KO
/// <para>메시지 발행 및 구독 기능을 제공하는 공통 메시지 버스 계약입니다.</para>
/// \endif
/// \if EN
/// <para>Defines a common message bus contract for publishing and subscribing to messages.</para>
/// \endif
/// </summary>
public interface IMessageBus : IConnectionLifecycle, IAsyncDisposable
{
    /// <summary>
    /// \if KO
    /// <para>메시지 버스가 사용하는 전송 방식의 종류를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the transport kind used by the message bus.</para>
    /// \endif
    /// </summary>
    TransportKind Kind { get; }

    /// <summary>
    /// \if KO
    /// <para>메시지를 비동기적으로 발행합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously publishes a message.</para>
    /// \endif
    /// </summary>
    /// <param name="message">
    /// \if KO
    /// <para>발행할 메시지 봉투입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The message envelope to publish.</para>
    /// \endif
    /// </param>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>발행 작업 취소 요청을 감시하는 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A token used to observe requests to cancel the publish operation.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>비동기 발행 작업을 나타내는 작업입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A task that represents the asynchronous publish operation.</para>
    /// \endif
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// \if KO
    /// <para><paramref name="message"/>가 <see langword="null"/>인 경우 발생할 수 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>May be thrown when <paramref name="message"/> is <see langword="null"/>.</para>
    /// \endif
    /// </exception>
    /// <exception cref="OperationCanceledException">
    /// \if KO
    /// <para>취소 토큰을 통해 작업 취소가 요청된 경우 발생할 수 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>May be thrown when cancellation is requested through the cancellation token.</para>
    /// \endif
    /// </exception>
    Task PublishAsync(
        MessageEnvelope message,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>지정한 라우트의 메시지를 비동기적으로 구독합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously subscribes to messages for the specified route.</para>
    /// \endif
    /// </summary>
    /// <param name="route">
    /// \if KO
    /// <para>구독할 메시지 라우트입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The message route to subscribe to.</para>
    /// \endif
    /// </param>
    /// <param name="handler">
    /// \if KO
    /// <para>수신된 메시지를 처리할 비동기 처리기입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The asynchronous handler that processes received messages.</para>
    /// \endif
    /// </param>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>구독 작업 취소 요청을 감시하는 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A token used to observe requests to cancel the subscription operation.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>비동기 구독 작업을 나타내는 작업입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A task that represents the asynchronous subscription operation.</para>
    /// \endif
    /// </returns>
    /// <exception cref="ArgumentException">
    /// \if KO
    /// <para><paramref name="route"/>가 비어 있거나 올바르지 않은 경우 발생할 수 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>May be thrown when <paramref name="route"/> is empty or invalid.</para>
    /// \endif
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// \if KO
    /// <para><paramref name="handler"/>가 <see langword="null"/>인 경우 발생할 수 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>May be thrown when <paramref name="handler"/> is <see langword="null"/>.</para>
    /// \endif
    /// </exception>
    /// <exception cref="OperationCanceledException">
    /// \if KO
    /// <para>취소 토큰을 통해 작업 취소가 요청된 경우 발생할 수 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>May be thrown when cancellation is requested through the cancellation token.</para>
    /// \endif
    /// </exception>
    Task SubscribeAsync(
        string route,
        Func<MessageEnvelope, CancellationToken, Task> handler,
        CancellationToken cancellationToken = default);
}

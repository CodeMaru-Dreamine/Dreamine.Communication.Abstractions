using System;
using System.Threading;
using System.Threading.Tasks;
using Dreamine.Communication.Abstractions.Enums;
using Dreamine.Communication.Abstractions.Models;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// \if KO
/// <para>연결 기반 메시지 전송 계층의 공통 계약입니다.</para>
/// \endif
/// \if EN
/// <para>Defines the common contract for connection-oriented message transports.</para>
/// \endif
/// </summary>
public interface IMessageTransport : IConnectionLifecycle, IAsyncDisposable
{
    /// <summary>
    /// \if KO
    /// <para>전송 계층이 사용하는 전송 방식의 종류를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the transport kind used by this transport.</para>
    /// \endif
    /// </summary>
    TransportKind Kind { get; }

    /// <summary>
    /// \if KO
    /// <para>메시지를 수신했을 때 발생합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Occurs when a message is received.</para>
    /// \endif
    /// </summary>
    event EventHandler<MessageEnvelope>? MessageReceived;

    /// <summary>
    /// \if KO
    /// <para>메시지를 비동기적으로 전송합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously sends a message.</para>
    /// \endif
    /// </summary>
    /// <param name="message">
    /// \if KO
    /// <para>전송할 메시지 봉투입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The message envelope to send.</para>
    /// \endif
    /// </param>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>전송 작업 취소 요청을 감시하는 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A token used to observe requests to cancel the send operation.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>비동기 전송 작업을 나타내는 작업입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A task that represents the asynchronous send operation.</para>
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
    Task SendAsync(
        MessageEnvelope message,
        CancellationToken cancellationToken = default);
}

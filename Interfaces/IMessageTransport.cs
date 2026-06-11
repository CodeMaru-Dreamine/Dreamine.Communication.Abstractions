using System;
using System.Threading;
using System.Threading.Tasks;
using Dreamine.Communication.Abstractions.Enums;
using Dreamine.Communication.Abstractions.Models;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// 연결 기반 메시지 전송 계층의 공통 계약입니다.
/// </summary>
public interface IMessageTransport : IConnectionLifecycle, IAsyncDisposable
{
    /// <summary>
    /// 전송 방식 종류를 가져옵니다.
    /// </summary>
    TransportKind Kind { get; }

    /// <summary>
    /// 메시지를 수신했을 때 발생합니다.
    /// </summary>
    event EventHandler<MessageEnvelope>? MessageReceived;

    /// <summary>
    /// 메시지를 전송합니다.
    /// </summary>
    /// <param name="message">전송할 메시지입니다.</param>
    /// <param name="cancellationToken">취소 토큰입니다.</param>
    Task SendAsync(
        MessageEnvelope message,
        CancellationToken cancellationToken = default);
}
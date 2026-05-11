using System;
using System.Threading;
using System.Threading.Tasks;
using Dreamine.Communication.Abstractions.Enums;
using Dreamine.Communication.Abstractions.Models;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// \brief 메시지 발행 및 구독 기능을 제공하는 공통 메시지 버스 계약입니다.
/// </summary>
public interface IMessageBus : IConnectionLifecycle, IAsyncDisposable
{
    /// <summary>
    /// \brief 메시지 버스 종류를 가져옵니다.
    /// </summary>
    TransportKind Kind { get; }

    /// <summary>
    /// \brief 메시지를 발행합니다.
    /// </summary>
    /// <param name="message">발행할 메시지입니다.</param>
    /// <param name="cancellationToken">취소 토큰입니다.</param>
    Task PublishAsync(
        MessageEnvelope message,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// \brief 지정한 라우트의 메시지를 구독합니다.
    /// </summary>
    /// <param name="route">구독할 라우트입니다.</param>
    /// <param name="handler">메시지 처리기입니다.</param>
    /// <param name="cancellationToken">취소 토큰입니다.</param>
    Task SubscribeAsync(
        string route,
        Func<MessageEnvelope, CancellationToken, Task> handler,
        CancellationToken cancellationToken = default);
}
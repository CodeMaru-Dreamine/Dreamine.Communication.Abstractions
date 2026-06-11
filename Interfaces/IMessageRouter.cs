using System.Threading;
using System.Threading.Tasks;
using Dreamine.Communication.Abstractions.Models;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// 메시지 라우팅 기능의 공통 계약입니다.
/// </summary>
public interface IMessageRouter
{
    /// <summary>
    /// 메시지를 라우트에 따라 처리합니다.
    /// </summary>
    /// <param name="message">라우팅할 메시지입니다.</param>
    /// <param name="cancellationToken">취소 토큰입니다.</param>
    Task RouteAsync(
        MessageEnvelope message,
        CancellationToken cancellationToken = default);
}
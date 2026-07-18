using System.Threading;
using System.Threading.Tasks;
using Dreamine.Communication.Abstractions.Models;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// \if KO
/// <para>메시지 라우팅 기능의 공통 계약입니다.</para>
/// \endif
/// \if EN
/// <para>Defines the common contract for routing messages.</para>
/// \endif
/// </summary>
public interface IMessageRouter
{
    /// <summary>
    /// \if KO
    /// <para>메시지의 라우트 정보에 따라 메시지를 비동기적으로 처리합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously processes a message according to its route information.</para>
    /// \endif
    /// </summary>
    /// <param name="message">
    /// \if KO
    /// <para>라우팅할 메시지 봉투입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The message envelope to route.</para>
    /// \endif
    /// </param>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>라우팅 작업 취소 요청을 감시하는 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A token used to observe requests to cancel the routing operation.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>비동기 라우팅 작업을 나타내는 작업입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A task that represents the asynchronous routing operation.</para>
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
    Task RouteAsync(
        MessageEnvelope message,
        CancellationToken cancellationToken = default);
}

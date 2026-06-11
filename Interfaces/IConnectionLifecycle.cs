using System.Threading;
using System.Threading.Tasks;
using Dreamine.Communication.Abstractions.Enums;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// 연결 생명주기를 가지는 통신 객체의 공통 계약입니다.
/// </summary>
public interface IConnectionLifecycle
{
    /// <summary>
    /// 현재 연결 상태를 가져옵니다.
    /// </summary>
    ConnectionState State { get; }

    /// <summary>
    /// 연결을 시작합니다.
    /// </summary>
    /// <param name="cancellationToken">취소 토큰입니다.</param>
    Task ConnectAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// 연결을 종료합니다.
    /// </summary>
    /// <param name="cancellationToken">취소 토큰입니다.</param>
    Task DisconnectAsync(CancellationToken cancellationToken = default);
}
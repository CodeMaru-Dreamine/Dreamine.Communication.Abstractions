using System;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// \brief 서버형 Transport의 접속 클라이언트 모니터링 정보를 제공하는 계약입니다.
/// </summary>
public interface IServerTransportMonitor
{
    /// <summary>
    /// \brief 현재 서버에 연결된 클라이언트 수를 가져옵니다.
    /// </summary>
    int ConnectedClientCount { get; }

    /// <summary>
    /// \brief 서버에 연결된 클라이언트 수가 변경될 때 발생합니다.
    /// </summary>
    event EventHandler<int>? ConnectedClientCountChanged;
}

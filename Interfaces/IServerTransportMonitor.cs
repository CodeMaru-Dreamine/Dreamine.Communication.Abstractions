using System;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// \if KO
/// <para>서버형 전송 계층의 접속 클라이언트 모니터링 정보를 제공하는 계약입니다.</para>
/// \endif
/// \if EN
/// <para>Defines monitoring information for clients connected to a server transport.</para>
/// \endif
/// </summary>
public interface IServerTransportMonitor
{
    /// <summary>
    /// \if KO
    /// <para>현재 서버에 연결된 클라이언트 수를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the number of clients currently connected to the server.</para>
    /// \endif
    /// </summary>
    int ConnectedClientCount { get; }

    /// <summary>
    /// \if KO
    /// <para>서버에 연결된 클라이언트 수가 변경될 때 발생합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Occurs when the number of clients connected to the server changes.</para>
    /// \endif
    /// </summary>
    event EventHandler<int>? ConnectedClientCountChanged;
}

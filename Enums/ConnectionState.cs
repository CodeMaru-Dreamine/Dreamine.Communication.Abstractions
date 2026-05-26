namespace Dreamine.Communication.Abstractions.Enums;

/// <summary>
/// \brief 통신 연결 상태를 나타냅니다.
/// </summary>
public enum ConnectionState
{
    /// <summary>
    /// \brief 연결되지 않은 상태입니다.
    /// </summary>
    Disconnected = 0,

    /// <summary>
    /// \brief 연결을 시도 중인 상태입니다.
    /// </summary>
    Connecting = 1,

    /// <summary>
    /// \brief 연결된 상태입니다. TCP Client에서는 원격 대상에 연결된 상태를 의미합니다.
    /// </summary>
    Connected = 2,

    /// <summary>
    /// \brief 연결 해제 중인 상태입니다.
    /// </summary>
    Disconnecting = 3,

    /// <summary>
    /// \brief 오류 상태입니다.
    /// </summary>
    Faulted = 4,

    /// <summary>
    /// \brief TCP Server가 클라이언트 접속을 수신 대기 중인 상태입니다.
    /// </summary>
    Listening = 5
}

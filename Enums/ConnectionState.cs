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
    /// \brief 연결된 상태입니다.
    /// </summary>
    Connected = 2,

    /// <summary>
    /// \brief 연결 해제 중인 상태입니다.
    /// </summary>
    Disconnecting = 3,

    /// <summary>
    /// \brief 오류 상태입니다.
    /// </summary>
    Faulted = 4
}
namespace Dreamine.Communication.Abstractions.Enums;

/// <summary>
/// \if KO
/// <para>통신 연결 상태를 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Specifies the state of a communication connection.</para>
/// \endif
/// </summary>
public enum ConnectionState
{
    /// <summary>
    /// \if KO
    /// <para>연결되지 않은 상태입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The communication object is disconnected.</para>
    /// \endif
    /// </summary>
    Disconnected = 0,

    /// <summary>
    /// \if KO
    /// <para>연결을 시도 중인 상태입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A connection attempt is in progress.</para>
    /// \endif
    /// </summary>
    Connecting = 1,

    /// <summary>
    /// \if KO
    /// <para>연결된 상태입니다. TCP 클라이언트에서는 원격 대상에 연결된 상태를 의미합니다.</para>
    /// \endif
    /// \if EN
    /// <para>The communication object is connected; for a TCP client, it is connected to the remote endpoint.</para>
    /// \endif
    /// </summary>
    Connected = 2,

    /// <summary>
    /// \if KO
    /// <para>연결 해제 중인 상태입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A disconnection operation is in progress.</para>
    /// \endif
    /// </summary>
    Disconnecting = 3,

    /// <summary>
    /// \if KO
    /// <para>연결 또는 통신 오류로 인해 장애 상태입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The communication object is faulted because of a connection or communication error.</para>
    /// \endif
    /// </summary>
    Faulted = 4,

    /// <summary>
    /// \if KO
    /// <para>TCP 서버가 클라이언트 접속을 수신 대기 중인 상태입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A TCP server is listening for incoming client connections.</para>
    /// \endif
    /// </summary>
    Listening = 5
}

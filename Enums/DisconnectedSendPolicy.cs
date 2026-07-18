namespace Dreamine.Communication.Abstractions.Enums;

/// <summary>
/// \if KO
/// <para>연결이 끊긴 상태에서 송신 요청을 처리하는 정책입니다.</para>
/// \endif
/// \if EN
/// <para>Specifies how send requests are handled while disconnected.</para>
/// \endif
/// </summary>
public enum DisconnectedSendPolicy
{
    /// <summary>
    /// \if KO
    /// <para>송신 요청을 즉시 실패 처리합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Fails the send request immediately.</para>
    /// \endif
    /// </summary>
    Fail = 0,

    /// <summary>
    /// \if KO
    /// <para>송신 요청을 큐에 저장하고 연결 복구 후 전송합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Queues the send request and transmits it after the connection is restored.</para>
    /// \endif
    /// </summary>
    Queue = 1,

    /// <summary>
    /// \if KO
    /// <para>연결될 때까지 대기한 뒤 전송합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Waits for a connection before transmitting the message.</para>
    /// \endif
    /// </summary>
    WaitUntilConnected = 2
}

namespace Dreamine.Communication.Abstractions.Enums;

/// <summary>
/// \if KO
/// <para>통신 전송 방식의 종류를 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Specifies the kind of communication transport.</para>
/// \endif
/// </summary>
public enum TransportKind
{
    /// <summary>
    /// \if KO
    /// <para>프로세스 메모리 내부 통신입니다.</para>
    /// \endif
    /// \if EN
    /// <para>In-process, in-memory communication.</para>
    /// \endif
    /// </summary>
    InMemory = 0,

    /// <summary>
    /// \if KO
    /// <para>RS-232 또는 기타 시리얼 통신입니다.</para>
    /// \endif
    /// \if EN
    /// <para>RS-232 or other serial communication.</para>
    /// \endif
    /// </summary>
    Serial = 1,

    /// <summary>
    /// \if KO
    /// <para>TCP 통신입니다.</para>
    /// \endif
    /// \if EN
    /// <para>TCP communication.</para>
    /// \endif
    /// </summary>
    Tcp = 2,

    /// <summary>
    /// \if KO
    /// <para>UDP 통신입니다.</para>
    /// \endif
    /// \if EN
    /// <para>UDP communication.</para>
    /// \endif
    /// </summary>
    Udp = 3,

    /// <summary>
    /// \if KO
    /// <para>HTTP 기반 통신입니다.</para>
    /// \endif
    /// \if EN
    /// <para>HTTP-based communication.</para>
    /// \endif
    /// </summary>
    Http = 4,

    /// <summary>
    /// \if KO
    /// <para>RabbitMQ 기반 메시지 브로커 통신입니다.</para>
    /// \endif
    /// \if EN
    /// <para>RabbitMQ-based message broker communication.</para>
    /// \endif
    /// </summary>
    RabbitMq = 5
}

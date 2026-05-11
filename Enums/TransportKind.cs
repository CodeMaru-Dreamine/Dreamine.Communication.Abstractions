namespace Dreamine.Communication.Abstractions.Enums;

/// <summary>
/// \brief 통신 전송 방식의 종류를 나타냅니다.
/// </summary>
public enum TransportKind
{
    /// <summary>
    /// \brief 메모리 내부 통신입니다.
    /// </summary>
    InMemory = 0,

    /// <summary>
    /// \brief RS232 또는 시리얼 통신입니다.
    /// </summary>
    Serial = 1,

    /// <summary>
    /// \brief TCP 통신입니다.
    /// </summary>
    Tcp = 2,

    /// <summary>
    /// \brief UDP 통신입니다.
    /// </summary>
    Udp = 3,

    /// <summary>
    /// \brief HTTP 기반 통신입니다.
    /// </summary>
    Http = 4,

    /// <summary>
    /// \brief RabbitMQ 기반 메시지 브로커 통신입니다.
    /// </summary>
    RabbitMq = 5
}
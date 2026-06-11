namespace Dreamine.Communication.Abstractions.Enums;

/// <summary>
/// 통신 전송 방식의 종류를 나타냅니다.
/// </summary>
public enum TransportKind
{
    /// <summary>
    /// 메모리 내부 통신입니다.
    /// </summary>
    InMemory = 0,

    /// <summary>
    /// RS232 또는 시리얼 통신입니다.
    /// </summary>
    Serial = 1,

    /// <summary>
    /// TCP 통신입니다.
    /// </summary>
    Tcp = 2,

    /// <summary>
    /// UDP 통신입니다.
    /// </summary>
    Udp = 3,

    /// <summary>
    /// HTTP 기반 통신입니다.
    /// </summary>
    Http = 4,

    /// <summary>
    /// RabbitMQ 기반 메시지 브로커 통신입니다.
    /// </summary>
    RabbitMq = 5
}
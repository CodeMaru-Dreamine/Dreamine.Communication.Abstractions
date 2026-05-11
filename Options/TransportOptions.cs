using Dreamine.Communication.Abstractions.Enums;

namespace Dreamine.Communication.Abstractions.Options;

/// <summary>
/// \brief 연결 기반 전송 계층 설정입니다.
/// </summary>
public sealed class TransportOptions
{
    /// <summary>
    /// \brief 전송 방식입니다.
    /// </summary>
    public TransportKind Kind { get; set; } = TransportKind.Tcp;

    /// <summary>
    /// \brief 통신 대상 호스트입니다.
    /// TCP 또는 HTTP 계열에서 사용합니다.
    /// </summary>
    public string Host { get; set; } = "127.0.0.1";

    /// <summary>
    /// \brief 통신 대상 포트입니다.
    /// </summary>
    public int Port { get; set; } = 0;

    /// <summary>
    /// \brief 시리얼 포트 이름입니다.
    /// RS232 계열에서 사용합니다.
    /// </summary>
    public string PortName { get; set; } = "COM1";

    /// <summary>
    /// \brief 시리얼 통신 속도입니다.
    /// RS232 계열에서 사용합니다.
    /// </summary>
    public int BaudRate { get; set; } = 9600;

    /// <summary>
    /// \brief 읽기 타임아웃(ms)입니다.
    /// </summary>
    public int ReadTimeoutMs { get; set; } = 3000;

    /// <summary>
    /// \brief 쓰기 타임아웃(ms)입니다.
    /// </summary>
    public int WriteTimeoutMs { get; set; } = 3000;
}
using Dreamine.Communication.Abstractions.Enums;

namespace Dreamine.Communication.Abstractions.Options;

/// <summary>
/// \if KO
/// <para>연결 기반 전송 계층의 네트워크 및 시리얼 연결 값을 구성합니다.</para>
/// \endif
/// \if EN
/// <para>Configures network and serial connection values for a connection-oriented transport.</para>
/// \endif
/// </summary>
public sealed class TransportOptions
{
    /// <summary>
    /// \if KO
    /// <para>사용할 전송 방식을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the transport kind to use.</para>
    /// \endif
    /// </summary>
    public TransportKind Kind { get; set; } = TransportKind.Tcp;

    /// <summary>
    /// \if KO
    /// <para>통신 대상 호스트 이름 또는 IP 주소를 가져오거나 설정합니다. TCP 또는 HTTP 계열에서 사용합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the target host name or IP address used by TCP- or HTTP-based transports.</para>
    /// \endif
    /// </summary>
    public string Host { get; set; } = "127.0.0.1";

    /// <summary>
    /// \if KO
    /// <para>통신 대상의 네트워크 포트 번호를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the network port number of the communication endpoint.</para>
    /// \endif
    /// </summary>
    public int Port { get; set; } = 0;

    /// <summary>
    /// \if KO
    /// <para>RS-232 계열 전송에서 사용할 시리얼 포트 이름을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the serial port name used by RS-232 transports.</para>
    /// \endif
    /// </summary>
    public string PortName { get; set; } = "COM1";

    /// <summary>
    /// \if KO
    /// <para>RS-232 계열 전송에서 사용할 보드율을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the baud rate used by RS-232 transports.</para>
    /// \endif
    /// </summary>
    public int BaudRate { get; set; } = 9600;

    /// <summary>
    /// \if KO
    /// <para>읽기 작업의 제한 시간(밀리초)을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the read timeout, in milliseconds.</para>
    /// \endif
    /// </summary>
    public int ReadTimeoutMs { get; set; } = 3000;

    /// <summary>
    /// \if KO
    /// <para>쓰기 작업의 제한 시간(밀리초)을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the write timeout, in milliseconds.</para>
    /// \endif
    /// </summary>
    public int WriteTimeoutMs { get; set; } = 3000;
}

namespace Dreamine.Communication.Abstractions.Options;

/// <summary>
/// \if KO
/// <para>Dreamine Communication 인스턴스의 공통 동작을 구성합니다.</para>
/// \endif
/// \if EN
/// <para>Configures common behavior for a Dreamine Communication instance.</para>
/// \endif
/// </summary>
public sealed class CommunicationOptions
{
    /// <summary>
    /// \if KO
    /// <para>로그와 진단에서 통신 인스턴스를 식별할 이름을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the name used to identify the communication instance in logs and diagnostics.</para>
    /// \endif
    /// </summary>
    public string Name { get; set; } = "DefaultCommunication";

    /// <summary>
    /// \if KO
    /// <para>초기화 시 자동으로 연결할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether to connect automatically during initialization.</para>
    /// \endif
    /// </summary>
    public bool AutoConnect { get; set; } = false;

    /// <summary>
    /// \if KO
    /// <para>연결 오류 후 자동 재연결을 사용할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether automatic reconnection is enabled after a connection error.</para>
    /// \endif
    /// </summary>
    public bool EnableAutoReconnect { get; set; } = false;

    /// <summary>
    /// \if KO
    /// <para>재연결 시도 사이의 대기 시간(밀리초)을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the delay, in milliseconds, between reconnection attempts.</para>
    /// \endif
    /// </summary>
    public int ReconnectIntervalMs { get; set; } = 3000;
}

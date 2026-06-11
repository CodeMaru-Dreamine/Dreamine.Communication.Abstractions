namespace Dreamine.Communication.Abstractions.Options;

/// <summary>
/// Dreamine Communication 전체 설정입니다.
/// </summary>
public sealed class CommunicationOptions
{
    /// <summary>
    /// 통신 이름입니다.
    /// </summary>
    public string Name { get; set; } = "DefaultCommunication";

    /// <summary>
    /// 자동 연결 여부입니다.
    /// </summary>
    public bool AutoConnect { get; set; } = false;

    /// <summary>
    /// 오류 발생 시 자동 재연결을 사용할지 여부입니다.
    /// </summary>
    public bool EnableAutoReconnect { get; set; } = false;

    /// <summary>
    /// 재연결 간격(ms)입니다.
    /// </summary>
    public int ReconnectIntervalMs { get; set; } = 3000;
}
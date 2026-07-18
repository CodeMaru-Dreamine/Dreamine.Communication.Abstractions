namespace Dreamine.Communication.Abstractions.Options;

/// <summary>
/// \if KO
/// <para>연결 실패 후 적용할 자동 재연결 및 지수 백오프 정책을 구성합니다.</para>
/// \endif
/// \if EN
/// <para>Configures automatic reconnection and exponential backoff after connection failures.</para>
/// \endif
/// </summary>
public sealed class ReconnectPolicy
{
    /// <summary>
    /// \if KO
    /// <para>자동 재연결을 사용할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether automatic reconnection is enabled.</para>
    /// \endif
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// \if KO
    /// <para>첫 재연결 시도 전의 대기 시간을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the delay before the first reconnection attempt.</para>
    /// \endif
    /// </summary>
    public TimeSpan InitialDelay { get; set; } = TimeSpan.FromSeconds(1);

    /// <summary>
    /// \if KO
    /// <para>재연결 시도 사이에 허용되는 최대 대기 시간을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the maximum delay allowed between reconnection attempts.</para>
    /// \endif
    /// </summary>
    public TimeSpan MaxDelay { get; set; } = TimeSpan.FromSeconds(10);

    /// <summary>
    /// \if KO
    /// <para>재연결 실패 후 대기 시간에 적용할 증가 배율을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the multiplier applied to the delay after a failed reconnection attempt.</para>
    /// \endif
    /// </summary>
    public double BackoffFactor { get; set; } = 1.5;

    /// <summary>
    /// \if KO
    /// <para>최대 재시도 횟수를 가져오거나 설정합니다. <see langword="null"/>이면 횟수를 제한하지 않습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the maximum retry count; <see langword="null"/> allows unlimited retries.</para>
    /// \endif
    /// </summary>
    public int? MaxRetryCount { get; set; }

    /// <summary>
    /// \if KO
    /// <para>연결 상태를 감시하는 주기를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the interval at which the connection state is monitored.</para>
    /// \endif
    /// </summary>
    public TimeSpan WatchInterval { get; set; } = TimeSpan.FromMilliseconds(500);
}

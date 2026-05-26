namespace Dreamine.Communication.Abstractions.Options;

/// <summary>
/// \brief 자동 재연결 정책입니다.
/// </summary>
public sealed class ReconnectPolicy
{
    /// <summary>
    /// \brief 자동 재연결 사용 여부입니다.
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// \brief 최초 재연결 대기 시간입니다.
    /// </summary>
    public TimeSpan InitialDelay { get; set; } = TimeSpan.FromSeconds(1);

    /// <summary>
    /// \brief 최대 재연결 대기 시간입니다.
    /// </summary>
    public TimeSpan MaxDelay { get; set; } = TimeSpan.FromSeconds(10);

    /// <summary>
    /// \brief 재연결 실패 시 대기 시간 증가 배율입니다.
    /// </summary>
    public double BackoffFactor { get; set; } = 1.5;

    /// <summary>
    /// \brief 최대 재시도 횟수입니다. null이면 무제한입니다.
    /// </summary>
    public int? MaxRetryCount { get; set; }

    /// <summary>
    /// \brief 연결 상태를 감시하는 주기입니다.
    /// </summary>
    public TimeSpan WatchInterval { get; set; } = TimeSpan.FromMilliseconds(500);
}

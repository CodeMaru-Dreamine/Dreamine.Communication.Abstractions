using Dreamine.Communication.Abstractions.Enums;

namespace Dreamine.Communication.Abstractions.Options;

/// <summary>
/// \brief 송신 큐 설정입니다.
/// </summary>
public sealed class OutboundQueueOptions
{
    /// <summary>
    /// \brief 연결 끊김 상태에서 송신 요청을 처리하는 정책입니다.
    /// </summary>
    public DisconnectedSendPolicy DisconnectedSendPolicy { get; set; }
        = DisconnectedSendPolicy.Queue;

    /// <summary>
    /// \brief 송신 큐 최대 크기입니다.
    /// </summary>
    public int MaxQueueSize { get; set; } = 10_000;

    /// <summary>
    /// \brief 큐가 가득 찼을 때 가장 오래된 메시지를 제거할지 여부입니다.
    /// </summary>
    public bool DropOldestWhenFull { get; set; } = true;

    /// <summary>
    /// \brief 큐에 저장된 메시지의 최대 보관 시간입니다. null이면 만료하지 않습니다.
    /// </summary>
    public TimeSpan? MaxMessageAge { get; set; } = TimeSpan.FromSeconds(30);

    /// <summary>
    /// \brief 재연결 성공 시 큐를 자동으로 전송할지 여부입니다.
    /// </summary>
    public bool FlushOnReconnect { get; set; } = true;
}

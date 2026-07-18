using Dreamine.Communication.Abstractions.Enums;

namespace Dreamine.Communication.Abstractions.Options;

/// <summary>
/// \if KO
/// <para>연결되지 않은 동안 사용할 송신 큐의 동작과 제한을 구성합니다.</para>
/// \endif
/// \if EN
/// <para>Configures the behavior and limits of the outbound queue used while disconnected.</para>
/// \endif
/// </summary>
public sealed class OutboundQueueOptions
{
    /// <summary>
    /// \if KO
    /// <para>연결 끊김 상태에서 송신 요청을 처리하는 정책을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the policy used for send requests while disconnected.</para>
    /// \endif
    /// </summary>
    public DisconnectedSendPolicy DisconnectedSendPolicy { get; set; }
        = DisconnectedSendPolicy.Queue;

    /// <summary>
    /// \if KO
    /// <para>송신 큐에 보관할 수 있는 최대 메시지 수를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the maximum number of messages retained in the outbound queue.</para>
    /// \endif
    /// </summary>
    public int MaxQueueSize { get; set; } = 10_000;

    /// <summary>
    /// \if KO
    /// <para>큐가 가득 찼을 때 가장 오래된 메시지를 제거할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether the oldest message is removed when the queue is full.</para>
    /// \endif
    /// </summary>
    public bool DropOldestWhenFull { get; set; } = true;

    /// <summary>
    /// \if KO
    /// <para>큐에 저장된 메시지의 최대 보관 시간을 가져오거나 설정합니다. <see langword="null"/>이면 만료하지 않습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the maximum age of a queued message; <see langword="null"/> disables expiration.</para>
    /// \endif
    /// </summary>
    public TimeSpan? MaxMessageAge { get; set; } = TimeSpan.FromSeconds(30);

    /// <summary>
    /// \if KO
    /// <para>재연결에 성공했을 때 큐의 메시지를 자동으로 전송할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether queued messages are flushed automatically after reconnection.</para>
    /// \endif
    /// </summary>
    public bool FlushOnReconnect { get; set; } = true;
}

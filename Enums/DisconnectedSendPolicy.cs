namespace Dreamine.Communication.Abstractions.Enums;

/// <summary>
/// 연결이 끊긴 상태에서 송신 요청을 처리하는 정책입니다.
/// </summary>
public enum DisconnectedSendPolicy
{
    /// <summary>
    /// 즉시 실패합니다.
    /// </summary>
    Fail = 0,

    /// <summary>
    /// 송신 요청을 큐에 저장하고 연결 복구 후 전송합니다.
    /// </summary>
    Queue = 1,

    /// <summary>
    /// 연결될 때까지 대기한 뒤 전송합니다.
    /// </summary>
    WaitUntilConnected = 2
}

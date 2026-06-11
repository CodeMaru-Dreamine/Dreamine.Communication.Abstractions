using System;

namespace Dreamine.Communication.Abstractions.Models;

/// <summary>
/// 통신 계층에서 발생한 오류 정보를 나타냅니다.
/// </summary>
public sealed class CommunicationError
{
    /// <summary>
    /// 오류 코드입니다.
    /// </summary>
    public string Code { get; init; } = string.Empty;

    /// <summary>
    /// 오류 메시지입니다.
    /// </summary>
    public string Message { get; init; } = string.Empty;

    /// <summary>
    /// 오류 발생 위치 또는 통신 채널 이름입니다.
    /// </summary>
    public string Source { get; init; } = string.Empty;

    /// <summary>
    /// 내부 예외입니다.
    /// </summary>
    public Exception? Exception { get; init; }

    /// <summary>
    /// 오류 발생 시각입니다.
    /// </summary>
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
}
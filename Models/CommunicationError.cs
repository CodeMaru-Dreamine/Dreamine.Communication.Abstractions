using System;

namespace Dreamine.Communication.Abstractions.Models;

/// <summary>
/// \if KO
/// <para>통신 계층에서 발생한 구조화된 오류 정보를 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents structured information about an error raised by the communication layer.</para>
/// \endif
/// </summary>
public sealed class CommunicationError
{
    /// <summary>
    /// \if KO
    /// <para>오류를 식별하는 코드입니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the code that identifies the error.</para>
    /// \endif
    /// </summary>
    public string Code { get; init; } = string.Empty;

    /// <summary>
    /// \if KO
    /// <para>오류를 설명하는 사람이 읽을 수 있는 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the human-readable message that describes the error.</para>
    /// \endif
    /// </summary>
    public string Message { get; init; } = string.Empty;

    /// <summary>
    /// \if KO
    /// <para>오류 발생 위치 또는 통신 채널 이름입니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the error source or communication channel name.</para>
    /// \endif
    /// </summary>
    public string Source { get; init; } = string.Empty;

    /// <summary>
    /// \if KO
    /// <para>오류의 원인이 된 내부 예외를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the inner exception that caused the error.</para>
    /// \endif
    /// </summary>
    public Exception? Exception { get; init; }

    /// <summary>
    /// \if KO
    /// <para>오류가 발생한 UTC 기준 시각을 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the UTC timestamp at which the error occurred.</para>
    /// \endif
    /// </summary>
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
}

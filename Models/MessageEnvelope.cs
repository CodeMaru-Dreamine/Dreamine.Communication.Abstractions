using System;
using System.Collections.Generic;

namespace Dreamine.Communication.Abstractions.Models;

/// <summary>
/// \brief Dreamine Communication에서 사용하는 공통 메시지 단위입니다.
/// </summary>
public sealed class MessageEnvelope
{
    /// <summary>
    /// \brief 메시지 고유 식별자입니다.
    /// </summary>
    public string MessageId { get; init; } = Guid.NewGuid().ToString("N");

    /// <summary>
    /// \brief 메시지 이름입니다.
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    /// \brief 메시지 라우트입니다.
    /// </summary>
    public string Route { get; init; } = string.Empty;

    /// <summary>
    /// \brief 실제 전송 데이터입니다.
    /// </summary>
    public byte[] Payload { get; init; } = Array.Empty<byte>();

    /// <summary>
    /// \brief 메시지 헤더입니다.
    /// </summary>
    public IReadOnlyDictionary<string, string> Headers { get; init; }
        = new Dictionary<string, string>();

    /// <summary>
    /// \brief 메시지 생성 시각입니다.
    /// </summary>
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
}
using System;
using System.Collections.Generic;

namespace Dreamine.Communication.Abstractions.Models;

/// <summary>
/// \if KO
/// <para>Dreamine Communication에서 전송과 라우팅에 사용하는 공통 메시지 봉투입니다.</para>
/// \endif
/// \if EN
/// <para>Represents the common message envelope used for transport and routing in Dreamine Communication.</para>
/// \endif
/// </summary>
public sealed class MessageEnvelope
{
    /// <summary>
    /// \if KO
    /// <para>메시지를 고유하게 식별하는 값을 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the value that uniquely identifies the message.</para>
    /// \endif
    /// </summary>
    public string MessageId { get; init; } = Guid.NewGuid().ToString("N");

    /// <summary>
    /// \if KO
    /// <para>메시지의 논리적 이름을 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the logical name of the message.</para>
    /// \endif
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    /// \if KO
    /// <para>메시지를 전달할 라우트를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the route to which the message is delivered.</para>
    /// \endif
    /// </summary>
    public string Route { get; init; } = string.Empty;

    /// <summary>
    /// \if KO
    /// <para>실제 전송할 이진 페이로드를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the binary payload to transport.</para>
    /// \endif
    /// </summary>
    public byte[] Payload { get; init; } = Array.Empty<byte>();

    /// <summary>
    /// \if KO
    /// <para>메시지와 함께 전달되는 읽기 전용 헤더를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the read-only headers carried with the message.</para>
    /// \endif
    /// </summary>
    public IReadOnlyDictionary<string, string> Headers { get; init; }
        = new Dictionary<string, string>();

    /// <summary>
    /// \if KO
    /// <para>메시지가 생성된 UTC 기준 시각을 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the UTC timestamp at which the message was created.</para>
    /// \endif
    /// </summary>
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
}

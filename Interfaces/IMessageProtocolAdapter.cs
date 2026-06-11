using Dreamine.Communication.Abstractions.Models;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// 외부 프로토콜 메시지와 Dreamine 표준 MessageEnvelope 간 변환을 담당하는 계약입니다.
/// </summary>
/// <remarks>
/// FrameCodec은 바이트 스트림에서 하나의 메시지 경계를 분리하고,
/// IMessageProtocolAdapter는 분리된 메시지 데이터를 Dreamine 내부 표준 메시지인
/// MessageEnvelope로 변환합니다.
/// </remarks>
public interface IMessageProtocolAdapter
{
    /// <summary>
    /// 수신된 원시 메시지 데이터를 MessageEnvelope로 변환합니다.
    /// </summary>
    /// <param name="payload">프레임 코덱을 통해 분리된 원시 메시지 데이터입니다.</param>
    /// <returns>Dreamine 내부 표준 메시지입니다.</returns>
    MessageEnvelope Decode(byte[] payload);

    /// <summary>
    /// MessageEnvelope를 외부 프로토콜 송신 데이터로 변환합니다.
    /// </summary>
    /// <param name="message">송신할 Dreamine 내부 표준 메시지입니다.</param>
    /// <returns>외부로 송신할 원시 메시지 데이터입니다.</returns>
    byte[] Encode(MessageEnvelope message);
}
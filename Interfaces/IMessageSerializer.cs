using Dreamine.Communication.Abstractions.Models;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// MessageEnvelope 직렬화 및 역직렬화 계약입니다.
/// </summary>
public interface IMessageSerializer
{
    /// <summary>
    /// 메시지를 바이트 배열로 직렬화합니다.
    /// </summary>
    /// <param name="message">직렬화할 메시지입니다.</param>
    /// <returns>직렬화된 바이트 배열입니다.</returns>
    byte[] Serialize(MessageEnvelope message);

    /// <summary>
    /// 바이트 배열을 메시지로 역직렬화합니다.
    /// </summary>
    /// <param name="data">역직렬화할 바이트 배열입니다.</param>
    /// <returns>역직렬화된 메시지입니다.</returns>
    MessageEnvelope Deserialize(byte[] data);
}
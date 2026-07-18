using Dreamine.Communication.Abstractions.Models;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// \if KO
/// <para><see cref="MessageEnvelope"/> 직렬화 및 역직렬화 계약입니다.</para>
/// \endif
/// \if EN
/// <para>Defines serialization and deserialization for <see cref="MessageEnvelope"/> instances.</para>
/// \endif
/// </summary>
public interface IMessageSerializer
{
    /// <summary>
    /// \if KO
    /// <para>메시지를 바이트 배열로 직렬화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Serializes a message into a byte array.</para>
    /// \endif
    /// </summary>
    /// <param name="message">
    /// \if KO
    /// <para>직렬화할 메시지 봉투입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The message envelope to serialize.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>직렬화된 메시지를 포함하는 바이트 배열입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A byte array containing the serialized message.</para>
    /// \endif
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// \if KO
    /// <para><paramref name="message"/>가 <see langword="null"/>인 경우 발생할 수 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>May be thrown when <paramref name="message"/> is <see langword="null"/>.</para>
    /// \endif
    /// </exception>
    byte[] Serialize(MessageEnvelope message);

    /// <summary>
    /// \if KO
    /// <para>바이트 배열을 메시지로 역직렬화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Deserializes a byte array into a message.</para>
    /// \endif
    /// </summary>
    /// <param name="data">
    /// \if KO
    /// <para>역직렬화할 메시지 데이터를 포함하는 바이트 배열입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The byte array containing the message data to deserialize.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>역직렬화된 메시지 봉투입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The deserialized message envelope.</para>
    /// \endif
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// \if KO
    /// <para><paramref name="data"/>가 <see langword="null"/>인 경우 발생할 수 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>May be thrown when <paramref name="data"/> is <see langword="null"/>.</para>
    /// \endif
    /// </exception>
    /// <exception cref="FormatException">
    /// \if KO
    /// <para>입력 데이터가 구현체가 요구하는 메시지 형식이 아닌 경우 발생할 수 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>May be thrown when the input does not match the message format required by the implementation.</para>
    /// \endif
    /// </exception>
    MessageEnvelope Deserialize(byte[] data);
}

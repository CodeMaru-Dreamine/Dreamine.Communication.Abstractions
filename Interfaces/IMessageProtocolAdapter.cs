using Dreamine.Communication.Abstractions.Models;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// \if KO
/// <para>외부 프로토콜 메시지와 Dreamine 표준 <see cref="MessageEnvelope"/> 간 변환을 담당하는 계약입니다.</para>
/// \endif
/// \if EN
/// <para>Defines conversion between external protocol messages and the Dreamine-standard <see cref="MessageEnvelope"/>.</para>
/// \endif
/// </summary>
/// <remarks>
/// \if KO
/// <para>프레임 코덱은 바이트 스트림에서 메시지 경계를 분리하고, 이 어댑터는 분리된 데이터를 Dreamine 내부 표준 메시지로 변환합니다.</para>
/// \endif
/// \if EN
/// <para>A frame codec separates message boundaries from a byte stream; this adapter converts the separated data into Dreamine's internal standard message.</para>
/// \endif
/// </remarks>
public interface IMessageProtocolAdapter
{
    /// <summary>
    /// \if KO
    /// <para>수신된 원시 메시지 데이터를 <see cref="MessageEnvelope"/>로 변환합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Converts received raw message data into a <see cref="MessageEnvelope"/>.</para>
    /// \endif
    /// </summary>
    /// <param name="payload">
    /// \if KO
    /// <para>프레임 코덱을 통해 분리된 원시 메시지 데이터입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The raw message data separated by a frame codec.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>변환된 Dreamine 내부 표준 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The converted Dreamine-standard internal message.</para>
    /// \endif
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// \if KO
    /// <para><paramref name="payload"/>가 <see langword="null"/>인 경우 발생할 수 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>May be thrown when <paramref name="payload"/> is <see langword="null"/>.</para>
    /// \endif
    /// </exception>
    MessageEnvelope Decode(byte[] payload);

    /// <summary>
    /// \if KO
    /// <para><see cref="MessageEnvelope"/>를 외부 프로토콜 송신 데이터로 변환합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Converts a <see cref="MessageEnvelope"/> into outbound data for an external protocol.</para>
    /// \endif
    /// </summary>
    /// <param name="message">
    /// \if KO
    /// <para>송신할 Dreamine 내부 표준 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The Dreamine-standard internal message to send.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>외부 프로토콜로 송신할 원시 메시지 데이터입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The raw message data to send through the external protocol.</para>
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
    byte[] Encode(MessageEnvelope message);
}

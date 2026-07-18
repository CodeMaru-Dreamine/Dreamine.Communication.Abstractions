using System;

namespace Dreamine.Communication.Abstractions.Exceptions;

/// <summary>
/// \if KO
/// <para>통신 연결 또는 연결 해제 과정에서 발생하는 예외입니다.</para>
/// \endif
/// \if EN
/// <para>Represents an error that occurs while establishing or closing a communication connection.</para>
/// \endif
/// </summary>
public sealed class CommunicationConnectionException : CommunicationException
{
    /// <summary>
    /// \if KO
    /// <para><see cref="CommunicationConnectionException"/> 클래스의 새 인스턴스를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes a new instance of the <see cref="CommunicationConnectionException"/> class.</para>
    /// \endif
    /// </summary>
    public CommunicationConnectionException()
    {
    }

    /// <summary>
    /// \if KO
    /// <para>지정한 오류 메시지를 사용하여 <see cref="CommunicationConnectionException"/> 클래스의 새 인스턴스를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes a new instance of the <see cref="CommunicationConnectionException"/> class with a specified error message.</para>
    /// \endif
    /// </summary>
    /// <param name="message">
    /// \if KO
    /// <para>연결 오류의 원인을 설명하는 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The message that explains the reason for the connection error.</para>
    /// \endif
    /// </param>
    public CommunicationConnectionException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// \if KO
    /// <para>지정한 오류 메시지와 내부 예외를 사용하여 <see cref="CommunicationConnectionException"/> 클래스의 새 인스턴스를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes a new instance of the <see cref="CommunicationConnectionException"/> class with a specified error message and inner exception.</para>
    /// \endif
    /// </summary>
    /// <param name="message">
    /// \if KO
    /// <para>연결 오류의 원인을 설명하는 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The message that explains the reason for the connection error.</para>
    /// \endif
    /// </param>
    /// <param name="innerException">
    /// \if KO
    /// <para>현재 연결 예외의 원인이 된 예외입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The exception that caused the current connection exception.</para>
    /// \endif
    /// </param>
    public CommunicationConnectionException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}

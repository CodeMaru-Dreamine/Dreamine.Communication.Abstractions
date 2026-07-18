using System;

namespace Dreamine.Communication.Abstractions.Exceptions;

/// <summary>
/// \if KO
/// <para>Dreamine Communication 계층에서 발생하는 예외의 기본 클래스입니다.</para>
/// \endif
/// \if EN
/// <para>Provides the base exception for errors raised by the Dreamine Communication layer.</para>
/// \endif
/// </summary>
public class CommunicationException : Exception
{
    /// <summary>
    /// \if KO
    /// <para><see cref="CommunicationException"/> 클래스의 새 인스턴스를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes a new instance of the <see cref="CommunicationException"/> class.</para>
    /// \endif
    /// </summary>
    public CommunicationException()
    {
    }

    /// <summary>
    /// \if KO
    /// <para>지정한 오류 메시지를 사용하여 <see cref="CommunicationException"/> 클래스의 새 인스턴스를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes a new instance of the <see cref="CommunicationException"/> class with a specified error message.</para>
    /// \endif
    /// </summary>
    /// <param name="message">
    /// \if KO
    /// <para>예외의 원인을 설명하는 오류 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The error message that explains the reason for the exception.</para>
    /// \endif
    /// </param>
    public CommunicationException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// \if KO
    /// <para>지정한 오류 메시지와 내부 예외를 사용하여 <see cref="CommunicationException"/> 클래스의 새 인스턴스를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes a new instance of the <see cref="CommunicationException"/> class with a specified error message and inner exception.</para>
    /// \endif
    /// </summary>
    /// <param name="message">
    /// \if KO
    /// <para>예외의 원인을 설명하는 오류 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The error message that explains the reason for the exception.</para>
    /// \endif
    /// </param>
    /// <param name="innerException">
    /// \if KO
    /// <para>현재 예외의 원인이 된 예외입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The exception that caused the current exception.</para>
    /// \endif
    /// </param>
    public CommunicationException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}

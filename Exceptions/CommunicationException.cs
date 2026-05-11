using System;

namespace Dreamine.Communication.Abstractions.Exceptions;

/// <summary>
/// \brief Dreamine Communication 계층에서 발생하는 기본 예외입니다.
/// </summary>
public class CommunicationException : Exception
{
    /// <summary>
    /// \brief CommunicationException 클래스의 새 인스턴스를 초기화합니다.
    /// </summary>
    public CommunicationException()
    {
    }

    /// <summary>
    /// \brief 지정한 오류 메시지를 사용하여 CommunicationException 클래스의 새 인스턴스를 초기화합니다.
    /// </summary>
    /// <param name="message">오류 메시지입니다.</param>
    public CommunicationException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// \brief 지정한 오류 메시지와 내부 예외를 사용하여 CommunicationException 클래스의 새 인스턴스를 초기화합니다.
    /// </summary>
    /// <param name="message">오류 메시지입니다.</param>
    /// <param name="innerException">내부 예외입니다.</param>
    public CommunicationException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
using System;

namespace Dreamine.Communication.Abstractions.Exceptions;

/// <summary>
/// 통신 연결 과정에서 발생하는 예외입니다.
/// </summary>
public sealed class CommunicationConnectionException : CommunicationException
{
    /// <summary>
    /// CommunicationConnectionException 클래스의 새 인스턴스를 초기화합니다.
    /// </summary>
    public CommunicationConnectionException()
    {
    }

    /// <summary>
    /// 지정한 오류 메시지를 사용하여 CommunicationConnectionException 클래스의 새 인스턴스를 초기화합니다.
    /// </summary>
    /// <param name="message">오류 메시지입니다.</param>
    public CommunicationConnectionException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// 지정한 오류 메시지와 내부 예외를 사용하여 CommunicationConnectionException 클래스의 새 인스턴스를 초기화합니다.
    /// </summary>
    /// <param name="message">오류 메시지입니다.</param>
    /// <param name="innerException">내부 예외입니다.</param>
    public CommunicationConnectionException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
using Dreamine.Communication.Abstractions.Enums;

namespace Dreamine.Communication.Abstractions.Options;

/// <summary>
/// \if KO
/// <para>메시지 버스의 전송 방식과 메시지 처리 동작을 구성합니다.</para>
/// \endif
/// \if EN
/// <para>Configures the transport and message-handling behavior of a message bus.</para>
/// \endif
/// </summary>
public sealed class MessageBusOptions
{
    /// <summary>
    /// \if KO
    /// <para>메시지 버스가 사용할 전송 방식을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the transport kind used by the message bus.</para>
    /// \endif
    /// </summary>
    public TransportKind Kind { get; set; } = TransportKind.InMemory;

    /// <summary>
    /// \if KO
    /// <para>메시지에 라우트가 지정되지 않았을 때 사용할 기본 라우트를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the default route used when a message does not specify one.</para>
    /// \endif
    /// </summary>
    public string DefaultRoute { get; set; } = string.Empty;

    /// <summary>
    /// \if KO
    /// <para>메시지 처리기가 실패할 때 예외를 호출자에게 다시 던질지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether handler exceptions are rethrown to the caller.</para>
    /// \endif
    /// </summary>
    public bool ThrowOnHandlerError { get; set; } = true;

    /// <summary>
    /// \if KO
    /// <para>여러 메시지 처리기를 병렬로 실행할지 여부를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets whether multiple message handlers execute in parallel.</para>
    /// \endif
    /// </summary>
    public bool EnableParallelHandlers { get; set; } = false;
}

using Dreamine.Communication.Abstractions.Enums;

namespace Dreamine.Communication.Abstractions.Options;

/// <summary>
/// 메시지 버스 설정입니다.
/// </summary>
public sealed class MessageBusOptions
{
    /// <summary>
    /// 메시지 버스 종류입니다.
    /// </summary>
    public TransportKind Kind { get; set; } = TransportKind.InMemory;

    /// <summary>
    /// 기본 라우트입니다.
    /// </summary>
    public string DefaultRoute { get; set; } = string.Empty;

    /// <summary>
    /// 메시지 처리 실패 시 예외를 다시 던질지 여부입니다.
    /// </summary>
    public bool ThrowOnHandlerError { get; set; } = true;

    /// <summary>
    /// 메시지 핸들러 병렬 실행 여부입니다.
    /// </summary>
    public bool EnableParallelHandlers { get; set; } = false;
}
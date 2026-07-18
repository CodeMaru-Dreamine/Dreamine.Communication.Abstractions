using System.Threading;
using System.Threading.Tasks;
using Dreamine.Communication.Abstractions.Enums;

namespace Dreamine.Communication.Abstractions.Interfaces;

/// <summary>
/// \if KO
/// <para>연결 생명주기를 가지는 통신 객체의 공통 계약입니다.</para>
/// \endif
/// \if EN
/// <para>Defines the common contract for communication objects that have a connection lifecycle.</para>
/// \endif
/// </summary>
public interface IConnectionLifecycle
{
    /// <summary>
    /// \if KO
    /// <para>현재 연결 상태를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the current connection state.</para>
    /// \endif
    /// </summary>
    ConnectionState State { get; }

    /// <summary>
    /// \if KO
    /// <para>통신 대상과의 연결을 비동기적으로 시작합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously establishes a connection to the communication endpoint.</para>
    /// \endif
    /// </summary>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>연결 작업 취소 요청을 감시하는 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A token used to observe requests to cancel the connection operation.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>비동기 연결 작업을 나타내는 작업입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A task that represents the asynchronous connection operation.</para>
    /// \endif
    /// </returns>
    /// <exception cref="OperationCanceledException">
    /// \if KO
    /// <para>취소 토큰을 통해 작업 취소가 요청된 경우 발생할 수 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>May be thrown when cancellation is requested through the cancellation token.</para>
    /// \endif
    /// </exception>
    Task ConnectAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>현재 연결을 비동기적으로 종료합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously closes the current connection.</para>
    /// \endif
    /// </summary>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>연결 종료 작업 취소 요청을 감시하는 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A token used to observe requests to cancel the disconnection operation.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>비동기 연결 종료 작업을 나타내는 작업입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A task that represents the asynchronous disconnection operation.</para>
    /// \endif
    /// </returns>
    /// <exception cref="OperationCanceledException">
    /// \if KO
    /// <para>취소 토큰을 통해 작업 취소가 요청된 경우 발생할 수 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>May be thrown when cancellation is requested through the cancellation token.</para>
    /// \endif
    /// </exception>
    Task DisconnectAsync(CancellationToken cancellationToken = default);
}

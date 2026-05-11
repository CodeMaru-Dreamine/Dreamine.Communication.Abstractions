# Dreamine.Communication.Abstractions

`Dreamine.Communication.Abstractions`는 Dreamine Communication 계열 패키지에서 사용하는 핵심 계약, 모델, 옵션, 연결 생명주기 인터페이스를 제공하는 패키지입니다.

이 패키지는 실제 통신 프로토콜을 구현하지 않습니다.  
TCP, Serial, RabbitMQ 및 향후 추가될 통신 어댑터들이 공통으로 사용할 기반 계약만 정의합니다.

[➡️ English Version](./README.md)

## 목적

이 패키지의 목적은 애플리케이션 로직이 특정 통신 기술에 직접 의존하지 않도록 만드는 것입니다.

상위 애플리케이션 코드는 TCP, SerialPort, RabbitMQ 같은 구체 기술에 직접 의존하지 않고, `IMessageBus`, `IMessageTransport`, `MessageEnvelope` 같은 추상 계약에 의존해야 합니다.

## 포함 구성

### Interfaces

- `IConnectionLifecycle`
- `IMessageBus`
- `IMessageTransport`
- `IMessageRouter`
- `IMessageSerializer`

### Models

- `MessageEnvelope`
- `CommunicationError`

### Options

- `CommunicationOptions`
- `MessageBusOptions`
- `TransportOptions`

### Enums

- `ConnectionState`
- `TransportKind`

### Exceptions

- `CommunicationException`
- `CommunicationConnectionException`

## 설계 원칙

- 추상화 계층은 구체 구현체에 의존하지 않습니다.
- 상위 애플리케이션 레이어가 특정 통신 라이브러리에 직접 의존하지 않도록 합니다.
- TCP, Serial, RabbitMQ, MQTT, HTTP 같은 전송 어댑터를 상위 레이어 변경 없이 추가할 수 있도록 합니다.
- 의존성 역전 원칙과 인터페이스 기반 설계를 따릅니다.
- 패키지는 가볍고 특정 UI 프레임워크에 종속되지 않게 유지합니다.

## 패키지 역할

이 패키지는 Dreamine Communication 아키텍처에서 가장 하위에 위치하는 계약 패키지입니다.

```text
Dreamine.Communication.Abstractions
    ↑
Dreamine.Communication.Core
    ↑
Sockets / Serial / RabbitMQ / WPF
```

`Abstractions`는 `Core`, `Sockets`, `Serial`, `RabbitMQ`, `WPF`를 참조하면 안 됩니다.

## 대상 프레임워크

```text
net8.0
```

이 패키지는 WPF를 필요로 하지 않으며, Windows 전용 UI 프레임워크에 의존하지 않습니다.

## 예시

```csharp
using Dreamine.Communication.Abstractions.Interfaces;
using Dreamine.Communication.Abstractions.Models;

public sealed class MachineMessageService
{
    private readonly IMessageBus _messageBus;

    public MachineMessageService(IMessageBus messageBus)
    {
        _messageBus = messageBus;
    }

    public Task PublishStartAsync(CancellationToken cancellationToken = default)
    {
        var message = new MessageEnvelope
        {
            Name = "Machine.Start",
            Route = "machine.command.start",
            Payload = Array.Empty<byte>()
        };

        return _messageBus.PublishAsync(message, cancellationToken);
    }
}
```

## 관련 패키지

- `Dreamine.Communication.Core`
- `Dreamine.Communication.Sockets`
- `Dreamine.Communication.Serial`
- `Dreamine.Communication.RabbitMQ`
- `Dreamine.Communication.FullKit`

## 라이선스

이 프로젝트는 MIT 라이선스를 따릅니다.

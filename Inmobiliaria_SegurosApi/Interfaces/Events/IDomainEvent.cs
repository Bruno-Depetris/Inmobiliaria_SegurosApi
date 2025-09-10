namespace Inmobiliaria_SegurosApi.Interfaces.Events {
    public interface IDomainEvent {
        Guid Id { get; }
        DateTime OccurredOn { get; }
        string EventType { get; }
        object Data { get; }
    }
}

namespace Inmobiliaria_SegurosApi.Interfaces.Events {
    public interface IDomainEventDispatcher {
        Task DispatchAsync(IDomainEvent domainEvent);
        Task DispatchAsync(IEnumerable<IDomainEvent> domainEvents);
        void Subscribe<T>(IDomainEventHandler<T> handler) where T : IDomainEvent;
        void Unsubscribe<T>(IDomainEventHandler<T> handler) where T : IDomainEvent;
    }
}

namespace Inmobiliaria_SegurosApi.Interfaces.BackgroundServices {
    public interface INotificationBackgroundService {
        Task ProcessPendingNotificationsAsync(CancellationToken cancellationToken);
        Task ProcessScheduledNotificationsAsync(CancellationToken cancellationToken);
        Task ProcessFailedNotificationsAsync(CancellationToken cancellationToken);
    }
}

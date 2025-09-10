namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface INotificationService {
        Task<bool> SendEmailNotificationAsync(int usuarioId, string titulo, string mensaje);
        Task<bool> SendSMSNotificationAsync(int usuarioId, string mensaje);
        Task<bool> SendPushNotificationAsync(int usuarioId, string titulo, string mensaje);
        Task<bool> SendBulkNotificationAsync(List<int> usuarioIds, string titulo, string mensaje, short canalId);
        Task ProcessPendingNotificationsAsync();
        Task ProcessScheduledNotificationsAsync();
        Task<bool> ScheduleNotificationAsync(int usuarioId, string titulo, string mensaje, DateTime fechaProgramada, short canalId);
    }
}

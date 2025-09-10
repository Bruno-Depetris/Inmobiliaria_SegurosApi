namespace Inmobiliaria_SegurosApi.Interfaces.BackgroundServices {
    public interface IContractExpirationService {
        Task CheckExpiringContractsAsync(CancellationToken cancellationToken);
        Task SendExpirationNotificationsAsync(CancellationToken cancellationToken);
        Task UpdateExpiredContractsAsync(CancellationToken cancellationToken);
    }
}

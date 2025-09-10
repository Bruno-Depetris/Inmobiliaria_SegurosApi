namespace Inmobiliaria_SegurosApi.Interfaces.BackgroundServices {
    public interface IInsuranceExpirationService {
        Task CheckExpiringInsurancesAsync(CancellationToken cancellationToken);
        Task SendExpirationNotificationsAsync(CancellationToken cancellationToken);
        Task UpdateExpiredInsurancesAsync(CancellationToken cancellationToken);
    }
}

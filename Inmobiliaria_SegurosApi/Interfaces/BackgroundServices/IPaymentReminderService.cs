namespace Inmobiliaria_SegurosApi.Interfaces.BackgroundServices {
    public interface IPaymentReminderService {
        Task CheckOverduePaymentsAsync(CancellationToken cancellationToken);
        Task SendPaymentRemindersAsync(CancellationToken cancellationToken);
        Task UpdateOverduePaymentsAsync(CancellationToken cancellationToken);
        Task GenerateMonthlyPaymentsAsync(CancellationToken cancellationToken);
    }
}

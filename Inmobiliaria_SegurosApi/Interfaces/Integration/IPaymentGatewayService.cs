namespace Inmobiliaria_SegurosApi.Interfaces.Integration {
    public interface IPaymentGatewayService {
        Task<object> CreatePaymentLinkAsync(decimal amount, string description, string customerEmail);
        Task<object> ProcessPaymentAsync(string paymentToken, decimal amount);
        Task<object> GetPaymentStatusAsync(string paymentId);
        Task<bool> RefundPaymentAsync(string paymentId, decimal? amount = null);
        Task<object> GetPaymentHistoryAsync(DateTime dateFrom, DateTime dateTo);
    }
}

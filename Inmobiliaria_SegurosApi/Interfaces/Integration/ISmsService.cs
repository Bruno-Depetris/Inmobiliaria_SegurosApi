namespace Inmobiliaria_SegurosApi.Interfaces.Integration {
    public interface ISmsService {
        Task<bool> SendSmsAsync(string phoneNumber, string message);
        Task<bool> SendBulkSmsAsync(List<string> phoneNumbers, string message);
        Task<bool> IsValidPhoneNumberAsync(string phoneNumber);
        Task<decimal> GetSmsBalanceAsync();
        Task<object> GetSmsStatusAsync(string messageId);
    }
}

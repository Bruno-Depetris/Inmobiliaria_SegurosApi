namespace Inmobiliaria_SegurosApi.Interfaces.Integration {
    public interface IExternalApiService {
        Task<T?> GetAsync<T>(string endpoint) where T : class;
        Task<T?> PostAsync<T>(string endpoint, object data) where T : class;
        Task<T?> PutAsync<T>(string endpoint, object data) where T : class;
        Task<bool> DeleteAsync(string endpoint);
        Task<bool> IsServiceAvailableAsync();
        void SetAuthenticationHeader(string token);
        void SetBaseUrl(string baseUrl);
    }
}

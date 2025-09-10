namespace Inmobiliaria_SegurosApi.Interfaces.HealthChecks {
    public interface IHealthCheckService {
        Task<object> CheckDatabaseHealthAsync();
        Task<object> CheckExternalServicesHealthAsync();
        Task<object> CheckFileSystemHealthAsync();
        Task<object> CheckMemoryUsageAsync();
        Task<object> CheckCacheHealthAsync();
        Task<object> GetOverallHealthAsync();
    }
}

using Inmobiliaria_SegurosApi.DTOs.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IAuditService {
        Task LogCreateAsync<T>(T entity, int? usuarioId, string? ipAddress = null) where T : class;
        Task LogUpdateAsync<T>(T oldEntity, T newEntity, int? usuarioId, string? ipAddress = null) where T : class;
        Task LogDeleteAsync<T>(T entity, int? usuarioId, string? ipAddress = null) where T : class;
        Task LogCustomActionAsync(string action, string? tableName, int? recordId, object? data, int? usuarioId, string? ipAddress = null);
        Task<ResponseDTOs<object>> GetAuditTrailAsync(string? tableName = null, int? recordId = null, DateTime? fechaDesde = null, DateTime? fechaHasta = null);
    }
}

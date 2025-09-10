using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface ILog_ActividadeRepository : IGenericRepository<Log_Actividade> {
        Task<IEnumerable<Log_Actividade>> GetByUsuarioIdAsync(int usuarioId);
        Task<IEnumerable<Log_Actividade>> GetByAccionAsync(string accion);
        Task<IEnumerable<Log_Actividade>> GetByTablaAsync(string tabla);
        Task<IEnumerable<Log_Actividade>> GetByFechaRangeAsync(DateTime fechaDesde, DateTime fechaHasta);
        Task<IEnumerable<Log_Actividade>> GetRecentActivityAsync(int limit = 100);
        Task<IEnumerable<Log_Actividade>> GetByIPAddressAsync(string ipAddress);
        Task LogActivityAsync(int? usuarioId, string accion, string? tabla = null, int? registroId = null,
            string? valoresAnteriores = null, string? valoresNuevos = null, string? ipAddress = null, string? userAgent = null);
    }
}

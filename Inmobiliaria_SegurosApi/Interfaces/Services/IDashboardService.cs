using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Dashboard;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IDashboardService {
        Task<ResponseDTOs<DashboardResumenDTOs>> GetDashboardResumenAsync();
        Task<ResponseDTOs<IEnumerable<ResumenMensualDTOs>>> GetIngresosMensualesAsync(int meses = 12);
        Task<ResponseDTOs<object>> GetEstadisticasPropiedadesAsync();
        Task<ResponseDTOs<object>> GetEstadisticasContratosAsync();
        Task<ResponseDTOs<object>> GetEstadisticasPagosAsync();
        Task<ResponseDTOs<object>> GetTopPropietariosAsync(int limit = 10);
        Task<ResponseDTOs<object>> GetTopProductoresAsync(int limit = 10);
    }
}

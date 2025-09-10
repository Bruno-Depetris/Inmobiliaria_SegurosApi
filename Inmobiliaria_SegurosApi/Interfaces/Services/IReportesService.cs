using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Dashboard;
using Inmobiliaria_SegurosApi.DTOs.Reportes;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IReportesService {
        Task<ResponseDTOs<ReportePagosDTOs>> GenerarReportePagosAsync(DateOnly fechaDesde, DateOnly fechaHasta, short? estadoPagoId = null);
        Task<ResponseDTOs<ReporteContratosVencimientosDTOs>> GenerarReporteContratosVencimientosAsync(DateOnly fechaDesde, DateOnly fechaHasta);
        Task<ResponseDTOs<byte[]>> GenerarReportePagosExcelAsync(DateOnly fechaDesde, DateOnly fechaHasta, short? estadoPagoId = null);
        Task<ResponseDTOs<byte[]>> GenerarReporteContratosExcelAsync(DateOnly fechaDesde, DateOnly fechaHasta);
        Task<ResponseDTOs<byte[]>> GenerarReportePropiedadesExcelAsync();
        Task<ResponseDTOs<object>> GenerarReporteComisionesAsync(int? productorId = null, DateOnly? fechaDesde = null, DateOnly? fechaHasta = null);
        Task<ResponseDTOs<object>> GenerarReporteSegurosAsync(DateOnly? fechaDesde = null, DateOnly? fechaHasta = null);
    }
}

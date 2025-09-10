using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IPagoRepository : IGenericRepository<Pago> {
        Task<Pago?> GetByNumeroReciboAsync(string numeroRecibo);
        Task<IEnumerable<Pago>> GetByContratoIdAsync(int contratoId);
        Task<IEnumerable<Pago>> GetByEstadoPagoAsync(short estadoPagoId);
        Task<IEnumerable<Pago>> GetPendientesAsync();
        Task<IEnumerable<Pago>> GetVencidosAsync();
        Task<IEnumerable<Pago>> GetByFechaVencimientoRangeAsync(DateOnly fechaDesde, DateOnly fechaHasta);
        Task<IEnumerable<Pago>> GetCompleteInfoAsync();
        Task<decimal> GetTotalPagadoByContratoAsync(int contratoId);
        Task<decimal> GetTotalPendienteAsync();
        Task<decimal> GetTotalVencidoAsync();
        Task<bool> ExistsByNumeroReciboAsync(string numeroRecibo, int? excludeId = null);
    }
}

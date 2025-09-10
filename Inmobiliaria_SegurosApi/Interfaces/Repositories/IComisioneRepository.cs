using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IComisioneRepository : IGenericRepository<Comisione> {
        Task<IEnumerable<Comisione>> GetByProductorIdAsync(int productorId);
        Task<IEnumerable<Comisione>> GetByContratoIdAsync(int contratoId);
        Task<IEnumerable<Comisione>> GetBySeguroIdAsync(int seguroId);
        Task<IEnumerable<Comisione>> GetByEstadoAsync(string estado);
        Task<IEnumerable<Comisione>> GetByFechaRangeAsync(DateOnly fechaDesde, DateOnly fechaHasta);
        Task<IEnumerable<Comisione>> GetPendientesPagoAsync();
        Task<decimal> GetTotalComisionesByProductorAsync(int productorId, DateOnly? fechaDesde = null, DateOnly? fechaHasta = null);
        Task<IEnumerable<Comisione>> GetCompleteInfoAsync();
    }
}

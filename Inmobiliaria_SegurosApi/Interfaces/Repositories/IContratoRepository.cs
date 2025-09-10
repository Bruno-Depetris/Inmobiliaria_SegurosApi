using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IContratoRepository : IGenericRepository<Contrato> {
        Task<Contrato?> GetByNumeroContratoAsync(string numeroContrato);
        Task<IEnumerable<Contrato>> GetByPropiedadIdAsync(int propiedadId);
        Task<IEnumerable<Contrato>> GetByInquilinoIdAsync(int inquilinoId);
        Task<IEnumerable<Contrato>> GetByPropietarioIdAsync(int propietarioId);
        Task<IEnumerable<Contrato>> GetByEstadoAsync(short estadoId);
        Task<IEnumerable<Contrato>> GetActivosAsync();
        Task<IEnumerable<Contrato>> GetPorVencerAsync(int diasAnticipacion = 30);
        Task<IEnumerable<Contrato>> GetVencidosAsync();
        Task<IEnumerable<Contrato>> GetCompleteInfoAsync();
        Task<bool> ExistsByNumeroContratoAsync(string numeroContrato, int? excludeId = null);
        Task<IEnumerable<Contrato>> GetByFechaRangeAsync(DateOnly fechaDesde, DateOnly fechaHasta);
        Task<decimal> GetTotalMontoAlquileresAsync(short? estadoId = null);
    }
}

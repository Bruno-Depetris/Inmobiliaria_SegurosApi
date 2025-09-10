using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface ISeguroRepository {
        public interface ISeguroRepository : IGenericRepository<Seguro> {
            Task<Seguro?> GetByNumeroPolizaAsync(string numeroPoliza);
            Task<IEnumerable<Seguro>> GetByPropiedadIdAsync(int propiedadId);
            Task<IEnumerable<Seguro>> GetByCompaniaAsync(string compania);
            Task<IEnumerable<Seguro>> GetByTipoSeguroAsync(short tipoSeguroId);
            Task<IEnumerable<Seguro>> GetByEstadoAsync(short estadoSeguroId);
            Task<IEnumerable<Seguro>> GetActivosAsync();
            Task<IEnumerable<Seguro>> GetPorVencerAsync(int diasAnticipacion = 30);
            Task<IEnumerable<Seguro>> GetVencidosAsync();
            Task<IEnumerable<Seguro>> GetCompleteInfoAsync();
            Task<bool> ExistsByNumeroPolizaAsync(string numeroPoliza, int? excludeId = null);
            Task<decimal> GetTotalPrimasAsync(short? estadoId = null);
        }
    }
}

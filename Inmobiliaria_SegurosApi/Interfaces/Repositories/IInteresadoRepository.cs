using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IInteresadoRepository : IGenericRepository<Interesado> {
        Task<IEnumerable<Interesado>> GetByPropiedadIdAsync(int propiedadId);
        Task<IEnumerable<Interesado>> GetByPersonaIdAsync(int personaId);
        Task<IEnumerable<Interesado>> GetByTipoInteresAsync(short tipoInteresId);
        Task<IEnumerable<Interesado>> GetByEstadoAsync(short estado);
        Task<IEnumerable<Interesado>> GetActivosAsync();
        Task<IEnumerable<Interesado>> GetCompleteInfoAsync();
        Task<bool> ExistsByPersonaYPropiedadAsync(int personaId, int propiedadId);
        Task<IEnumerable<Interesado>> GetByPresupuestoRangeAsync(decimal montoMin, decimal montoMax);
    }
}

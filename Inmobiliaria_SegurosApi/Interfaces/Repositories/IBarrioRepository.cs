using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IBarrioRepository {
        public interface IBarrioRepository : IGenericRepository<Barrio> {
            Task<IEnumerable<Barrio>> GetByEstadoAsync(string estado);
            Task<IEnumerable<Barrio>> GetByCiudadIdAsync(int ciudadId);
            Task<Barrio?> GetByNombreAsync(string nombre);
            Task<bool> ExistsByNombreAsync(string nombre, int? excludeId = null);
            Task<IEnumerable<Barrio>> SearchByNombreAsync(string searchTerm);
            Task<int> CountByCiudadAsync(int ciudadId);
        }
    }
}

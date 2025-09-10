using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface ICiudadeRepository : IGenericRepository<Ciudade> {
        Task<IEnumerable<Ciudade>> GetByEstadoAsync(short estado);
        Task<IEnumerable<Ciudade>> GetByProvinciaAsync(string provincia);
        Task<Ciudade?> GetByCodigoPostalAsync(string codigoPostal);
        Task<IEnumerable<Ciudade>> SearchAsync(string searchTerm);
        Task<bool> ExistsByNombreAsync(string nombre, int? excludeId = null);
        Task<IEnumerable<Ciudade>> GetWithBarriosAsync();
        Task<int> CountBarriosByCiudadAsync(int ciudadId);
    }
}

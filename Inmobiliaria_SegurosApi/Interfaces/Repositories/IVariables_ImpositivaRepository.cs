using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IVariables_ImpositivaRepository : IGenericRepository<Variables_Impositiva> {
        Task<IEnumerable<Variables_Impositiva>> GetByEstadoAsync(short estado);
        Task<IEnumerable<Variables_Impositiva>> GetVigentesAsync(DateOnly? fecha = null);
        Task<IEnumerable<Variables_Impositiva>> GetByTipoAplicacionAsync(string tipoAplicacion);
        Task<Variables_Impositiva?> GetByNombreAsync(string nombre);
        Task<bool> ExistsByNombreAsync(string nombre, int? excludeId = null);
        Task<IEnumerable<Variables_Impositiva>> GetActivasAsync();
    }
}

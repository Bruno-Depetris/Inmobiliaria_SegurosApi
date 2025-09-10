using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IEstados_CivilRepository : IGenericRepository<Estados_Civil> {
        Task<Estados_Civil?> GetByNombreAsync(string nombre);
        Task<bool> ExistsByNombreAsync(string nombre, sbyte? excludeId = null);
        Task<int> CountPersonasByEstadoCivil(sbyte estadoCivilId);
    }
}

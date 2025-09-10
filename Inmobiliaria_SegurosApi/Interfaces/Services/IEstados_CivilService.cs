using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Estados_Civil;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IEstados_CivilService : IGenericService<Entities.Estados_Civil, CrearEstadosCivilDTOs, ActualizarEstadoCivilDTOs, MostrarEstadosCivilDTOs> {
        Task<ResponseDTOs<MostrarEstadosCivilDTOs>> GetByNombreAsync(string nombre);
        Task<ResponseDTOs<bool>> ValidateUniqueNombreAsync(string nombre, sbyte? excludeId = null);
    }
}

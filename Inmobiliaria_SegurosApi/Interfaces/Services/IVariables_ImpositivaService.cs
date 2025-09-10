using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Variables_Impositiva;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IVariables_ImpositivaService : IGenericService<Entities.Variables_Impositiva, CrearVariables_ImpositivaDTOs, EditarVariables_ImpositivaDTOs, MostrarVariables_ImpositivaDTOs> {
        Task<ResponseDTOs<IEnumerable<MostrarVariables_ImpositivaDTOs>>> GetVigentesAsync(DateOnly? fecha = null);
        Task<ResponseDTOs<IEnumerable<MostrarVariables_ImpositivaDTOs>>> GetByTipoAplicacionAsync(string tipoAplicacion);
        Task<ResponseDTOs<MostrarVariables_ImpositivaDTOs>> GetByNombreAsync(string nombre);
        Task<ResponseDTOs<bool>> ValidateUniqueNombreAsync(string nombre, int? excludeId = null);
        Task<ResponseDTOs<decimal>> CalcularImporteAsync(string nombreVariable, decimal baseCalculo);
    }
}

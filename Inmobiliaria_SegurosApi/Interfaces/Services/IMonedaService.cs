using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Moneda;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IMonedaService : IGenericService<Entities.Moneda, CrearMonedaDTOs, EditarMonedaDTOs, MostrarMonedaDTOs> {
        Task<ResponseDTOs<MostrarMonedaDTOs>> GetByCodigoAsync(string codigo);
        Task<ResponseDTOs<IEnumerable<MostrarMonedaDTOs>>> GetActivasAsync();
        Task<ResponseDTOs<MostrarMonedaDTOs>> GetDefaultAsync();
        Task<ResponseDTOs<bool>> ValidateUniqueCodigoAsync(string codigo, short? excludeId = null);
    }
}

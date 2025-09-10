using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Productores;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IProductoreService : IGenericService<Entities.Productore, CrearProductoreDTOs, EditarProductoreDTOs, MostrarProductoreDTOs> {
        Task<ResponseDTOs<MostrarProductoreDTOs>> GetByCodigoProductorAsync(string codigoProductor);
        Task<ResponseDTOs<MostrarProductoreDTOs>> GetByEmailAsync(string email);
        Task<ResponseDTOs<IEnumerable<MostrarProductoreDTOs>>> GetActivosAsync();
        Task<ResponseDTOs<IEnumerable<MostrarProductoreDTOs>>> SearchAsync(string searchTerm);
        Task<ResponseDTOs<bool>> ValidateUniqueCodigoProductorAsync(string codigoProductor, int? excludeId = null);
        Task<ResponseDTOs<bool>> ValidateUniqueEmailAsync(string email, int? excludeId = null);
        Task<ResponseDTOs<decimal>> GetTotalComisionesAsync(int productorId, DateOnly? fechaDesde = null, DateOnly? fechaHasta = null);
    }
}

using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Persona;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IPersonaService : IGenericService<Entities.Persona, CrearPersonaDTOs, EditarPersonaDTOs, MostrarPersonaDTOs> {
        Task<ResponseDTOs<MostrarPersonaDTOs>> GetByDocumentoAsync(string documento);
        Task<ResponseDTOs<MostrarPersonaDTOs>> GetByEmailAsync(string email);
        Task<ResponseDTOs<IEnumerable<MostrarPersonaDTOs>>> GetActivasAsync();
        Task<ResponseDTOs<IEnumerable<MostrarPersonaDTOs>>> SearchAsync(string searchTerm);
        Task<ResponseDTOs<bool>> ValidateUniqueDocumentoAsync(string documento, int? excludeId = null);
        Task<ResponseDTOs<bool>> ValidateUniqueEmailAsync(string email, int? excludeId = null);
    }
}

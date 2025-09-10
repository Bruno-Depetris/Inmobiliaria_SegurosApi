using Inmobiliaria_SegurosApi.DTOs.Cliente;
using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IClienteService : IGenericService<Entities.Cliente, CrearClienteDTOs, EditarClienteDTOs, MostrarClienteDTOs> {
        Task<ResponseDTOs<MostrarClienteDTOs>> GetByCodigoClienteAsync(string codigoCliente);
        Task<ResponseDTOs<MostrarClienteDTOs>> GetByPersonaIdAsync(int personaId);
        Task<ResponseDTOs<IEnumerable<MostrarClienteDTOs>>> GetPropietariosAsync();
        Task<ResponseDTOs<IEnumerable<MostrarClienteDTOs>>> GetInquilinosAsync();
        Task<ResponseDTOs<IEnumerable<MostrarClienteDTOs>>> SearchAsync(string searchTerm);
        Task<ResponseDTOs<bool>> ValidateUniqueCodigoClienteAsync(string codigoCliente, int? excludeId = null);
    }
}

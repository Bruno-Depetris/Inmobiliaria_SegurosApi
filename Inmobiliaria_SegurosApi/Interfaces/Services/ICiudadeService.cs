using Inmobiliaria_SegurosApi.DTOs.Ciudade;
using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface ICiudadeService : IGenericService<Entities.Ciudade, CrearCiudadeDTOs, EditarCiudadeDTOs, MostrarCiudadeDTOs> {
        Task<ResponseDTOs<IEnumerable<MostrarCiudadeDTOs>>> GetByProvinciaAsync(string provincia);
        Task<ResponseDTOs<MostrarCiudadeDTOs>> GetByCodigoPostalAsync(string codigoPostal);
        Task<ResponseDTOs<IEnumerable<MostrarCiudadeDTOs>>> SearchAsync(string searchTerm);
        Task<ResponseDTOs<IEnumerable<MostrarCiudadeDTOs>>> GetWithBarriosAsync();
        Task<ResponseDTOs<bool>> ValidateUniqueNombreAsync(string nombre, int? excludeId = null);
    }
}

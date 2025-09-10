using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.FotosPropiedades;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IFotos_PropiedadeService : IGenericService<Entities.Fotos_Propiedade, CrearFotos_PropiedadeDTOs, EditarFotos_PropiedadeDTOs, MostrarFotos_PropiedadeDTOs> {
        Task<ResponseDTOs<IEnumerable<MostrarFotos_PropiedadeDTOs>>> GetByPropiedadIdAsync(int propiedadId);
        Task<ResponseDTOs<MostrarFotos_PropiedadeDTOs>> GetPrincipalByPropiedadAsync(int propiedadId);
        Task<ResponseDTOs<bool>> SetPrincipalAsync(int fotoId, int propiedadId);
        Task<ResponseDTOs<bool>> UpdateOrderAsync(int fotoId, int nuevoOrden);
        Task<ResponseDTOs<bool>> DeleteAllByPropiedadAsync(int propiedadId);
    }
}

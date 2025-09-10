using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Interesado;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IInteresadoService : IGenericService<Entities.Interesado, CrearInteresadoDTOs, EditarInteresadoDTOs, MostrarInteresadoDTOs> {
        Task<ResponseDTOs<IEnumerable<MostrarInteresadoDTOs>>> GetByPropiedadIdAsync(int propiedadId);
        Task<ResponseDTOs<IEnumerable<MostrarInteresadoDTOs>>> GetByPersonaIdAsync(int personaId);
        Task<ResponseDTOs<IEnumerable<MostrarInteresadoDTOs>>> GetByTipoInteresAsync(short tipoInteresId);
        Task<ResponseDTOs<IEnumerable<MostrarInteresadoDTOs>>> GetActivosAsync();
        Task<ResponseDTOs<bool>> ValidateUniquePersonaPropiedadAsync(int personaId, int propiedadId);
    }
}

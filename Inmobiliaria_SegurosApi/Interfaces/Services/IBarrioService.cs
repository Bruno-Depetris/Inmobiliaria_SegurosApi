using Inmobiliaria_SegurosApi.DTOs.Barrio;
using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IBarrioService : IGenericService<Entities.Barrio, CreateBarrioDTOs, ActualizarBarrioDTOs, MostrarBarrioDTOs> {
        Task<ResponseDTOs<IEnumerable<MostrarBarrioDTOs>>> GetByCiudadIdAsync(int ciudadId);
        Task<ResponseDTOs<IEnumerable<MostrarBarrioDTOs>>> GetByEstadoAsync(string estado);
        Task<ResponseDTOs<IEnumerable<MostrarBarrioDTOs>>> SearchByNombreAsync(string searchTerm);
        Task<ResponseDTOs<bool>> ValidateUniqueNombreAsync(string nombre, int? excludeId = null);
    }
}

using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Propiedades;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IPropiedadeService : IGenericService<Entities.Propiedade, CrearPropiedadeDTOs, EditarPropiedadeDTOs, MostrarPropiedadeDTOs> {
        Task<ResponseDTOs<MostrarPropiedadeDTOs>> GetByCodigoPropiedadAsync(string codigoPropiedad);
        Task<ResponseDTOs<IEnumerable<MostrarPropiedadeDTOs>>> GetByPropietarioIdAsync(int propietarioId);
        Task<ResponseDTOs<IEnumerable<MostrarPropiedadeDTOs>>> GetDisponiblesAsync();
        Task<ResponseDTOs<IEnumerable<MostrarPropiedadeDTOs>>> SearchAsync(string searchTerm);
        Task<ResponseDTOs<IEnumerable<MostrarPropiedadeDTOs>>> GetByPrecioRangeAsync(decimal precioMin, decimal precioMax, bool esAlquiler = true);
        Task<ResponseDTOs<IEnumerable<MostrarPropiedadeDTOs>>> GetByCaracteristicasAsync(int? minHabitaciones = null, int? minBanos = null, int? minCocheras = null);
        Task<ResponseDTOs<bool>> ValidateUniqueCodigoPropiedadAsync(string codigoPropiedad, int? excludeId = null);
        Task<ResponseDTOs<MostrarPropiedadeDTOs>> GetWithPhotosAsync(int propiedadId);
    }
}

using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IPropiedadeRepository : IGenericRepository<Propiedade> {
        Task<Propiedade?> GetByCodigoPropiedadAsync(string codigoPropiedad);
        Task<IEnumerable<Propiedade>> GetByPropietarioIdAsync(int propietarioId);
        Task<IEnumerable<Propiedade>> GetByBarrioIdAsync(int barrioId);
        Task<IEnumerable<Propiedade>> GetByTipoPropiedadAsync(short tipoPropiedadId);
        Task<IEnumerable<Propiedade>> GetByEstadoPropiedadAsync(short estadoPropiedadId);
        Task<IEnumerable<Propiedade>> GetDisponiblesAsync();
        Task<IEnumerable<Propiedade>> GetCompleteInfoAsync();
        Task<Propiedade?> GetWithPhotosAsync(int propiedadId);
        Task<IEnumerable<Propiedade>> SearchAsync(string searchTerm);
        Task<IEnumerable<Propiedade>> GetByPrecioRangeAsync(decimal precioMin, decimal precioMax, bool esAlquiler = true);
        Task<IEnumerable<Propiedade>> GetByCaracteristicasAsync(int? minHabitaciones = null, int? minBanos = null, int? minCocheras = null);
        Task<bool> ExistsByCodigoPropiedadAsync(string codigoPropiedad, int? excludeId = null);
    }
}

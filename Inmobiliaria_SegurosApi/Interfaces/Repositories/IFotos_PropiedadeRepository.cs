using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IFotos_PropiedadeRepository : IGenericRepository<Fotos_Propiedade> {
        Task<IEnumerable<Fotos_Propiedade>> GetByPropiedadIdAsync(int propiedadId);
        Task<Fotos_Propiedade?> GetPrincipalByPropiedadAsync(int propiedadId);
        Task<IEnumerable<Fotos_Propiedade>> GetOrderedByDisplayAsync(int propiedadId);
        Task<bool> SetPrincipalAsync(int fotoId, int propiedadId);
        Task<bool> UpdateOrderAsync(int fotoId, int nuevoOrden);
        Task<int> GetMaxOrderAsync(int propiedadId);
        Task DeleteByPropiedadIdAsync(int propiedadId);
    }
}

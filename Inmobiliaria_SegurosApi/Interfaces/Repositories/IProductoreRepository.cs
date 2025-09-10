using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IProductoreRepository : IGenericRepository<Productore> {
        Task<Productore?> GetByCodigoProductorAsync(string codigoProductor);
        Task<Productore?> GetByEmailAsync(string email);
        Task<IEnumerable<Productore>> GetByEstadoAsync(short estado);
        Task<IEnumerable<Productore>> GetActivosAsync();
        Task<IEnumerable<Productore>> SearchAsync(string searchTerm);
        Task<bool> ExistsByCodigoProductorAsync(string codigoProductor, int? excludeId = null);
        Task<bool> ExistsByEmailAsync(string email, int? excludeId = null);
        Task<decimal> GetTotalComisionesAsync(int productorId, DateOnly? fechaDesde = null, DateOnly? fechaHasta = null);
        Task<int> CountContratosAsync(int productorId);
        Task<int> CountSegurosAsync(int productorId);
    }
}

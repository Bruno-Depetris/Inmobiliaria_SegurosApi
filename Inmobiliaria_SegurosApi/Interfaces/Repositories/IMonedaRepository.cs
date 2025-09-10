using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IMonedaRepository : IGenericRepository<Moneda> {
        Task<Moneda?> GetByCodigoAsync(string codigo);
        Task<bool> ExistsByCodigoAsync(string codigo, short? excludeId = null);
        Task<IEnumerable<Moneda>> GetActivasAsync();
        Task<Moneda?> GetDefaultAsync();
    }
}

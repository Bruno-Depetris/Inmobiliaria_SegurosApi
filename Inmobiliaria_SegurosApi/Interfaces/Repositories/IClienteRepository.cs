using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IClienteRepository : IGenericRepository<Cliente> {
        Task<Cliente?> GetByCodigoClienteAsync(string codigoCliente);
        Task<Cliente?> GetByPersonaIdAsync(int personaId);
        Task<IEnumerable<Cliente>> GetByCalificacionCrediticiaAsync(string calificacion);
        Task<IEnumerable<Cliente>> GetWithPersonaAsync();
        Task<Cliente?> GetCompleteInfoAsync(int clienteId);
        Task<bool> ExistsByCodigoClienteAsync(string codigoCliente, int? excludeId = null);
        Task<IEnumerable<Cliente>> GetPropietariosAsync();
        Task<IEnumerable<Cliente>> GetInquilinosAsync();
        Task<IEnumerable<Cliente>> SearchAsync(string searchTerm);
        Task<int> CountContratosByClienteAsync(int clienteId);
    }
}

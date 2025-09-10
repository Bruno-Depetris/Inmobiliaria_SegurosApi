using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IPersonaRepository : IGenericRepository<Persona> {
        Task<Persona?> GetByDocumentoAsync(string documento);
        Task<Persona?> GetByEmailAsync(string email);
        Task<IEnumerable<Persona>> GetByTipoDocumentoAsync(sbyte tipoDocumentoId);
        Task<IEnumerable<Persona>> GetByCiudadIdAsync(int ciudadId);
        Task<IEnumerable<Persona>> GetByEstadoCivilAsync(sbyte estadoCivilId);
        Task<IEnumerable<Persona>> GetByEstadoAsync(short estado);
        Task<IEnumerable<Persona>> SearchAsync(string searchTerm);
        Task<Persona?> GetCompleteInfoAsync(int personaId);
        Task<bool> ExistsByDocumentoAsync(string documento, int? excludeId = null);
        Task<bool> ExistsByEmailAsync(string email, int? excludeId = null);
        Task<IEnumerable<Persona>> GetActivasAsync();
    }
}

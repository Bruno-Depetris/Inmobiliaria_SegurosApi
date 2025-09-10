using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface IUsuarioRepository : IGenericRepository<Usuario> {
        Task<Usuario?> GetByUsernameAsync(string username);
        Task<Usuario?> GetByEmailAsync(string email);
        Task<IEnumerable<Usuario>> GetByRolAsync(sbyte rolUsuarioId);
        Task<IEnumerable<Usuario>> GetByEstadoAsync(sbyte estadoUsuarioId);
        Task<IEnumerable<Usuario>> GetActivosAsync();
        Task<Usuario?> GetCompleteInfoAsync(int usuarioId);
        Task<bool> ExistsByUsernameAsync(string username, int? excludeId = null);
        Task<bool> ExistsByEmailAsync(string email, int? excludeId = null);
        Task<bool> ValidatePasswordAsync(int usuarioId, string password);
        Task UpdatePasswordAsync(int usuarioId, string newPasswordHash);
        Task UpdateLastLoginAsync(int usuarioId);
        Task<bool> IsLockedAsync(int usuarioId);
        Task IncrementLoginAttemptsAsync(int usuarioId);
        Task ResetLoginAttemptsAsync(int usuarioId);
        Task LockUserAsync(int usuarioId, DateTime lockUntil);
        Task<IEnumerable<Usuario>> SearchAsync(string searchTerm);
    }
}

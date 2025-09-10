using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Usuario;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IUsuarioService : IGenericService<Entities.Usuario, CrearUsuarioDTOs, EditarUsuarioDTOs, MostrarUsuarioDTOs> {
        Task<ResponseDTOs<MostrarUsuarioDTOs>> GetByUsernameAsync(string username);
        Task<ResponseDTOs<MostrarUsuarioDTOs>> GetByEmailAsync(string email);
        Task<ResponseDTOs<IEnumerable<MostrarUsuarioDTOs>>> GetActivosAsync();
        Task<ResponseDTOs<IEnumerable<MostrarUsuarioDTOs>>> SearchAsync(string searchTerm);
        Task<ResponseDTOs<bool>> ValidateUniqueUsernameAsync(string username, int? excludeId = null);
        Task<ResponseDTOs<bool>> ValidateUniqueEmailAsync(string email, int? excludeId = null);
        Task<ResponseDTOs<bool>> ValidatePasswordAsync(int usuarioId, string password);
        Task<ResponseDTOs<bool>> ChangePasswordAsync(CambiarPasswordDTOs cambiarPassword);
        Task<ResponseDTOs<bool>> ResetPasswordAsync(int usuarioId, string newPassword);
        Task<ResponseDTOs<bool>> LockUserAsync(int usuarioId, DateTime lockUntil);
        Task<ResponseDTOs<bool>> UnlockUserAsync(int usuarioId);
    }
}

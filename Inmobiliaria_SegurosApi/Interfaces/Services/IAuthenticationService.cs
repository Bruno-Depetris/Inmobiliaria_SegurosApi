using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Usuario;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IAuthenticationService {
        Task<ResponseDTOs<string>> LoginAsync(LoginDTOs loginDto);
        Task<ResponseDTOs<bool>> LogoutAsync(int usuarioId);
        Task<ResponseDTOs<string>> RefreshTokenAsync(string refreshToken);
        Task<ResponseDTOs<bool>> ValidateTokenAsync(string token);
        Task<ResponseDTOs<MostrarUsuarioDTOs>> GetCurrentUserAsync(int usuarioId);
        Task<ResponseDTOs<bool>> ForgotPasswordAsync(string email);
        Task<ResponseDTOs<bool>> ResetPasswordAsync(string resetToken, string newPassword);
        Task<ResponseDTOs<bool>> ChangePasswordAsync(int usuarioId, string currentPassword, string newPassword);
    }
}

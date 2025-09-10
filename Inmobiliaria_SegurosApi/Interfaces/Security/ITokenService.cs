namespace Inmobiliaria_SegurosApi.Interfaces.Security {
    public interface ITokenService {
        Task<string> GenerateAccessTokenAsync(Entities.Usuario usuario);
        Task<string> GenerateRefreshTokenAsync(int usuarioId);
        Task<bool> ValidateTokenAsync(string token);
        Task<int?> GetUserIdFromTokenAsync(string token);
        Task<bool> RevokeTokenAsync(string token);
        Task<bool> RevokeAllUserTokensAsync(int usuarioId);
        Task<string> GenerateResetTokenAsync(int usuarioId);
        Task<bool> ValidateResetTokenAsync(string token, int usuarioId);
    }
}

namespace Inmobiliaria_SegurosApi.Interfaces.Security {
    public interface IPermissionService {
        Task<bool> HasPermissionAsync(int usuarioId, string permission);
        Task<bool> HasRoleAsync(int usuarioId, string role);
        Task<bool> CanAccessResourceAsync(int usuarioId, string resource, string action);
        Task<List<string>> GetUserPermissionsAsync(int usuarioId);
        Task<List<string>> GetUserRolesAsync(int usuarioId);
        Task<bool> IsOwnerAsync(int usuarioId, string entityType, int entityId);
        Task<bool> CanModifyEntityAsync(int usuarioId, string entityType, int entityId);
    }
}

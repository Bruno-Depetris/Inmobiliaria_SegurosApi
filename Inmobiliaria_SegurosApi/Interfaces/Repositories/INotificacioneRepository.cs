using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface INotificacioneRepository : IGenericRepository<Notificacione> {
        Task<IEnumerable<Notificacione>> GetByUsuarioIdAsync(int usuarioId);
        Task<IEnumerable<Notificacione>> GetByCanalIdAsync(short canalId);
        Task<IEnumerable<Notificacione>> GetByEstadoEnvioAsync(short estadoEnvioId);
        Task<IEnumerable<Notificacione>> GetPendientesEnvioAsync();
        Task<IEnumerable<Notificacione>> GetProgramadasAsync(DateTime fechaLimite);
        Task<IEnumerable<Notificacione>> GetCompleteInfoAsync();
        Task<bool> MarcarComoEnviadaAsync(int notificacionId);
        Task<bool> MarcarComoFallidaAsync(int notificacionId, string mensajeError);
        Task<IEnumerable<Notificacione>> GetReintentosAsync(int maxIntentos = 3);
    }
}

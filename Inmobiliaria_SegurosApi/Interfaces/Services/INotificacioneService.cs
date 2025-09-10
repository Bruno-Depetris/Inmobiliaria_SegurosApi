using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Notificaciones;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface INotificacioneService : IGenericService<Entities.Notificacione, CrearNotificacioneDTOs, EditarNotificacioneDTOs, MostrarNotificacioneDTOs> {
        Task<ResponseDTOs<IEnumerable<MostrarNotificacioneDTOs>>> GetByUsuarioIdAsync(int usuarioId);
        Task<ResponseDTOs<IEnumerable<MostrarNotificacioneDTOs>>> GetPendientesEnvioAsync();
        Task<ResponseDTOs<IEnumerable<MostrarNotificacioneDTOs>>> GetProgramadasAsync(DateTime fechaLimite);
        Task<ResponseDTOs<bool>> EnviarNotificacionAsync(int notificacionId);
        Task<ResponseDTOs<bool>> MarcarComoEnviadaAsync(int notificacionId);
        Task<ResponseDTOs<bool>> MarcarComoFallidaAsync(int notificacionId, string mensajeError);
        Task<ResponseDTOs<bool>> ProgramarNotificacionAsync(CrearNotificacioneDTOs notificacion, DateTime fechaProgramada);
    }
}

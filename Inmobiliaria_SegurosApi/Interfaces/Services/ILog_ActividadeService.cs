using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Log_Actividade;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface ILog_ActividadeService : IGenericService<Entities.Log_Actividade, CrearLog_ActividadeDTOs, CrearLog_ActividadeDTOs, MostrarLog_ActividadeDTOs> {
        Task<ResponseDTOs<IEnumerable<MostrarLog_ActividadeDTOs>>> GetByUsuarioIdAsync(int usuarioId);
        Task<ResponseDTOs<IEnumerable<MostrarLog_ActividadeDTOs>>> GetByAccionAsync(string accion);
        Task<ResponseDTOs<IEnumerable<MostrarLog_ActividadeDTOs>>> GetRecentActivityAsync(int limit = 100);
        Task<ResponseDTOs<bool>> LogActivityAsync(int? usuarioId, string accion, string? tabla = null, int? registroId = null,
            string? valoresAnteriores = null, string? valoresNuevos = null, string? ipAddress = null, string? userAgent = null);
    }
}

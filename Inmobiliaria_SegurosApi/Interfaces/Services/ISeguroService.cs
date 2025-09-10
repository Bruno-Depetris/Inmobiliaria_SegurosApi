using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Seguro;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface ISeguroService : IGenericService<Entities.Seguro, CrearSeguroDTOs, EditarSeguroDTOs, MostrarSeguroDTOs> {
        Task<ResponseDTOs<MostrarSeguroDTOs>> GetByNumeroPolizaAsync(string numeroPoliza);
        Task<ResponseDTOs<IEnumerable<MostrarSeguroDTOs>>> GetByPropiedadIdAsync(int propiedadId);
        Task<ResponseDTOs<IEnumerable<MostrarSeguroDTOs>>> GetActivosAsync();
        Task<ResponseDTOs<IEnumerable<MostrarSeguroDTOs>>> GetPorVencerAsync(int diasAnticipacion = 30);
        Task<ResponseDTOs<IEnumerable<MostrarSeguroDTOs>>> GetVencidosAsync();
        Task<ResponseDTOs<bool>> ValidateUniqueNumeroPolizaAsync(string numeroPoliza, int? excludeId = null);
        Task<ResponseDTOs<bool>> RenovarSeguroAsync(int seguroId, DateOnly nuevaFechaVencimiento);
    }
}

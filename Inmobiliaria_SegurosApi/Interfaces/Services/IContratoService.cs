using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Contrato;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IContratoService : IGenericService<Entities.Contrato, CrearContratoDTOs, ActualizarContratoDTOs, MostrarContratoDTOs> {
        Task<ResponseDTOs<MostrarContratoDTOs>> GetByNumeroContratoAsync(string numeroContrato);
        Task<ResponseDTOs<IEnumerable<MostrarContratoDTOs>>> GetByPropiedadIdAsync(int propiedadId);
        Task<ResponseDTOs<IEnumerable<MostrarContratoDTOs>>> GetByInquilinoIdAsync(int inquilinoId);
        Task<ResponseDTOs<IEnumerable<MostrarContratoDTOs>>> GetByPropietarioIdAsync(int propietarioId);
        Task<ResponseDTOs<IEnumerable<MostrarContratoDTOs>>> GetActivosAsync();
        Task<ResponseDTOs<IEnumerable<MostrarContratoDTOs>>> GetPorVencerAsync(int diasAnticipacion = 30);
        Task<ResponseDTOs<IEnumerable<MostrarContratoDTOs>>> GetVencidosAsync();
        Task<ResponseDTOs<bool>> ValidateUniqueNumeroContratoAsync(string numeroContrato, int? excludeId = null);
        Task<ResponseDTOs<bool>> RenovarContratoAsync(int contratoId, DateOnly nuevaFechaFin);
    }
}

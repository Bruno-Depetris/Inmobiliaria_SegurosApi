using Inmobiliaria_SegurosApi.DTOs.Comisiones;
using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IComisioneService : IGenericService<Entities.Comisione, CrearComisioneDTOs, EditarComisioneDTOs, MostrarComisioneDTOs> {
        Task<ResponseDTOs<IEnumerable<MostrarComisioneDTOs>>> GetByProductorIdAsync(int productorId);
        Task<ResponseDTOs<IEnumerable<MostrarComisioneDTOs>>> GetByContratoIdAsync(int contratoId);
        Task<ResponseDTOs<IEnumerable<MostrarComisioneDTOs>>> GetBySeguroIdAsync(int seguroId);
        Task<ResponseDTOs<IEnumerable<MostrarComisioneDTOs>>> GetByEstadoAsync(string estado);
        Task<ResponseDTOs<IEnumerable<MostrarComisioneDTOs>>> GetPendientesPagoAsync();
        Task<ResponseDTOs<decimal>> GetTotalComisionesByProductorAsync(int productorId, DateOnly? fechaDesde = null, DateOnly? fechaHasta = null);
        Task<ResponseDTOs<bool>> MarcarComoPagadaAsync(int comisionId, DateOnly fechaPago);
    }
}

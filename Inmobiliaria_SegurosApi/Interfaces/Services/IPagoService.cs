using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.DTOs.Pagos;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface IPagoService : IGenericService<Entities.Pago, CrearPagoDTOs, EditarPagoDTOs, MostrarPagoDTOs> {
        Task<ResponseDTOs<MostrarPagoDTOs>> GetByNumeroReciboAsync(string numeroRecibo);
        Task<ResponseDTOs<IEnumerable<MostrarPagoDTOs>>> GetByContratoIdAsync(int contratoId);
        Task<ResponseDTOs<IEnumerable<MostrarPagoDTOs>>> GetPendientesAsync();
        Task<ResponseDTOs<IEnumerable<MostrarPagoDTOs>>> GetVencidosAsync();
        Task<ResponseDTOs<decimal>> GetTotalPendienteAsync();
        Task<ResponseDTOs<decimal>> GetTotalVencidoAsync();
        Task<ResponseDTOs<bool>> ValidateUniqueNumeroReciboAsync(string numeroRecibo, int? excludeId = null);
        Task<ResponseDTOs<bool>> RegistrarPagoAsync(int pagoId, decimal montoPagado, short metodoPagoId, DateOnly fechaPago);
        Task<ResponseDTOs<bool>> GenerarPagosContrato(int contratoId, int cantidadMeses);
    }
}

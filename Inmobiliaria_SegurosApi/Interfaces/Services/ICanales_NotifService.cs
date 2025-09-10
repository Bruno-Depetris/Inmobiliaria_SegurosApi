using Inmobiliaria_SegurosApi.DTOs.Canales_Notif;
using Inmobiliaria_SegurosApi.DTOs.Common;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Services {
    public interface ICanales_NotifService : IGenericService<Entities.Canales_Notif, CrearCanales_Notif, EditarCanales_Notif, MostrarCanales_Notif> {
        Task<ResponseDTOs<MostrarCanales_Notif>> GetByNombreAsync(string nombre);
        Task<ResponseDTOs<IEnumerable<MostrarCanales_Notif>>> GetActivosAsync();
        Task<ResponseDTOs<bool>> ValidateUniqueNombreAsync(string nombre, short? excludeId = null);
    }
}

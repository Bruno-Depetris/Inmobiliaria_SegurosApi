using Inmobiliaria_SegurosApi.Entities;
using Inmobiliaria_SegurosApi.Interfaces.Common;

namespace Inmobiliaria_SegurosApi.Interfaces.Repositories {
    public interface ICanales_NotifRepository : IGenericRepository<Canales_Notif> {
        Task<Canales_Notif?> GetByNombreAsync(string nombre);
        Task<bool> ExistsByNombreAsync(string nombre, short? excludeId = null);
        Task<IEnumerable<Canales_Notif>> GetActivosAsync();
        Task<int> CountNotificacionesByCanal(short canalId);
    }
}

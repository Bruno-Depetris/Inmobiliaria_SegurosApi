using Inmobiliaria_SegurosApi.Entities;

namespace Inmobiliaria_SegurosApi.DTOs.Canales_Notif {
    public class MostrarCanales_Notif {
        public short CanalID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public List<Notificacione> Notificaciones { get; set; } = new List<Notificacione>();
    }
}

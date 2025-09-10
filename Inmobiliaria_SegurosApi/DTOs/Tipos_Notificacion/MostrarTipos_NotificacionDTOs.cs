namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Notificacion {
    public class MostrarTipos_NotificacionDTOs {
        public short TipoNotifID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Total_Notificaciones { get; set; }
    }
}

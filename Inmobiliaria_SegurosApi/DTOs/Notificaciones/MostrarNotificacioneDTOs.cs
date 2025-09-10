namespace Inmobiliaria_SegurosApi.DTOs.Notificaciones {
    public class MostrarNotificacioneDTOs {
        public int NotificacionID { get; set; }
        public int? UsuarioID { get; set; }
        public string? Usuario_Nombre { get; set; }
        public short TipoNotifID { get; set; }
        public string Tipo_Notificacion { get; set; } = string.Empty;
        public short Destinatario_TipoID { get; set; }
        public string Destinatario_Tipo { get; set; } = string.Empty;
        public int DestinatarioID { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Mensaje { get; set; } = string.Empty;
        public short CanalID { get; set; }
        public string Canal_Nombre { get; set; } = string.Empty;
        public short EstadoEnvioID { get; set; }
        public string Estado_Envio { get; set; } = string.Empty;
        public DateTime? Fecha_Programada { get; set; }
        public DateTime? Fecha_Envio { get; set; }
        public int? Intentos_Envio { get; set; }
        public string? Error_Mensaje { get; set; }
        public DateTime? Fecha_Creacion { get; set; }
    }
}

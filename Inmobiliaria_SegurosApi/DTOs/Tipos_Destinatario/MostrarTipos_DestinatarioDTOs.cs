namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Destinatario {
    public class MostrarTipos_DestinatarioDTOs {
        public short Destinatario_TipoID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Total_Notificaciones { get; set; }
    }
}

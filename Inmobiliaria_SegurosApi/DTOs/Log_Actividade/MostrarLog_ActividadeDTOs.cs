namespace Inmobiliaria_SegurosApi.DTOs.Log_Actividade {
    public class MostrarLog_ActividadeDTOs {
        public int LogID { get; set; }
        public int? UsuarioID { get; set; }
        public string? Usuario_Nombre { get; set; }
        public string Accion { get; set; } = string.Empty;
        public string? Tabla_Afectada { get; set; }
        public int? Registro_ID { get; set; }
        public string? Valores_Anteriores { get; set; }
        public string? Valores_Nuevos { get; set; }
        public string? IP_Address { get; set; }
        public string? User_Agent { get; set; }
        public DateTime? Fecha_Actividad { get; set; }
    }
}

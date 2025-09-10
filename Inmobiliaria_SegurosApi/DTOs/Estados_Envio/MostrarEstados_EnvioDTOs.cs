namespace Inmobiliaria_SegurosApi.DTOs.Estados_Envio {
    public class MostrarEstados_EnvioDTOs {
        public short EstadoEnvioID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Total_Notificaciones { get; set; }
    }
}

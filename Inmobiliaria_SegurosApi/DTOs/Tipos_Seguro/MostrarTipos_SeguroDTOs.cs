namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Seguro {
    public class MostrarTipos_SeguroDTOs {
        public short TipoSeguroID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Total_Seguros { get; set; }
    }
}

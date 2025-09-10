namespace Inmobiliaria_SegurosApi.DTOs.Productores {
    public class MostrarProductoreDTOs {
        public int ProductorID { get; set; }
        public string? Codigo_Productor { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Apellido { get; set; }
        public string Nombre_Completo { get; set; } = string.Empty;
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public decimal? Comision_Default { get; set; }
        public short Estado { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public int? UsuarioID { get; set; }
        public string? Usuario_Creador { get; set; }
    }
}

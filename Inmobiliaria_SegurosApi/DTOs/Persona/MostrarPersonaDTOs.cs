namespace Inmobiliaria_SegurosApi.DTOs.Persona {
    public class MostrarPersonaDTOs {
        public int PersonaID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Apellido { get; set; }
        public string Nombre_Completo { get; set; } = string.Empty;
        public string? Documento { get; set; }
        public sbyte TipoDocumentoID { get; set; }
        public string Tipo_Documento { get; set; } = string.Empty;
        public string? Direccion { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public int? CiudadID { get; set; }
        public string? Ciudad_Nombre { get; set; }
        public string? Provincia { get; set; }
        public DateOnly? Fecha_Nacimiento { get; set; }
        public int? Edad { get; set; }
        public sbyte? EstadoCivilID { get; set; }
        public string? Estado_Civil { get; set; }
        public string? Profesion { get; set; }
        public DateTime? Fecha_Creacion { get; set; }
        public short Estado { get; set; }
    }
}

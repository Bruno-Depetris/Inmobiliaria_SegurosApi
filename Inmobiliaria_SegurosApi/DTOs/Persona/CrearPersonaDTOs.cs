using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Persona {
    public class CrearPersonaDTOs {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Apellido { get; set; }

        [StringLength(20)]
        public string? Documento { get; set; }

        public sbyte TipoDocumentoID { get; set; } = 1;

        public string? Direccion { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string? Email { get; set; }

        [Phone]
        [StringLength(20)]
        public string? Telefono { get; set; }

        public int? CiudadID { get; set; }

        public DateOnly? Fecha_Nacimiento { get; set; }

        public sbyte? EstadoCivilID { get; set; }

        [StringLength(100)]
        public string? Profesion { get; set; }

        public short Estado { get; set; } = 1;
    }
}

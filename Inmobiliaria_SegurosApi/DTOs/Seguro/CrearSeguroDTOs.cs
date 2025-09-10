using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Seguro {
    public class CrearSeguroDTOs {
        [Required]
        public int PropiedadID { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero_Poliza { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Compania_Seguro { get; set; } = string.Empty;

        [Required]
        public short TipoSeguroID { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal? Prima_Mensual { get; set; }

        public short MonedaID { get; set; } = 1;

        [Required]
        public DateOnly Fecha_Inicio { get; set; }

        [Required]
        public DateOnly Fecha_Vencimiento { get; set; }

        public short EstadoSeguroID { get; set; } = 1;

        public string? Observaciones { get; set; }

        [StringLength(500)]
        public string? Archivo_Poliza { get; set; }

        public int? ProductorID { get; set; }

        public int? UsuarioID { get; set; }
    }
}

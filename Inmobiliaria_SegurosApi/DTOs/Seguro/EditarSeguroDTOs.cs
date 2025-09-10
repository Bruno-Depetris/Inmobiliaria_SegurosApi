using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Seguro {
    public class EditarSeguroDTOs {
        [Required]
        public int SeguroID { get; set; }

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

        [Required]
        public short MonedaID { get; set; }

        [Required]
        public DateOnly Fecha_Inicio { get; set; }

        [Required]
        public DateOnly Fecha_Vencimiento { get; set; }

        [Required]
        public short EstadoSeguroID { get; set; }

        public string? Observaciones { get; set; }

        [StringLength(500)]
        public string? Archivo_Poliza { get; set; }

        public int? ProductorID { get; set; }

        public int? UsuarioID { get; set; }
    }
}

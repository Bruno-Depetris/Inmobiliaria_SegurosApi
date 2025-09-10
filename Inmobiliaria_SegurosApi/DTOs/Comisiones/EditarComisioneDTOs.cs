using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Comisiones {
    public class EditarComisioneDTOs {
        [Required]
        public int ComisionID { get; set; }

        public int? ContratoID { get; set; }

        public int? SeguroID { get; set; }

        [Required]
        public int ProductorID { get; set; }

        [Required]
        [StringLength(30)]
        public string Tipo_Comision { get; set; } = string.Empty;

        [Required]
        [Range(0.01, 100.00)]
        public decimal Porcentaje { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Monto_Base { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Monto_Comision { get; set; }

        [Required]
        public DateOnly Fecha_Generacion { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado_Comision { get; set; } = string.Empty;

        public string? Observaciones { get; set; }

        public DateOnly? Fecha_Pago { get; set; }

        public int? UsuarioID { get; set; }
    }
}

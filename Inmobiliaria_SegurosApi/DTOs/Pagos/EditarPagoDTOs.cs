using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Pagos {
    public class EditarPagoDTOs {
        [Required]
        public int PagoID { get; set; }

        [Required]
        public int ContratoID { get; set; }

        [StringLength(30)]
        public string? Numero_Recibo { get; set; }

        [Required]
        public short TipoPagoID { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Monto { get; set; }

        [Required]
        public short MonedaID { get; set; }

        [Required]
        public DateOnly Fecha_Vencimiento { get; set; }

        public DateOnly? Fecha_Pago { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal? Monto_Pagado { get; set; }

        public short? MetodoPagoID { get; set; }

        [Required]
        public short EstadoPagoID { get; set; }

        public string? Observaciones { get; set; }

        [StringLength(500)]
        public string? Archivo_Comprobante { get; set; }

        public int? UsuarioID { get; set; }
    }
}

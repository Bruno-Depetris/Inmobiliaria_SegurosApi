using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Moneda {
    public class EditarMonedaDTOs {
        [Required]
        public short MonedaID { get; set; }

        [Required]
        [StringLength(3)]
        public string Codigo { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(5)]
        public string? Simbolo { get; set; }

        [Range(0, 10)]
        public sbyte Decimales { get; set; }
    }
}

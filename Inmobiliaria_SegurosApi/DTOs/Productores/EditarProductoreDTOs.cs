using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Productores {
    public class EditarProductoreDTOs {
        [Required]
        public int ProductorID { get; set; }

        [StringLength(20)]
        public string? Codigo_Productor { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Apellido { get; set; }

        [Phone]
        [StringLength(20)]
        public string? Telefono { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string? Email { get; set; }

        [Range(0.01, 100.00)]
        public decimal? Comision_Default { get; set; }

        [Required]
        public short Estado { get; set; }

        public int? UsuarioID { get; set; }
    }
}

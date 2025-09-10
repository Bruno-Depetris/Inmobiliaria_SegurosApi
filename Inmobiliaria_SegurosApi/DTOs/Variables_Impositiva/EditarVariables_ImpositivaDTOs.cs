using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Variables_Impositiva {
    public class EditarVariables_ImpositivaDTOs {
        [Required]
        public int VariableID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        [Range(0.0001, 100.0000)]
        public decimal? Porcentaje { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal? Monto_Fijo { get; set; }

        [Required]
        [StringLength(20)]
        public string Tipo_Aplicacion { get; set; } = string.Empty;

        [Required]
        public short Estado { get; set; }

        [Required]
        public DateOnly Fecha_Vigencia_Desde { get; set; }

        public DateOnly? Fecha_Vigencia_Hasta { get; set; }

        public int? UsuarioID { get; set; }
    }
}

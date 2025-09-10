using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Seguro {
    public class CrearTipos_SeguroDTOs {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}

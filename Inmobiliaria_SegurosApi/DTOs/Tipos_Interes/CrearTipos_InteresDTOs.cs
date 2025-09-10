using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Interes {
    public class CrearTipos_InteresDTOs {
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Interes {
    public class EditarTipos_InteresDTOs {
        [Required]
        public short TipoInteresID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; } = string.Empty;
    }
}

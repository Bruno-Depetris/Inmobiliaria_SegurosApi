using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Propiedad {
    public class EditarTipos_PropiedadDTOs {
        [Required]
        public short TipoPropiedadID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}

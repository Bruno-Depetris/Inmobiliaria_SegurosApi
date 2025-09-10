using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Estados_Propiedad {
    public class EditarEstados_PropiedadDTOs {
        [Required]
        public short EstadoPropiedadID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}

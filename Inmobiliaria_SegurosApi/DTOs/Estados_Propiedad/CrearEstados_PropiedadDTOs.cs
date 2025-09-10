using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Estados_Propiedad {
    public class CrearEstados_PropiedadDTOs {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}

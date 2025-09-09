using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Estados_Civil {
    public class CrearEstadosCivilDTOs {
        [Required]
        public string Nombre { get; set; } = null!;

        
    }
}

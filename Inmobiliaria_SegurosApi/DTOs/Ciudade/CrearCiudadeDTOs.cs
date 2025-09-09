using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Ciudade {
    public class CrearCiudadeDTOs {
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(100)]
        public string Province { get; set; } = string.Empty;

        [StringLength(100)]
        public string Codigo_Postal { get; set; } = string.Empty;

    }
}

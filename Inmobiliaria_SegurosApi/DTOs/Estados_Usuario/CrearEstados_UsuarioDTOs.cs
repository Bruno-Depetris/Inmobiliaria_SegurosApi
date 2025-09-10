using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Estados_Usuario {
    public class CrearEstados_UsuarioDTOs {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}

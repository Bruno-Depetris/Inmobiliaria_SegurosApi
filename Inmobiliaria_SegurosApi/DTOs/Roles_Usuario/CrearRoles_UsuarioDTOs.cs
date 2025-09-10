using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Roles_Usuario {
    public class CrearRoles_UsuarioDTOs {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}

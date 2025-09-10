using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Roles_Usuario {
    public class EditarRoles_UsuarioDTOs {
        [Required]
        public sbyte RolUsuarioID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}

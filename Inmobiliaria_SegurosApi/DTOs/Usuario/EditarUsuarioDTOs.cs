using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Usuario {
    public class EditarUsuarioDTOs {
        [Required]
        public int UsuarioID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; } = string.Empty;

        [Phone]
        [StringLength(20)]
        public string? Telefono { get; set; }

        [Required]
        public sbyte RolUsuarioID { get; set; }

        [Required]
        public sbyte EstadoUsuarioID { get; set; }
    }
}

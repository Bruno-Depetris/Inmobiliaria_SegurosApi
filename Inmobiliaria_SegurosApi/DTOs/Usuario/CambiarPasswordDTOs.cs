using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Usuario {
    public class CambiarPasswordDTOs {
        [Required]
        public int UsuarioID { get; set; }

        [Required]
        [MinLength(8)]
        public string Password_Actual { get; set; } = string.Empty;

        [Required]
        [MinLength(8)]
        [StringLength(255)]
        public string Password_Nueva { get; set; } = string.Empty;

        [Required]
        [Compare("Password_Nueva", ErrorMessage = "Las contraseñas no coinciden")]
        public string Confirmar_Password { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Roles_Cliente {
    public class CrearRoles_ClienteDTOs {
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; } = string.Empty;
    }
}

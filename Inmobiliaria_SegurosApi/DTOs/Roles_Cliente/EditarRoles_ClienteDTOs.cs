using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Roles_Cliente {
    public class EditarRoles_ClienteDTOs {
        [Required]
        public sbyte RolClienteID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; } = string.Empty;
    }
}

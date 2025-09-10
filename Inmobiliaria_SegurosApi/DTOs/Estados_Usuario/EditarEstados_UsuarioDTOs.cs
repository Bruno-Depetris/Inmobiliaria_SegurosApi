using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Estados_Usuario {
    public class EditarEstados_UsuarioDTOs {
        [Required]
        public sbyte EstadoUsuarioID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}

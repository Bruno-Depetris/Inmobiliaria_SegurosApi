using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Destinatario {
    public class CrearTipos_DestinatarioDTOs {
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; } = string.Empty;
    }
}

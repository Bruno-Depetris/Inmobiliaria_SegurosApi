using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Notificacion {
    public class CrearTipos_NotificacionDTOs {
        [Required]
        [StringLength(60)]
        public string Nombre { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Notificacion {
    public class EditarTipos_NotificacionDTOs {
        [Required]
        public short TipoNotifID { get; set; }

        [Required]
        [StringLength(60)]
        public string Nombre { get; set; } = string.Empty;
    }
}

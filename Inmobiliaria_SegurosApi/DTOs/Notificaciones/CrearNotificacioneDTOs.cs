using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Notificaciones {
    public class CrearNotificacioneDTOs {
        public int? UsuarioID { get; set; }

        [Required]
        public short TipoNotifID { get; set; }

        [Required]
        public short Destinatario_TipoID { get; set; }

        [Required]
        public int DestinatarioID { get; set; }

        [Required]
        [StringLength(255)]
        public string Titulo { get; set; } = string.Empty;

        [Required]
        public string Mensaje { get; set; } = string.Empty;

        [Required]
        public short CanalID { get; set; }

        public short EstadoEnvioID { get; set; } = 1;

        public DateTime? Fecha_Programada { get; set; }
    }
}

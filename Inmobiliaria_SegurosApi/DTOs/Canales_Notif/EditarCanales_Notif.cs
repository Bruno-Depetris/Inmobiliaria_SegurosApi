using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Canales_Notif {
    public class EditarCanales_Notif {

        [Key]
        public int CanalID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

    }
}

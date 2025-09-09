using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Canales_Notif {
    public class CrearCanales_Notif {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        
        
    }
}

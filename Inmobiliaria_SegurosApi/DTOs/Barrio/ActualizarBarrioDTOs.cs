using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Barrio {
    public class ActualizarBarrioDTOs {
        [Required]
        public int BarrioID { get; set; } 
        [Required]
        public string Nombre { get; set; } = string.Empty; 

    }
}

using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Cliente {
    public class EditarClienteDTOs {
        [Required]
        public int ClienteId { get; set; }

        [Required]
        public int PersonaID { get; set; }

        public DateTime fechaAlta { get; set; } = DateTime.Now;

        [Required]
        public string Codigo_Cliente { get; set; } = string.Empty;

        [Required]
        public string? Calificacion_Crediticia { get; set; }

        [Required]
        public string? Observaciones { get; set; }
    }
}

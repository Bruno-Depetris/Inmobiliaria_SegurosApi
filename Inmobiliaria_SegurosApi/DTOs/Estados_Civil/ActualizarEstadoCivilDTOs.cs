using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Estados_Civil {
    public class ActualizarEstadoCivilDTOs {
        [Key]
        public sbyte EstadoCivilID { get; set; }
        [Required]
        public string Nombre { get; set; } = null!;
    }
}

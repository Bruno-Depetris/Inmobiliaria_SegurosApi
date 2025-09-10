using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Estados_Seguro {
    public class EditarEstados_SeguroDTOs {
        [Required]
        public short EstadoSeguroID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}

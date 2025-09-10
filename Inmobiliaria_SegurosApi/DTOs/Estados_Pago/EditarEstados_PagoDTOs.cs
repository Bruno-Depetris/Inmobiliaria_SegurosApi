using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Estados_Pago {
    public class EditarEstados_PagoDTOs {
        [Required]
        public short EstadoPagoID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Pago {
    public class EditarTipos_PagoDTOs {
        [Required]
        public short TipoPagoID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}

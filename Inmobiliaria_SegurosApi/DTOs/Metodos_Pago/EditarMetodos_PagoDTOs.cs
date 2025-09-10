using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Metodos_Pago {
    public class EditarMetodos_PagoDTOs {
        [Required]
        public short MetodoPagoID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}

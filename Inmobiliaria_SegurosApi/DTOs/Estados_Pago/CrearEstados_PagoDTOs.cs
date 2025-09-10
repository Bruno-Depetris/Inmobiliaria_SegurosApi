using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Estados_Pago {
    public class CrearEstados_PagoDTOs {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}

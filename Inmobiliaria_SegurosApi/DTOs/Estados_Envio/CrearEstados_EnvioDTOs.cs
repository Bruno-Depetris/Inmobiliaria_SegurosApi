using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Estados_Envio {
    public class CrearEstados_EnvioDTOs {
        [Required]
        [StringLength(40)]
        public string Nombre { get; set; } = string.Empty;
    }
}

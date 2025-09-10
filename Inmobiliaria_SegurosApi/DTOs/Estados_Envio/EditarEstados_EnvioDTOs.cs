using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Estados_Envio {
    public class EditarEstados_EnvioDTOs {
        [Required]
        public short EstadoEnvioID { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Log_Actividade {
    public class CrearLog_ActividadeDTOs {
        public int? UsuarioID { get; set; }

        [Required]
        [StringLength(100)]
        public string Accion { get; set; } = string.Empty;

        [StringLength(50)]
        public string? Tabla_Afectada { get; set; }

        public int? Registro_ID { get; set; }

        public string? Valores_Anteriores { get; set; }

        public string? Valores_Nuevos { get; set; }

        [StringLength(45)]
        public string? IP_Address { get; set; }

        public string? User_Agent { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Documento {
    public class CrearTipos_DocumentoDTOs {
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; } = string.Empty;
    }
}

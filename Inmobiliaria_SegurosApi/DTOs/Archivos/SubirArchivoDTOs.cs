using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Archivos {
    public class SubirArchivoDTOs {
        [Required]
        public IFormFile Archivo { get; set; } = null!;

        [Required]
        public string Tipo_Entidad { get; set; } = string.Empty; // "Contrato", "Seguro", "Pago"

        [Required]
        public int Entidad_ID { get; set; }

        [StringLength(255)]
        public string? Descripcion { get; set; }
    }
}

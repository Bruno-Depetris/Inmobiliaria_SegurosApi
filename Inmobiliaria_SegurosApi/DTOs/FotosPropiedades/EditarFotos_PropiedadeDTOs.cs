using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.FotosPropiedades {
    public class EditarFotos_PropiedadeDTOs {
        [Required]
        public int FotoID { get; set; }

        [Required]
        public int PropiedadID { get; set; }

        [Required]
        [StringLength(500)]
        public string Foto_URL { get; set; } = string.Empty;

        [StringLength(255)]
        public string? Descripcion { get; set; }

        public bool Es_Principal { get; set; } = false;

        [Range(1, 100)]
        public int Orden_Display { get; set; } = 1;
    }
}

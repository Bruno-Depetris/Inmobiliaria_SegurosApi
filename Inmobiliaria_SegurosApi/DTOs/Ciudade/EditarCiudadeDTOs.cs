using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Ciudade {
    public class EditarCiudadeDTOs {
        [Key]
        public int CiudadID { get; set; } 

        [Required]
        [StringLength(100)]
        public string Codigo { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string provincia { get; set; } = string.Empty ;

        [Required]
        [StringLength(100)]
        public string Codigo_Postal { get; set; } = string.Empty ;


        



    }
}

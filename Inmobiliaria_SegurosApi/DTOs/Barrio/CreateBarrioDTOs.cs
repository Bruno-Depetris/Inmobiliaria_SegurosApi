using Inmobiliaria_SegurosApi.Entities;
using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Barrio {
    public class CreateBarrioDTOs {

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = null!;

        [Required]
        public int CiudadID { get; set; }


    }
}

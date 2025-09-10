using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Interesado {
    public class EditarInteresadoDTOs {
        [Required]
        public int InteresadoID { get; set; }

        [Required]
        public int PropiedadID { get; set; }

        [Required]
        public int PersonaID { get; set; }

        [Required]
        public short TipoInteresID { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal? Presupuesto_Maximo { get; set; }

        public string? Observaciones { get; set; }

        [Required]
        public short Estado { get; set; }

        public int? UsuarioID { get; set; }
    }
}

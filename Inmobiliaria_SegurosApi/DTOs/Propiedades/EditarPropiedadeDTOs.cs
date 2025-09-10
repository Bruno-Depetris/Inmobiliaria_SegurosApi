using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Propiedades {
    public class EditarPropiedadeDTOs {
        [Required]
        public int PropiedadID { get; set; }

        [StringLength(20)]
        public string? Codigo_Propiedad { get; set; }

        [Required]
        public int PropietarioID { get; set; }

        [Required]
        [StringLength(255)]
        public string Direccion { get; set; } = string.Empty;

        public int? BarrioID { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal? Metros_Cuadrados { get; set; }

        [Range(1, 50)]
        public int? Habitaciones { get; set; }

        [Range(1, 20)]
        public int? Banos { get; set; }

        [Range(0, 10)]
        public int? Cocheras { get; set; }

        [Required]
        public short TipoPropiedadID { get; set; }

        [Required]
        public short EstadoPropiedadID { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal? Valor_Alquiler { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal? Valor_Venta { get; set; }

        [Range(0, double.MaxValue)]
        public decimal? Expensas { get; set; }

        public string? Descripcion { get; set; }

        public string? Amenities { get; set; }

        public short? Anio_Construccion { get; set; }

        [StringLength(50)]
        public string? Coordenadas_GPS { get; set; }

        [Required]
        public short MonedaID { get; set; }

        public int? UsuarioID { get; set; }
    }
}

namespace Inmobiliaria_SegurosApi.DTOs.Propiedades {
    public class MostrarPropiedadeDTOs {
        public int PropiedadID { get; set; }
        public string? Codigo_Propiedad { get; set; }
        public int PropietarioID { get; set; }
        public string Propietario_Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public int? BarrioID { get; set; }
        public string? Barrio_Nombre { get; set; }
        public string? Ciudad_Nombre { get; set; }
        public decimal? Metros_Cuadrados { get; set; }
        public int? Habitaciones { get; set; }
        public int? Banos { get; set; }
        public int? Cocheras { get; set; }
        public short TipoPropiedadID { get; set; }
        public string Tipo_Propiedad { get; set; } = string.Empty;
        public short EstadoPropiedadID { get; set; }
        public string Estado_Propiedad { get; set; } = string.Empty;
        public decimal? Valor_Alquiler { get; set; }
        public decimal? Valor_Venta { get; set; }
        public decimal? Expensas { get; set; }
        public string? Descripcion { get; set; }
        public string? Amenities { get; set; }
        public short? Anio_Construccion { get; set; }
        public string? Coordenadas_GPS { get; set; }
        public short MonedaID { get; set; }
        public string Moneda_Codigo { get; set; } = string.Empty;
        public string? Moneda_Simbolo { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Actualizacion { get; set; }
        public string? Usuario_Creador { get; set; }
        public List<string> Fotos_URLs { get; set; } = new List<string>();
        public int Total_Contratos { get; set; }
        public int Total_Seguros { get; set; }
    }
}

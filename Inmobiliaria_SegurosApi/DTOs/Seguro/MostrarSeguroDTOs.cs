namespace Inmobiliaria_SegurosApi.DTOs.Seguro {
    public class MostrarSeguroDTOs {
        public int SeguroID { get; set; }
        public int PropiedadID { get; set; }
        public string Propiedad_Direccion { get; set; } = string.Empty;
        public string Numero_Poliza { get; set; } = string.Empty;
        public string Compania_Seguro { get; set; } = string.Empty;
        public short TipoSeguroID { get; set; }
        public string Tipo_Seguro { get; set; } = string.Empty;
        public decimal? Prima_Mensual { get; set; }
        public short MonedaID { get; set; }
        public string Moneda_Codigo { get; set; } = string.Empty;
        public string? Moneda_Simbolo { get; set; }
        public DateOnly Fecha_Inicio { get; set; }
        public DateOnly Fecha_Vencimiento { get; set; }
        public int Dias_Para_Vencimiento { get; set; }
        public short EstadoSeguroID { get; set; }
        public string Estado_Seguro { get; set; } = string.Empty;
        public string? Observaciones { get; set; }
        public string? Archivo_Poliza { get; set; }
        public DateTime? Fecha_Creacion { get; set; }
        public int? ProductorID { get; set; }
        public string? Productor_Nombre { get; set; }
        public string? Usuario_Creador { get; set; }
    }
}

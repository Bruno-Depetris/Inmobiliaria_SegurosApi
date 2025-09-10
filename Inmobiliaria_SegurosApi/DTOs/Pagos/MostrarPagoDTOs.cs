namespace Inmobiliaria_SegurosApi.DTOs.Pagos {
    public class MostrarPagoDTOs {
        public int PagoID { get; set; }
        public int ContratoID { get; set; }
        public string? Numero_Contrato { get; set; }
        public string? Numero_Recibo { get; set; }
        public short TipoPagoID { get; set; }
        public string Tipo_Pago { get; set; } = string.Empty;
        public decimal Monto { get; set; }
        public short MonedaID { get; set; }
        public string Moneda_Codigo { get; set; } = string.Empty;
        public string? Moneda_Simbolo { get; set; }
        public DateOnly Fecha_Vencimiento { get; set; }
        public DateOnly? Fecha_Pago { get; set; }
        public decimal? Monto_Pagado { get; set; }
        public short? MetodoPagoID { get; set; }
        public string? Metodo_Pago { get; set; }
        public short EstadoPagoID { get; set; }
        public string Estado_Pago { get; set; } = string.Empty;
        public string? Observaciones { get; set; }
        public string? Archivo_Comprobante { get; set; }
        public DateTime? Fecha_Creacion { get; set; }
        public string? Usuario_Creador { get; set; }
        public string Inquilino_Nombre { get; set; } = string.Empty;
        public string Propiedad_Direccion { get; set; } = string.Empty;
    }
}

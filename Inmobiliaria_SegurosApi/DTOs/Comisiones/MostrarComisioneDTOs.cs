namespace Inmobiliaria_SegurosApi.DTOs.Comisiones {
    public class MostrarComisioneDTOs {
        public int ComisionID { get; set; }
        public int? ContratoID { get; set; }
        public string? Numero_Contrato { get; set; }
        public int? SeguroID { get; set; }
        public string? Numero_Poliza { get; set; }
        public int ProductorID { get; set; }
        public string Productor_Nombre { get; set; } = string.Empty;
        public string Tipo_Comision { get; set; } = string.Empty;
        public decimal Porcentaje { get; set; }
        public decimal Monto_Base { get; set; }
        public decimal Monto_Comision { get; set; }
        public DateOnly Fecha_Generacion { get; set; }
        public string Estado_Comision { get; set; } = string.Empty;
        public string? Observaciones { get; set; }
        public DateOnly? Fecha_Pago { get; set; }
        public DateTime? Fecha_Creacion { get; set; }
        public string? Usuario_Creador { get; set; }
    }
}

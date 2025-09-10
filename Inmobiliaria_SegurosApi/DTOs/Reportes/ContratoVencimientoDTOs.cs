namespace Inmobiliaria_SegurosApi.DTOs.Reportes {
    public class ContratoVencimientoDTOs {
        public int ContratoID { get; set; }
        public string? Numero_Contrato { get; set; }
        public string Propiedad_Direccion { get; set; } = string.Empty;
        public string Inquilino_Nombre { get; set; } = string.Empty;
        public string? Inquilino_Telefono { get; set; }
        public string? Inquilino_Email { get; set; }
        public DateOnly Fecha_Vencimiento { get; set; }
        public int Dias_Para_Vencimiento { get; set; }
        public decimal Monto_Alquiler { get; set; }
        public string Estado_Contrato { get; set; } = string.Empty;
    }
}

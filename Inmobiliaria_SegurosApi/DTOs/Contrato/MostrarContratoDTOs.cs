namespace Inmobiliaria_SegurosApi.DTOs.Contrato {
    public class MostrarContratoDTOs {
        public int ContratoID { get; set; }
        public string? Numero_Contrato { get; set; }
        public int PropiedadID { get; set; }
        public int InquilinoID { get; set; }
        public int PropietarioID { get; set; }
        public DateOnly Fecha_Inicio { get; set; }
        public DateOnly Fecha_Fin { get; set; }
        public decimal Monto_Alquiler { get; set; }
        public decimal? Deposito_Garantia { get; set; }
        public decimal? Incremento_Porcentaje { get; set; }
        public int? Incremento_Meses { get; set; }
        public int? Vencimiento_Pago { get; set; }
        public short EstadoContratoID { get; set; }
        public string? Observaciones { get; set; }
        public string? Archivo_Contrato { get; set; }
        public short MonedaID { get; set; }
        public DateTime? Fecha_Creacion { get; set; }
        public int? ProductorID { get; set; }
        public int? UsuarioID { get; set; }
    }
}

namespace Inmobiliaria_SegurosApi.DTOs.Moneda {
    public class MostrarMonedaDTOs {
        public short MonedaID { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string? Simbolo { get; set; }
        public sbyte Decimales { get; set; }
    }
}

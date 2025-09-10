namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Pago {
    public class MostrarTipos_PagoDTOs {
        public short TipoPagoID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Total_Pagos { get; set; }
    }
}

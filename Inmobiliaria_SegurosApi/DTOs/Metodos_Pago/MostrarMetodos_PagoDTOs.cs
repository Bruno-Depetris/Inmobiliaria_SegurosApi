namespace Inmobiliaria_SegurosApi.DTOs.Metodos_Pago {
    public class MostrarMetodos_PagoDTOs {
        public short MetodoPagoID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Total_Pagos { get; set; }
    }
}

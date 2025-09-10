namespace Inmobiliaria_SegurosApi.DTOs.Estados_Pago {
    public class MostrarEstados_PagoDTOs {
        public short EstadoPagoID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Total_Pagos { get; set; }
    }
}

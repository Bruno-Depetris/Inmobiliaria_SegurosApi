using Inmobiliaria_SegurosApi.DTOs.Pagos;

namespace Inmobiliaria_SegurosApi.DTOs.Dashboard {
    public class ReportePagosDTOs {
        public DateOnly Fecha_Desde { get; set; }
        public DateOnly Fecha_Hasta { get; set; }
        public short? EstadoPagoID { get; set; }
        public int? ContratoID { get; set; }
        public List<MostrarPagoDTOs> Pagos { get; set; } = new List<MostrarPagoDTOs>();
        public decimal Total_Monto { get; set; }
        public decimal Total_Pagado { get; set; }
        public decimal Total_Pendiente { get; set; }
    }
}

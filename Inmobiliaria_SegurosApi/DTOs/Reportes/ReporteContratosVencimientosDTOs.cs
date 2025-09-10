namespace Inmobiliaria_SegurosApi.DTOs.Reportes {

    public class ReporteContratosVencimientosDTOs {
        public DateOnly Fecha_Desde { get; set; }
        public DateOnly Fecha_Hasta { get; set; }
        public List<ContratoVencimientoDTOs> Contratos { get; set; } = new List<ContratoVencimientoDTOs>();
    }
}

namespace Inmobiliaria_SegurosApi.DTOs.Dashboard {
    public class ResumenMensualDTOs {
        public int Mes { get; set; }
        public int Anio { get; set; }
        public string Nombre_Mes { get; set; } = string.Empty;
        public decimal Total_Ingresos { get; set; }
        public int Total_Pagos { get; set; }
        public int Nuevos_Contratos { get; set; }
    }
}

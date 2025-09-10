namespace Inmobiliaria_SegurosApi.DTOs.Dashboard {
    public class DashboardResumenDTOs {
        public int Total_Propiedades { get; set; }
        public int Total_Propiedades_Disponibles { get; set; }
        public int Total_Propiedades_Alquiladas { get; set; }
        public int Total_Contratos_Activos { get; set; }
        public int Total_Contratos_Por_Vencer { get; set; }
        public int Total_Pagos_Pendientes { get; set; }
        public int Total_Pagos_Vencidos { get; set; }
        public decimal Monto_Pagos_Pendientes { get; set; }
        public decimal Monto_Pagos_Vencidos { get; set; }
        public int Total_Seguros_Activos { get; set; }
        public int Total_Seguros_Por_Vencer { get; set; }
        public int Total_Clientes { get; set; }
        public int Total_Usuarios_Activos { get; set; }
        public List<ResumenMensualDTOs> Ingresos_Ultimos_12_Meses { get; set; } = new List<ResumenMensualDTOs>();
    }
}

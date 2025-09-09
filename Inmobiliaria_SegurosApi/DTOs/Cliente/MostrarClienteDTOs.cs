namespace Inmobiliaria_SegurosApi.DTOs.Cliente {
    public class MostrarClienteDTOs {

        public string Codigo_Cliente { get; set; } = string.Empty;

        public string? Calificacion_Crediticia { get; set; }

        public decimal? Ingresos_Declarados { get; set; }

        public string? Observaciones { get; set; }

        public DateTime? Fecha_Alta { get; set; } 

    }
}

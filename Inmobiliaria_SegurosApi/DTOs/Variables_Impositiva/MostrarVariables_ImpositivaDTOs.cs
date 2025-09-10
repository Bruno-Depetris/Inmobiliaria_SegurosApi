namespace Inmobiliaria_SegurosApi.DTOs.Variables_Impositiva {
    public class MostrarVariables_ImpositivaDTOs {
        public int VariableID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? Monto_Fijo { get; set; }
        public string Tipo_Aplicacion { get; set; } = string.Empty;
        public short Estado { get; set; }
        public DateOnly Fecha_Vigencia_Desde { get; set; }
        public DateOnly? Fecha_Vigencia_Hasta { get; set; }
        public bool Esta_Vigente { get; set; }
        public int? Dias_Vigencia_Restante { get; set; }
        public DateTime? Fecha_Creacion { get; set; }
        public string? Usuario_Creador { get; set; }
    }
}

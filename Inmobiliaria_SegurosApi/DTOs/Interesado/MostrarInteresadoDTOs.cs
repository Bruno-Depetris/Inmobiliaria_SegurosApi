namespace Inmobiliaria_SegurosApi.DTOs.Interesado {
    public class MostrarInteresadoDTOs {
        public int InteresadoID { get; set; }
        public int PropiedadID { get; set; }
        public string Propiedad_Direccion { get; set; } = string.Empty;
        public int PersonaID { get; set; }
        public string Persona_Nombre { get; set; } = string.Empty;
        public string Persona_Apellido { get; set; } = string.Empty;
        public string? Persona_Email { get; set; }
        public string? Persona_Telefono { get; set; }
        public short TipoInteresID { get; set; }
        public string Tipo_Interes { get; set; } = string.Empty;
        public decimal? Presupuesto_Maximo { get; set; }
        public string? Observaciones { get; set; }
        public short Estado { get; set; }
        public DateTime? Fecha_Registro { get; set; }
        public string? Usuario_Creador { get; set; }
    }
}

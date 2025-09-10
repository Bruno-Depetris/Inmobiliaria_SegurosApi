namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Propiedad {
    public class MostrarTipos_PropiedadDTOs {
        public short TipoPropiedadID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Total_Propiedades { get; set; }
    }
}

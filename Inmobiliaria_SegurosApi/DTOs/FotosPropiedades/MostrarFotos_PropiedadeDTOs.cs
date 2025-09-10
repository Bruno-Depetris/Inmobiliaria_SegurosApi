namespace Inmobiliaria_SegurosApi.DTOs.FotosPropiedades {
    public class MostrarFotos_PropiedadeDTOs {
        public int FotoID { get; set; }
        public int PropiedadID { get; set; }
        public string Propiedad_Direccion { get; set; } = string.Empty;
        public string Foto_URL { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public bool? Es_Principal { get; set; }
        public int? Orden_Display { get; set; }
        public DateTime? Fecha_Subida { get; set; }
    }
}

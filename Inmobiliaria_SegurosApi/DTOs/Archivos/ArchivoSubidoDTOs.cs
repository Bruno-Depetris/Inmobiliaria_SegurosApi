namespace Inmobiliaria_SegurosApi.DTOs.Archivos {
    public class ArchivoSubidoDTOs {
        public string Nombre_Archivo { get; set; } = string.Empty;
        public string Ruta_Archivo { get; set; } = string.Empty;
        public string Tipo_Contenido { get; set; } = string.Empty;
        public long Tamaño_Bytes { get; set; }
        public DateTime Fecha_Subida { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Documento {
    public class EditarTipos_DocumentoDTOs {
        [Required]
        public sbyte TipoDocumentoID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; } = string.Empty;
    }
}

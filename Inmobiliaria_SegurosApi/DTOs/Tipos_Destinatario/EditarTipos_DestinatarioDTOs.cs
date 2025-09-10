using System.ComponentModel.DataAnnotations;

namespace Inmobiliaria_SegurosApi.DTOs.Tipos_Destinatario {
    public class EditarTipos_DestinatarioDTOs {
        [Required]
        public short Destinatario_TipoID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; } = string.Empty;
    }
}

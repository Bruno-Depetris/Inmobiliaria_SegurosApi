using System.Security.Cryptography.Pkcs;

namespace Inmobiliaria_SegurosApi.DTOs.Ciudade {
    public class MostrarCiudadeDTOs {
        public int CiudadID {  get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Provincia { get; set; } = string.Empty;
        public string Codigo_Postal { get; set; } = string.Empty;

    }
}

namespace Inmobiliaria_SegurosApi.DTOs.Usuario {
    public class MostrarUsuarioDTOs {
        public int UsuarioID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Nombre_Completo { get; set; } = string.Empty;
        public string? Telefono { get; set; }
        public sbyte RolUsuarioID { get; set; }
        public string Rol_Usuario { get; set; } = string.Empty;
        public sbyte EstadoUsuarioID { get; set; }
        public string Estado_Usuario { get; set; } = string.Empty;
        public DateTime? Ultimo_Login { get; set; }
        public DateTime? Fecha_Creacion { get; set; }
        public DateTime? Fecha_Actualizacion { get; set; }
        public int? Intentos_Login { get; set; }
        public DateTime? Bloqueado_Hasta { get; set; }
        public bool Esta_Bloqueado { get; set; }
    }
}

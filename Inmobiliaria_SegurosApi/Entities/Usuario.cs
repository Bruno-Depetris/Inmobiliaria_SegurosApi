using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Usuario
{
    public int UsuarioID { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password_Hash { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Telefono { get; set; }

    public sbyte RolUsuarioID { get; set; }

    public sbyte EstadoUsuarioID { get; set; }

    public DateTime? Ultimo_Login { get; set; }

    public DateTime? Fecha_Creacion { get; set; }

    public DateTime? Fecha_Actualizacion { get; set; }

    public string? Reset_Token { get; set; }

    public DateTime? Reset_Token_Expiry { get; set; }

    public int? Intentos_Login { get; set; }

    public DateTime? Bloqueado_Hasta { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Comisione> Comisiones { get; set; } = new List<Comisione>();

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();

    public virtual Estados_Usuario EstadoUsuario { get; set; } = null!;

    public virtual ICollection<Interesado> Interesados { get; set; } = new List<Interesado>();

    public virtual ICollection<Log_Actividade> Log_Actividades { get; set; } = new List<Log_Actividade>();

    public virtual ICollection<Notificacione> Notificaciones { get; set; } = new List<Notificacione>();

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual ICollection<Productore> Productores { get; set; } = new List<Productore>();

    public virtual ICollection<Propiedade> Propiedades { get; set; } = new List<Propiedade>();

    public virtual Roles_Usuario RolUsuario { get; set; } = null!;

    public virtual ICollection<Seguro> Seguros { get; set; } = new List<Seguro>();

    public virtual ICollection<Sesiones_JWT> Sesiones_JWTs { get; set; } = new List<Sesiones_JWT>();

    public virtual ICollection<Variables_Impositiva> Variables_Impositivas { get; set; } = new List<Variables_Impositiva>();
}

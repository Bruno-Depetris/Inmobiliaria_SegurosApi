using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Sesiones_JWT
{
    public int SesionID { get; set; }

    public int UsuarioID { get; set; }

    public string Token_JTI { get; set; } = null!;

    public DateTime? Fecha_Creacion { get; set; }

    public DateTime Fecha_Expiracion { get; set; }

    public string? IP_Address { get; set; }

    public string? User_Agent { get; set; }

    public short Estado { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;
}

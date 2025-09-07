using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Log_Actividade
{
    public int LogID { get; set; }

    public int? UsuarioID { get; set; }

    public string Accion { get; set; } = null!;

    public string? Tabla_Afectada { get; set; }

    public int? Registro_ID { get; set; }

    public string? Valores_Anteriores { get; set; }

    public string? Valores_Nuevos { get; set; }

    public string? IP_Address { get; set; }

    public string? User_Agent { get; set; }

    public DateTime? Fecha_Actividad { get; set; }

    public virtual Usuario? Usuario { get; set; }
}

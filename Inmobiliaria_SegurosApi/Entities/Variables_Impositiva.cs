using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Variables_Impositiva
{
    public int VariableID { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? Porcentaje { get; set; }

    public decimal? Monto_Fijo { get; set; }

    public string Tipo_Aplicacion { get; set; } = null!;

    public short Estado { get; set; }

    public DateOnly Fecha_Vigencia_Desde { get; set; }

    public DateOnly? Fecha_Vigencia_Hasta { get; set; }

    public DateTime? Fecha_Creacion { get; set; }

    public int? UsuarioID { get; set; }

    public virtual Usuario? Usuario { get; set; }
}

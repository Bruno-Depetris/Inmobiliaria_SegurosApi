using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Productore
{
    public int ProductorID { get; set; }

    public string? Codigo_Productor { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Apellido { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public decimal? Comision_Default { get; set; }

    public short Estado { get; set; }

    public DateTime? Fecha_Alta { get; set; }

    public int? UsuarioID { get; set; }

    public virtual ICollection<Comisione> Comisiones { get; set; } = new List<Comisione>();

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();

    public virtual ICollection<Seguro> Seguros { get; set; } = new List<Seguro>();

    public virtual Usuario? Usuario { get; set; }
}

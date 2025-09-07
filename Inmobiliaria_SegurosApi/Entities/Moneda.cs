using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Moneda
{
    public short MonedaID { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Simbolo { get; set; }

    public sbyte Decimales { get; set; }

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual ICollection<Propiedade> Propiedades { get; set; } = new List<Propiedade>();

    public virtual ICollection<Seguro> Seguros { get; set; } = new List<Seguro>();
}

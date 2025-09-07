using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Estados_Seguro
{
    public short EstadoSeguroID { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Seguro> Seguros { get; set; } = new List<Seguro>();
}

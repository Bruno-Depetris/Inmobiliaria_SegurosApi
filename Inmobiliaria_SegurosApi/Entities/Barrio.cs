using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Barrio
{
    public int BarrioID { get; set; }

    public string Nombre { get; set; } = null!;

    public int CiudadID { get; set; }

    public virtual Ciudade Ciudad { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public virtual ICollection<Propiedade> Propiedades { get; set; } = new List<Propiedade>();
}

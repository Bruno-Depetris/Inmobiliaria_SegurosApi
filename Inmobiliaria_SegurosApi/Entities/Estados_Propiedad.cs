using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Estados_Propiedad
{
    public short EstadoPropiedadID { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Propiedade> Propiedades { get; set; } = new List<Propiedade>();
}

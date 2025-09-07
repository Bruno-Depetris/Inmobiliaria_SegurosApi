using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Estados_Civil
{
    public sbyte EstadoCivilID { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}

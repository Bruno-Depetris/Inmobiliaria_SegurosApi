using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Tipos_Propiedad
{
    public short TipoPropiedadID { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Propiedade> Propiedades { get; set; } = new List<Propiedade>();
}

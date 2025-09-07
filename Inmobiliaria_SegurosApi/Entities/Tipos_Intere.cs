using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Tipos_Intere
{
    public short TipoInteresID { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Interesado> Interesados { get; set; } = new List<Interesado>();
}

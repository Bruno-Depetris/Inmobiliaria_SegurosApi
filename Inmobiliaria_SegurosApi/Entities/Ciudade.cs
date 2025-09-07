using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Ciudade
{
    public int CiudadID { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Provincia { get; set; }

    public string? Codigo_Postal { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Barrio> Barrios { get; set; } = new List<Barrio>();

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}

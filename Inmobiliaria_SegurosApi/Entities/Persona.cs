using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Persona
{
    public int PersonaID { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Apellido { get; set; }

    public string? Documento { get; set; }

    public sbyte TipoDocumentoID { get; set; }

    public string? Direccion { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public int? CiudadID { get; set; }

    public DateOnly? Fecha_Nacimiento { get; set; }

    public sbyte? EstadoCivilID { get; set; }

    public string? Profesion { get; set; }

    public DateTime? Fecha_Creacion { get; set; }

    public short Estado { get; set; }

    public virtual Ciudade? Ciudad { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual Estados_Civil? EstadoCivil { get; set; }

    public virtual ICollection<Interesado> Interesados { get; set; } = new List<Interesado>();

    public virtual Tipos_Documento TipoDocumento { get; set; } = null!;
}

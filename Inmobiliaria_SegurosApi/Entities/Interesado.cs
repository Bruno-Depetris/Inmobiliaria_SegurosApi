using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Interesado
{
    public int InteresadoID { get; set; }

    public int PropiedadID { get; set; }

    public int PersonaID { get; set; }

    public short TipoInteresID { get; set; }

    public decimal? Presupuesto_Maximo { get; set; }

    public string? Observaciones { get; set; }

    public short Estado { get; set; }

    public DateTime? Fecha_Registro { get; set; }

    public int? UsuarioID { get; set; }

    public virtual Persona Persona { get; set; } = null!;

    public virtual Propiedade Propiedad { get; set; } = null!;

    public virtual Tipos_Intere TipoInteres { get; set; } = null!;

    public virtual Usuario? Usuario { get; set; }
}

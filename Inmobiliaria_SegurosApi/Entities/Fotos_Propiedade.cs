using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Fotos_Propiedade
{
    public int FotoID { get; set; }

    public int PropiedadID { get; set; }

    public string Foto_URL { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool? Es_Principal { get; set; }

    public int? Orden_Display { get; set; }

    public DateTime? Fecha_Subida { get; set; }

    public virtual Propiedade Propiedad { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Tipos_Notificacion
{
    public short TipoNotifID { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Notificacione> Notificaciones { get; set; } = new List<Notificacione>();
}

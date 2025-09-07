using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Notificacione
{
    public int NotificacionID { get; set; }

    public int? UsuarioID { get; set; }

    public short TipoNotifID { get; set; }

    public short Destinatario_TipoID { get; set; }

    public int DestinatarioID { get; set; }

    public string Titulo { get; set; } = null!;

    public string Mensaje { get; set; } = null!;

    public short CanalID { get; set; }

    public short EstadoEnvioID { get; set; }

    public DateTime? Fecha_Programada { get; set; }

    public DateTime? Fecha_Envio { get; set; }

    public int? Intentos_Envio { get; set; }

    public string? Error_Mensaje { get; set; }

    public DateTime? Fecha_Creacion { get; set; }

    public virtual Canales_Notif Canal { get; set; } = null!;

    public virtual Tipos_Destinatario Destinatario_Tipo { get; set; } = null!;

    public virtual Estados_Envio EstadoEnvio { get; set; } = null!;

    public virtual Tipos_Notificacion TipoNotif { get; set; } = null!;

    public virtual Usuario? Usuario { get; set; }
}

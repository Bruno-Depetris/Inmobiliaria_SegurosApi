using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Cliente
{
    public int ClienteID { get; set; }

    public int PersonaID { get; set; }

    public string? Codigo_Cliente { get; set; }

    public string? Calificacion_Crediticia { get; set; }

    public decimal? Ingresos_Declarados { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? Fecha_Alta { get; set; }

    public int? UsuarioID { get; set; }

    public virtual ICollection<Contrato> ContratoInquilinos { get; set; } = new List<Contrato>();

    public virtual ICollection<Contrato> ContratoPropietarios { get; set; } = new List<Contrato>();

    public virtual Persona Persona { get; set; } = null!;

    public virtual ICollection<Propiedade> Propiedades { get; set; } = new List<Propiedade>();

    public virtual Usuario? Usuario { get; set; }

    public virtual ICollection<Roles_Cliente> RolClientes { get; set; } = new List<Roles_Cliente>();
}

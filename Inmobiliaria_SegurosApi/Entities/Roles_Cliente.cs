using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Roles_Cliente
{
    public sbyte RolClienteID { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}

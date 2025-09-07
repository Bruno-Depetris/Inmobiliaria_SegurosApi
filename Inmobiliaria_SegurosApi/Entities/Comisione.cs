using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Comisione
{
    public int ComisionID { get; set; }

    public int? ContratoID { get; set; }

    public int? SeguroID { get; set; }

    public int ProductorID { get; set; }

    public string Tipo_Comision { get; set; } = null!;

    public decimal Porcentaje { get; set; }

    public decimal Monto_Base { get; set; }

    public decimal Monto_Comision { get; set; }

    public DateOnly Fecha_Generacion { get; set; }

    public string Estado_Comision { get; set; } = null!;

    public string? Observaciones { get; set; }

    public DateOnly? Fecha_Pago { get; set; }

    public DateTime? Fecha_Creacion { get; set; }

    public int? UsuarioID { get; set; }

    public virtual Contrato? Contrato { get; set; }

    public virtual Productore Productor { get; set; } = null!;

    public virtual Seguro? Seguro { get; set; }

    public virtual Usuario? Usuario { get; set; }
}

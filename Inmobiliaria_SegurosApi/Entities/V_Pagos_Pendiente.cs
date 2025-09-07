using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class V_Pagos_Pendiente
{
    public int PagoID { get; set; }

    public string? Numero_Recibo { get; set; }

    public string? Numero_Contrato { get; set; }

    public string Propiedad { get; set; } = null!;

    public string? Inquilino { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string Tipo_Pago { get; set; } = null!;

    public decimal Monto { get; set; }

    public DateOnly Fecha_Vencimiento { get; set; }

    public int? Dias_Vencido { get; set; }

    public string Estado_Temporal { get; set; } = null!;
}

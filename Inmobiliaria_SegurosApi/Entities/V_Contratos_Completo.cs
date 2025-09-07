using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class V_Contratos_Completo
{
    public int ContratoID { get; set; }

    public string? Numero_Contrato { get; set; }

    public string Propiedad_Direccion { get; set; } = null!;

    public string? Barrio { get; set; }

    public string? Ciudad { get; set; }

    public string? Inquilino { get; set; }

    public string? Propietario { get; set; }

    public DateOnly Fecha_Inicio { get; set; }

    public DateOnly Fecha_Fin { get; set; }

    public decimal Monto_Alquiler { get; set; }

    public string? Estado_Contrato { get; set; }

    public int? Dias_Hasta_Vencimiento { get; set; }

    public string? Productor { get; set; }

    public string? Usuario_Creador { get; set; }
}

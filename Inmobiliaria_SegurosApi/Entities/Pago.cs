using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Pago
{
    public int PagoID { get; set; }

    public int ContratoID { get; set; }

    public string? Numero_Recibo { get; set; }

    public short TipoPagoID { get; set; }

    public decimal Monto { get; set; }

    public short MonedaID { get; set; }

    public DateOnly Fecha_Vencimiento { get; set; }

    public DateOnly? Fecha_Pago { get; set; }

    public decimal? Monto_Pagado { get; set; }

    public short? MetodoPagoID { get; set; }

    public short EstadoPagoID { get; set; }

    public string? Observaciones { get; set; }

    public string? Archivo_Comprobante { get; set; }

    public DateTime? Fecha_Creacion { get; set; }

    public int? UsuarioID { get; set; }

    public virtual Contrato Contrato { get; set; } = null!;

    public virtual Estados_Pago EstadoPago { get; set; } = null!;

    public virtual Metodos_Pago? MetodoPago { get; set; }

    public virtual Moneda Moneda { get; set; } = null!;

    public virtual Tipos_Pago TipoPago { get; set; } = null!;

    public virtual Usuario? Usuario { get; set; }
}

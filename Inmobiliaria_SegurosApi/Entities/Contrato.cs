using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Contrato
{
    public int ContratoID { get; set; }

    public string? Numero_Contrato { get; set; }

    public int PropiedadID { get; set; }

    public int InquilinoID { get; set; }

    public int PropietarioID { get; set; }

    public DateOnly Fecha_Inicio { get; set; }

    public DateOnly Fecha_Fin { get; set; }

    public decimal Monto_Alquiler { get; set; }

    public decimal? Deposito_Garantia { get; set; }

    public decimal? Incremento_Porcentaje { get; set; }

    public int? Incremento_Meses { get; set; }

    public int? Vencimiento_Pago { get; set; }

    public short EstadoContratoID { get; set; }

    public string? Observaciones { get; set; }

    public string? Archivo_Contrato { get; set; }

    public short MonedaID { get; set; }

    public DateTime? Fecha_Creacion { get; set; }

    public int? ProductorID { get; set; }

    public int? UsuarioID { get; set; }

    public virtual ICollection<Comisione> Comisiones { get; set; } = new List<Comisione>();

    public virtual Estados_Contrato EstadoContrato { get; set; } = null!;

    public virtual Cliente Inquilino { get; set; } = null!;

    public virtual Moneda Moneda { get; set; } = null!;

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual Productore? Productor { get; set; }

    public virtual Propiedade Propiedad { get; set; } = null!;

    public virtual Cliente Propietario { get; set; } = null!;

    public virtual Usuario? Usuario { get; set; }
}

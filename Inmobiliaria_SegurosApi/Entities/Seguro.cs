using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Seguro
{
    public int SeguroID { get; set; }

    public int PropiedadID { get; set; }

    public string Numero_Poliza { get; set; } = null!;

    public string Compania_Seguro { get; set; } = null!;

    public short TipoSeguroID { get; set; }

    public decimal? Prima_Mensual { get; set; }

    public short MonedaID { get; set; }

    public DateOnly Fecha_Inicio { get; set; }

    public DateOnly Fecha_Vencimiento { get; set; }

    public short EstadoSeguroID { get; set; }

    public string? Observaciones { get; set; }

    public string? Archivo_Poliza { get; set; }

    public DateTime? Fecha_Creacion { get; set; }

    public int? ProductorID { get; set; }

    public int? UsuarioID { get; set; }

    public virtual ICollection<Comisione> Comisiones { get; set; } = new List<Comisione>();

    public virtual Estados_Seguro EstadoSeguro { get; set; } = null!;

    public virtual Moneda Moneda { get; set; } = null!;

    public virtual Productore? Productor { get; set; }

    public virtual Propiedade Propiedad { get; set; } = null!;

    public virtual Tipos_Seguro TipoSeguro { get; set; } = null!;

    public virtual Usuario? Usuario { get; set; }
}

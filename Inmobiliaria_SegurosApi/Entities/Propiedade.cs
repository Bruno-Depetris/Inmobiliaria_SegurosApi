using System;
using System.Collections.Generic;

namespace Inmobiliaria_SegurosApi.Entities;

public partial class Propiedade
{
    public int PropiedadID { get; set; }

    public string? Codigo_Propiedad { get; set; }

    public int PropietarioID { get; set; }

    public string Direccion { get; set; } = null!;

    public int? BarrioID { get; set; }

    public decimal? Metros_Cuadrados { get; set; }

    public int? Habitaciones { get; set; }

    public int? Banos { get; set; }

    public int? Cocheras { get; set; }

    public short TipoPropiedadID { get; set; }

    public short EstadoPropiedadID { get; set; }

    public decimal? Valor_Alquiler { get; set; }

    public decimal? Valor_Venta { get; set; }

    public decimal? Expensas { get; set; }

    public string? Descripcion { get; set; }

    public string? Amenities { get; set; }

    public short? Anio_Construccion { get; set; }

    public string? Coordenadas_GPS { get; set; }

    public short MonedaID { get; set; }

    public DateTime? Fecha_Alta { get; set; }

    public DateTime? Fecha_Actualizacion { get; set; }

    public int? UsuarioID { get; set; }

    public virtual Barrio? Barrio { get; set; }

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();

    public virtual Estados_Propiedad EstadoPropiedad { get; set; } = null!;

    public virtual ICollection<Fotos_Propiedade> Fotos_Propiedades { get; set; } = new List<Fotos_Propiedade>();

    public virtual ICollection<Interesado> Interesados { get; set; } = new List<Interesado>();

    public virtual Moneda Moneda { get; set; } = null!;

    public virtual Cliente Propietario { get; set; } = null!;

    public virtual ICollection<Seguro> Seguros { get; set; } = new List<Seguro>();

    public virtual Tipos_Propiedad TipoPropiedad { get; set; } = null!;

    public virtual Usuario? Usuario { get; set; }
}

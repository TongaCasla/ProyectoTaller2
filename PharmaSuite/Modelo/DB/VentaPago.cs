using System;
using System.Collections.Generic;

namespace PharmaSuite.Modelo.DB;

public partial class VentaPago
{
    public int IdVenta { get; set; }

    public int IdFormaPago { get; set; }

    public double Monto { get; set; }

    public virtual FormaPago IdFormaPagoNavigation { get; set; } = null!;

    public virtual Venta IdVentaNavigation { get; set; } = null!;
}

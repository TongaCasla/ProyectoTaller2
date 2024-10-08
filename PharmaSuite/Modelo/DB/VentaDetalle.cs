using System;
using System.Collections.Generic;

namespace PharmaSuite.Modelo.DB;

public partial class VentaDetalle
{
    public int IdVentaDetalle { get; set; }

    public int IdVenta { get; set; }

    public int CodBarra { get; set; }

    public int Cantidad { get; set; }

    public double Subtotal { get; set; }

    public virtual Producto CodBarraNavigation { get; set; } = null!;

    public virtual Venta IdVentaNavigation { get; set; } = null!;
}

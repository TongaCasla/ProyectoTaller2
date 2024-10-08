using System;
using System.Collections.Generic;

namespace PharmaSuite.Modelo.DB;

public partial class FormaPago
{
    public int IdFormaPago { get; set; }

    public string Forma { get; set; } = null!;

    public double Descuento { get; set; }

    public virtual ICollection<VentaPago> VentaPagos { get; set; } = new List<VentaPago>();
}

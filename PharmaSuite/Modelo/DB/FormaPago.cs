using System;
using System.Collections.Generic;

namespace PharmaSuite.Modelo.DB;

public partial class FormaPago
{
    public int IdFormaPago { get; set; }

    public string Forma { get; set; } = null!;

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}

﻿using System;
using System.Collections.Generic;

namespace PharmaSuite.Modelo.DB;

public partial class Venta
{
    public int IdVenta { get; set; }

    public int IdUsuario { get; set; }

    public int Cliente { get; set; }

    public double Total { get; set; }

    public DateTime FechaVta { get; set; }

    public virtual Persona ClienteNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();

    public virtual ICollection<VentaPago> VentaPagos { get; set; } = new List<VentaPago>();
}
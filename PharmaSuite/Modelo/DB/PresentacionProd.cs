using System;
using System.Collections.Generic;

namespace PharmaSuite.Modelo.DB;

public partial class PresentacionProd
{
    public int IdProd { get; set; }

    public int IdMedida { get; set; }

    public int Cantidad { get; set; }

    public string? FormaPresentacion { get; set; }

    public virtual Medida IdMedidaNavigation { get; set; } = null!;

    public virtual Producto IdProdNavigation { get; set; } = null!;
}

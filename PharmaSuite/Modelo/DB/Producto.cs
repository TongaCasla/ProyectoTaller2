using System;
using System.Collections.Generic;

namespace PharmaSuite.Modelo.DB;

public partial class Producto
{
    public int CodBarra { get; set; }

    public int IdCategoria { get; set; }

    public string NombreProd { get; set; } = null!;

    public double PrecioLista { get; set; }

    public double PrecioVenta { get; set; }

    public int Stock { get; set; }

    public int StockMin { get; set; }

    public DateOnly FechaVencimiento { get; set; }

    public string Activo { get; set; } = null!;

    public string VentaLibre { get; set; } = null!;

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;

    public virtual ICollection<PresentacionProd> PresentacionProds { get; set; } = new List<PresentacionProd>();

    public virtual ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();
}

using System;
using System.Collections.Generic;

namespace PharmaSuite.Modelo.DB;

public partial class Medida
{
    public int IdMedida { get; set; }

    public string UnidadMedida { get; set; } = null!;

    public virtual ICollection<PresentacionProd> PresentacionProds { get; set; } = new List<PresentacionProd>();
}

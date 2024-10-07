using System;
using System.Collections.Generic;

namespace PharmaSuite.Modelo.DB;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string NombreCategoria { get; set; } = null!;

    public string DescripcionCategoria { get; set; } = null!;
    public string estadoCategoria { get; set; } = null!;



}
using System;
using System.Collections.Generic;

namespace PharmaSuite.Modelo.DB;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public int IdPersona { get; set; }

    public virtual Persona IdPersonaNavigation { get; set; } = null!;

    
}

using System;
using System.Collections.Generic;

namespace PharmaSuite.Modelo.DB;

public partial class Perfil
{
    public int IdPerfil { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}

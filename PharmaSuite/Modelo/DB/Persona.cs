using System;
using System.Collections.Generic;

namespace PharmaSuite.Modelo.DB;

public partial class Persona
{
    public int IdPersona { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Dni { get; set; }

    public DateOnly FechaNac { get; set; }

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Sexo { get; set; } = null!;

    public string Activo { get; set; } = null!;

    public int IdPerfil { get; set; }

    public virtual Perfil IdPerfilNavigation { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}

using PharmaSuite.Modelo.DB;
using PharmaSuite.Vistas;
using Vistas;
namespace PharmaSuite
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Codigo de test
            
            Persona p = new Persona();
            p.IdPersona = 1;
            p.Nombre = "Administrador";
            p.Apellido = "";
            p.Dni = 0;
            p.FechaNac = new(2000,03,31);
            p.Telefono = "";
            p.Email = "";
            p.Sexo = "";
            p.IdPerfil = 4;
            //2 = empleado
            //3 = gerente
            //4 = admin
            ///////////////////////////////////////////////
            Usuario t = new Usuario();
            t.Nombre = "Administrador";
            t.Pass = "1234";
            t.IdPersona = 1;
            
            //Fin codigo test
            //Application.Run(new VistaLogin());
            Application.Run(new VistaMenuPpal(p));

        }
       
    }
}
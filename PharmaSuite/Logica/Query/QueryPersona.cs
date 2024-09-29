using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaSuite.Logica.Query
{
    class QueryPersona
    {
        public Persona bucarDni(int dni) 
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            Persona ps = new Persona();
            ps = dc.Personas.SingleOrDefault(s => s.Dni.Equals(dni));
           
            return ps;  
        }

        public Persona bucarTelefono(string tel)
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            Persona ps = new Persona();
            ps = dc.Personas.SingleOrDefault(s => s.Telefono.Equals(tel));
            
            return ps;
        }

        public Persona bucarEmail(string email)
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            Persona ps = new Persona();
            ps = dc.Personas.SingleOrDefault(s => s.Email.Equals(email));
           
            return ps;

        }

        public int bucarID(int dni) 
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            Persona ps = this.bucarDni(dni);

            return ps.IdPersona;

        }

        public Persona bucarPorId (int id) 
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            return dc.Personas.First(s => s.IdPersona.Equals(id));
        }

        public List<Persona> listaPersona() 
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();

            return new List<Persona>(dc.Personas); 
        }

       
    }
}

using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PharmaSuite.Logica
{
    class ValidacionPersona
    {
        public bool verificarNombre(string nombre) 
        {
            Validacion val = new Validacion();
            if (val.EsLetra(nombre))
            {
                return true;
            }else 
            {
                MessageBox.Show("El campo nombre debe contener solo letras");
                return false;
            }
        }

        public bool verificarApellido(string apellido)
        {
            Validacion val = new Validacion();
            if (val.EsLetra(apellido))
            {
                return true;
            }else
            {
                MessageBox.Show("El campo apellido debe contener solo letras");
                return false;
            }
        }

        public bool verificarDni(string dni) 
        {
           Validacion val = new Validacion();
           QueryPersona query = new QueryPersona();

           if (val.EsNumero(dni) && val.longitudDni(dni))
           {
                Persona ps = query.bucarDni(int.Parse(dni));
                if (ps == null) { return true; }
                else
                {
                    MessageBox.Show("Ya se encuentra registrado el DNI ingresado");
                    return false;
                }    
           }else 
           {
               MessageBox.Show("Número de DNI no válido");
               return false;
           }
        }

        public bool verificarTelefono(string tel) 
        {
            Validacion val = new Validacion();
            QueryPersona query = new QueryPersona();

            if (val.EsNumero(tel))
            {
                Persona ps = query.bucarTelefono(tel);
                if (ps == null) { return true; }
                else 
                {
                    MessageBox.Show("Ya se encuentra registrado el número de teléfono");
                    return false; 
                }
            }
            else
            {
                MessageBox.Show("Número de teléfono no válido");
                return false;
            }
        }

        public bool verificarEmail(string email) 
        {
            Validacion val = new Validacion();
            QueryPersona query = new QueryPersona();

            if (val.EsEmailValido(email)) 
            {
                Persona ps = query.bucarEmail(email);
                if (ps == null) { return true; }
                else 
                {
                    MessageBox.Show("Ya se encuentra registrado el email ingresado");
                    return false; 
                }
            }
            else
            {
                MessageBox.Show("Email no válido");
                return false;
            }
        }

        public bool validarDatosPersona(string[] datos)
        { 
            return (this.verificarDni(datos[2]) && this.verificarTelefono(datos[3]) && this.verificarEmail(datos[4]) && this.verificarNombre(datos[0]) && this.verificarApellido(datos[1])); 
        }


    }
}

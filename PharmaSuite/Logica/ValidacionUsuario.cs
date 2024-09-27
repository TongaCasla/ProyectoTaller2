using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaSuite.Logica
{
    class ValidacionUsuario
    {
        public bool verificarNombre(string nombre) 
        {
            Validacion val = new Validacion();
            QueryUsuario query = new QueryUsuario();

            if (val.EsCaracterValido(nombre)) 
            {
                Usuario us = query.bucarNombre(nombre);
                if (us == null)
                {
                    return true;
                }
                else 
                {
                    MessageBox.Show("El nombre se usuario ya se encuentra registrado");
                    return false;
                }
            }
            else 
            {
                MessageBox.Show("El campo usuario contiene caracteres no válidos");
                return false;
            } 
        }

        public int asignarIdPersona (int dni) 
        { 
            QueryPersona query = new QueryPersona();
            return query.bucarID(dni); 
        }

        public bool verificarDatosUsuario(string dato) 
        {
            return this.verificarNombre(dato);
        }
        
    }
}

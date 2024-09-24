using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaSuite.Logica
{
    internal class Validacion
    {
        //Metodo para validar si un campo esta vacio o no
        public  bool EsVacio(TextBox txtbox)
        {
            return String.IsNullOrEmpty(txtbox.Text);
        }

        // Método para validar si un texto tiene formato de email
        public  bool EsEmailValido(string email)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(email);
        }

        // Método para validar si un número de teléfono es válido
        public  bool EsTelefonoValido(string telefono)
        {
            // 10 dígitos como ejemplo
            var regex = new System.Text.RegularExpressions.Regex(@"^\d{10}$"); 
            return regex.IsMatch(telefono);
        }
        private bool EsFechaValida(DateTime fechaUsuario)
        {

            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Calcular la diferencia en años
            int diferenciaAnios = fechaActual.Year - fechaUsuario.Year;

            // Si la diferencia en años es mayor a 100 o la fecha seleccionada está en el futuro
            if (diferenciaAnios > 100 || fechaUsuario > fechaActual)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }


}

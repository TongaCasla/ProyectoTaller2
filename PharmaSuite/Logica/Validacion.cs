using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PharmaSuite.Logica
{
    internal class Validacion
    {
        //Metodo para validar si un campo esta vacio o no
        public  bool EsVacio(TextBox txtbox)
        {
            return !String.IsNullOrEmpty(txtbox.Text);
        }

        // Método para validar si un texto tiene formato de email
        public  bool EsEmailValido(string email)
        {
            try
            {
                var verif = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Método para validar si un número de teléfono es válido
        public  bool EsNumeroEntero(string numero)
        {
            // 10 dígitos como ejemplo
            var regex = new System.Text.RegularExpressions.Regex(@"^\d{10}$"); 
            return regex.IsMatch(numero);
        }
        public bool EsFechaValida(DateTime fechaUsuario)
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

        public bool EsLetra(string lt) 
        {
            var regex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z\s\b]");
            return regex.IsMatch(lt);
        }

        public bool EsNumero(string n) 
        {
            var regex = new System.Text.RegularExpressions.Regex("[0-9]");
            return regex.IsMatch(n);
        }

        public bool EsCaracterValido(string lt) 
        {
            var regex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z]+$");
            return regex.IsMatch(lt);
        }

        public bool longitudDni(int dni)
        {
            if(dni.ToString().Length == 8){
                return true;
            }else {
                return false;
            }

        }
        public bool longitudDni(string dni)
        {
            if (dni.Length == 8)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }


}

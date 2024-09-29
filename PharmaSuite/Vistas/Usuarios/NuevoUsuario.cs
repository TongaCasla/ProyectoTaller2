using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using PharmaSuite.Modelo.DB;
using PharmaSuite.Logica;



namespace Vistas
{
    public partial class NuevoUsuario : Form
    {
        //Variable para mostrar/ocultar la contraseña
        private bool isPasswordHidden = true;
    

        public NuevoUsuario()
        {
            InitializeComponent();
            comboPerfil.SelectedIndex = 0;
 
        }

        //Evento para mostrar la contraseña
        private void btnMostrarContra_Click(object sender, EventArgs e)
        {
            if (isPasswordHidden)
            {
                // Mostrar contraseña
                txbContra.PasswordChar = '\0';
                btnMostrarContra.Hide();
                btnOcultarContra.Show();
                isPasswordHidden = false;
                txbContra.Focus();

            }

        }
        //Evento para ocultar la contraseña
        private void btnOcultarContra_Click(object sender, EventArgs e)
        {
            if (isPasswordHidden == false)
            {
                // Ocultar contraseña
                txbContra.PasswordChar = '*';
                btnMostrarContra.Show();
                btnOcultarContra.Hide();
                isPasswordHidden = true;
                txbContra.Focus();
            }

        }

        //Evento para cerrar cuestionario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarTextBoxes(this);
        }


        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
        }
        private void txbApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTele_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dateFecha.Value.Date;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txbDni_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private string sexoRadioButton() 
        {
            string sexo = "";
            if (radioHombre.Checked)
            {
                sexo = "hombre";
            }
            else if (radioMujer.Checked) 
            {
                sexo = "mujer";
            }
            else 
            {
                sexo = "otro";
            }
            return sexo;
        }

        private bool verificarPersona()
        {
            string[] datosPersona = new string[5];
            datosPersona[0] = txbNombre.Text;
            datosPersona[1] = txbApellido.Text;
            datosPersona[2] = txbDni.Text;
            datosPersona[3] = txbTele.Text;
            datosPersona[4] = txbEmail.Text;
            Validacion val = new Validacion();
            ValidacionPersona valPer = new ValidacionPersona();
            if (val.EsVacio(txbNombre) && val.EsVacio(txbApellido) && (val.EsVacio(txbDni) && val.EsVacio(txbTele) && val.EsVacio(txbEmail)))
            {
                return (valPer.validarDatosPersona(datosPersona));
            }
            else
            {
                MessageBox.Show("Existen campos vacíos, por favor complete todos los campos");
                return false;
            }
        }

        private bool verificarUsuario()
        {
            string usuario = txbUsuario.Text;
            string pass = txbContra.Text;
            Validacion val = new Validacion();
            ValidacionUsuario valUs = new ValidacionUsuario();
            if ((val.EsVacio(txbUsuario) && val.EsVacio(txbContra)))
            {
                return valUs.verificarDatosUsuario(usuario);
            }
            else 
            {
                MessageBox.Show("Existen campos vacíos, por favor complete todos los campos");
                return false;
            }
           ;
        }
        //Evento para enviar datos e insertar en bd
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            // Mostramos un mensaje y guardamos la respuesta
            DialogResult ask = MessageBox.Show(
                "¿Desea agregar un nuevo cliente?",
                "Agregar cliente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ask == DialogResult.Yes && verificarPersona())
            {
                //Enviamos
                DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
                Usuario usuario = new Usuario();
                Persona persona = new Persona();
                persona.Nombre = txbNombre.Text;
                persona.Apellido = txbApellido.Text;
                persona.Dni = int.Parse(txbDni.Text);
                persona.Email = txbEmail.Text;
                persona.Telefono = txbTele.Text;
                persona.FechaNac = DateOnly.FromDateTime(dateFecha.Value);
                persona.IdPerfil = (comboPerfil.SelectedIndex) + 1;
                persona.Sexo = sexoRadioButton();

                if ((comboPerfil.SelectedIndex) + 1 == 1) 
                {
                    dc.Personas.Add(persona);
                    dc.SaveChanges();
                    MessageBox.Show("Se ha agregado al cliente correctamente");

                }
                else if (verificarUsuario()) 
                {
                    ValidacionUsuario valUs = new ValidacionUsuario();
                    dc.Personas.Add(persona);
                    dc.SaveChanges();
                    usuario.Nombre = txbUsuario.Text;
                    usuario.Pass = txbContra.Text;
                    usuario.IdPersona = valUs.asignarIdPersona(int.Parse(txbDni.Text));
                    dc.Usuarios.Add(usuario);
                    dc.SaveChanges();
                    MessageBox.Show("Se ha agregado al usuario correctamente");

                }

                //y luego limpiamos los datos 
                this.LimpiarTextBoxes(this);
            }
        }

        //Funcion para limpiar los datos si no se desea agregar un usuario
        private void LimpiarTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }
        }


    }
}

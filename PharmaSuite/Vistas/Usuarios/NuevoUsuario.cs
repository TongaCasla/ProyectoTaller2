using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //Evento para enviar datos e insertar en bd
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Mostramos un mensaje y guardamos la respuesta
            DialogResult ask = MessageBox.Show(
                "¿Desea agregar un nuevo cliente?",
                "Agregar cliente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ask == DialogResult.Yes)
            {
                //Enviamos

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

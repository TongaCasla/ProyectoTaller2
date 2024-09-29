using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Vistas
{
    public partial class VistaLogin : Form
    {
        private Persona usuarioActual;
        public VistaLogin()
        {
            InitializeComponent();
            this.setUsuario(usuarioActual);

        }
        public void setUsuario(Persona usuario)
        {
            this.usuarioActual = usuario;
        }
        public Persona getUsuario()
        {
            return this.usuarioActual;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //Verificamos que no haya ningun campo vacio
            if (string.IsNullOrEmpty(txtbUsuario.Text) || string.IsNullOrEmpty(txtbContra.Text))
            {
                MessageBox.Show("No puede haber campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Rescatamos los datos
            string usuario = txtbUsuario.Text;
            string password = txtbContra.Text;
            QueryUsuario qu = new();
            qu.bucarNombre(usuario);


            //Validamos la password
            /*
            if (qu.bucarNombre(usuario) && qu.verificarPassword(password))
            {
                //Ocultamos la pantalla del login
                this.Hide();
                //Seteamos el usuario
                this.setUsuario(usuario);
                VistaMenuPpal form = new(this.getUsuario());
                form.Show();
                form.FormClosed += (s, args) => this.Close();

            }
            //Si no, mostramos mensaje de error
            else
            {
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }



}


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
       
        public VistaLogin()
        {
            InitializeComponent();
           

        }
       


        private void btnLogin_Click(object sender, EventArgs e)
        {
            QueryUsuario query = new QueryUsuario();
            QueryPersona queryPs = new QueryPersona();

            //Verificamos que no haya ningun campo vacio
            if (string.IsNullOrEmpty(txtbUsuario.Text) || string.IsNullOrEmpty(txtbContra.Text))
            {
                MessageBox.Show("No puede haber campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
            else if (query.bucarNombre(txtbUsuario.Text) == null)
            {
                MessageBox.Show("Nombre de usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else if (query.bucarNombre(txtbUsuario.Text).Pass != txtbContra.Text)
            {

                MessageBox.Show("Contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {

                Usuario us = query.bucarNombre(txtbUsuario.Text);
                Persona usuarioActual = queryPs.bucarPorId(us.IdPersona);


                //Ocultamos la pantalla del login
                this.Hide();
                //Seteamos el usuario

                VistaMenuPpal form = new(usuarioActual);
                form.Show();
                form.FormClosed += (s, args) => this.Close();
            }

            txtbUsuario.Clear();
            txtbContra.Clear();



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }



}


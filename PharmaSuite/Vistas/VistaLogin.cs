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
        private string usuario;
        public VistaLogin()
        {
            this.setUsuario(string.Empty);
            InitializeComponent();
            this.Resize += new EventHandler(Form2_Resize);
            CenterPanel();

        }
        public void setUsuario(String usuario)
        {
            this.usuario = usuario;
        }
        public String getUsuario()
        {
            return this.usuario;
        }


        private void CenterPanel()
        {
            int x = (this.ClientSize.Width - panel1.Width) / 2;
            int y = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            CenterPanel();
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
            /*Opcional*/
            //Comparamos si son iguales
            if (usuario == password)
            {
                //Ocultamos la pantalla del login
                this.Hide();
                //Seteamos el usuario
                this.setUsuario(usuario);
                // Abrimos el nuevo formulario
                VistaMenuPpal form = new(this.getUsuario());
                form.Show();
                // Cerramos el formulario actual cuando el nuevo se cierre
                form.FormClosed += (s, args) => this.Close();

            }
            //Si no, mostramos mensaje de error
            else
            {
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }



}


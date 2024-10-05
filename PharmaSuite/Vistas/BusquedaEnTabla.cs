using Microsoft.IdentityModel.Tokens;
using PharmaSuite.Logica;
using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using PharmaSuite.Vistas.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaSuite.Vistas
{
    public partial class BusquedaEnTabla : Form
    {
        private String tituloTabla;
        private Persona usuarioActual;
        public BusquedaEnTabla(String tituloTabla, Persona usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            this.setTitulo(verificarCasosTitulo(tituloTabla));
            this.KeyPreview = true; 

        }
        public BusquedaEnTabla(bool label)
        {
            InitializeComponent();
            labelTitulo.Visible = label;
            this.setTitulo("");

        }
        private void BusquedaEnTabla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();  
            }
        }


        private void setTitulo(String tituloLabel)
        {
            labelTitulo.Text += tituloLabel;
        }
        private String getTitulo(String tituloLabel)
        {
            return this.tituloTabla;
        }

        private String verificarCasosTitulo(String tituloVista)
        {
            String tituloBusqueda = "";

            switch (tituloVista)
            {
                case "Productos":
                    tituloBusqueda = "Nombre";
                    break;
                case "Categorías":
                    tituloBusqueda = "Categoría";
                    break;
                default:
                    tituloBusqueda = "DNI";
                    break;
            }
            return tituloBusqueda;
        }

        //Metodo que realiza la buqueda
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Persona ps = new();
            QueryPersona qp = new();
            //Verificamos si se ingresó correctamente
            string textoAbuscar = txbBusqueda.Text;
            //Validamos que no este vacio
            if (txbBusqueda.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Campo obligatorio, Por favor, ingrese un número",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            //Validamos que sea numero
            if(!int.TryParse(txbBusqueda.Text, out int numero))
            {
                MessageBox.Show("Datos incorrectos. Por favor, ingrese un número válido",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            //Validamos que sea un dni correcto (8 digitos)
            int dniPersona = int.Parse(txbBusqueda.Text);
            Validacion val = new();
            if (!val.longitudDni(dniPersona)){
                MessageBox.Show("Datos incorrectos. Por favor, ingrese un número de DNI válido",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (qp.bucarDni(dniPersona) == null)
            {
                lTablaVacia.Show();
            }
            else
            {
                ps = qp.bucarDni(dniPersona);
                DatosPersona p = new(ps, this.usuarioActual);
                p.Show();
                lTablaVacia.Hide();

            }

        }
    }
}

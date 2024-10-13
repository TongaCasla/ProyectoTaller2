using Microsoft.IdentityModel.Tokens;
using PharmaSuite.Logica.Query;
using PharmaSuite.Logica;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaSuite.Vistas.Usuarios
{
    public partial class BusquedaPersona : Form
    {
        private Persona usuarioActual;
        public BusquedaPersona(Persona usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            this.KeyPreview = true;

        }
        private void BusquedaEnTabla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

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
            if (!int.TryParse(txbBusqueda.Text, out int numero))
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
            if (!val.longitudDni(dniPersona))
            {
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

using Microsoft.IdentityModel.Tokens;
using PharmaSuite.Logica;
using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using PharmaSuite.Vistas.Usuarios;
using PharmaSuite.Vistas.Ventas;
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
    public partial class BusquedaCliente : Form
    {
        private VentaActual VentaActual;

        public BusquedaCliente(VentaActual venta)
        {
            InitializeComponent();
            this.KeyPreview = true; 
            VentaActual=venta;
        }
        public BusquedaCliente()
        {
            InitializeComponent();

        }
        private void BusquedaEnTabla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();  
            }
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
                VentaActual.setCliente(ps);
                this.Close();
            }

        }
       
    }
}

using PharmaSuite.Vistas.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas;

namespace PharmaSuite.Vistas
{
    public partial class NuevaVenta : Form
    {
        private BusquedaEnTabla formBuscar;

        public NuevaVenta()
        {
            InitializeComponent();
        }

        private void TBCodigoprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), "[0-9\b]"))
            {
                e.Handled = false; // input ok
            }
            else
            {
                e.Handled = true; // input denied
            }
        }

        private void TBNombreprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z\s\b]"))
            {
                e.Handled = false; // input ok
            }
            else
            {
                e.Handled = true; // input denied
            }
        }
        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), "[0-9\b]"))
            {
                e.Handled = false; // input ok
            }
            else
            {
                e.Handled = true; // input denied
            }
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z\s\b]"))
            {
                e.Handled = false; // input ok
            }
            else
            {
                e.Handled = true; // input denied
            }
        }

        //Metodo para bloquear los campos si es consumidor final
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TBDni.Enabled = false;
                btnBuscarDNI.Enabled = false;
                btnCliente.Enabled = false;
            }
            else
            {
                TBDni.Enabled = true;
                btnBuscarDNI.Enabled = true;
                btnCliente.Enabled = true;
            }
        }
        //Metodo para agregar un nuevo cliente al momento de realizar la compra
        private void btnCliente_Click(object sender, EventArgs e)
        {
            //Agregamos el formulario para un nuevo cliente
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            this.Controls.Clear();
            nuevoUsuario.TopLevel = false;
            nuevoUsuario.Dock = DockStyle.Fill;
            this.Controls.Add(nuevoUsuario);
            nuevoUsuario.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BusquedaEnVenta busqueda = new(label4.Text);
            busqueda.Show();

        }

        private void btnBuscarNombreProd_Click(object sender, EventArgs e)
        {
            BusquedaEnVenta busqueda = new(label4.Text);
            busqueda.Show();
        }

        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            BusquedaEnVenta busqueda = new(label1.Text);
            busqueda.Show();
        }
    }
}

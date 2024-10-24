using PharmaSuite.Vistas.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas;

namespace PharmaSuite.Vistas
{
    public partial class NuevaVenta : Form
    {
        // private BusquedaEnTabla formBuscar;


        public NuevaVenta()
        {
            InitializeComponent();
            this.iniciarBuscador();
        }
        private void iniciarBuscador()
        {
            /*
            this.formBuscar = new BusquedaEnTabla("Productos",null);
            this.formBuscar.TopLevel = false;
            this.formBuscar.Anchor = AnchorStyles.Right;
            this.formBuscar.Dock = DockStyle.Right;
            this.Controls.Add(formBuscar);
            formBuscar.Show();
            this.FormBorderStyle = FormBorderStyle.None;*/
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
            nuevoUsuario.Text = "Nuevo cliente";
            //nuevoUsuario.Icon = new(Path.Combine(Application.StartupPath, "farmacia.ico"));
            nuevoUsuario.Show();
        }

        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            BusquedaEnVenta busqueda = new(label1.Text);
            busqueda.Show();
        }

        private void btnBuscarNombreProd_Click(object sender, EventArgs e)
        {

        }
    }
}

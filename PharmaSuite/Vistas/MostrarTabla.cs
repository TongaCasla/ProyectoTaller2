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
    public partial class MostrarTabla : Form
    {
        private String tituloTabla;
        private BusquedaEnTabla formBuscar;
        public MostrarTabla(string tituloLabel)
        {
            InitializeComponent();
            this.setTitulo(tituloLabel);
            //this.testearTabla();
            this.verificarTabla();
        }
        public MostrarTabla(String tituloLabel, bool habilitarBotones)
        {
            InitializeComponent();
            this.setTitulo(tituloLabel);
            this.verificarTabla();
            btnBuscar.Visible= habilitarBotones;
            btnMostrarActivos.Visible= habilitarBotones;
            btnMostrarInactivos.Visible= habilitarBotones;
        }
        private void setTitulo(String tituloLabel)
        {
            labelTituloTabla.Text += tituloLabel;
            tituloTabla = tituloLabel;
        }
        public String getTitulo()
        {
            return this.tituloTabla;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verifica si el formulario ya existe y está visible
            if (formBuscar == null)
            {
                // Si no existe o ha sido cerrado, crea una nueva instancia
                formBuscar = new BusquedaEnTabla(this.getTitulo());
                formBuscar.TopLevel = false;
                formBuscar.Dock = DockStyle.Right;
                this.Controls.Add(formBuscar);
                formBuscar.Show();
            }
            else
            {
                // Si ya está abierto, lo trae al frente
                formBuscar.BringToFront();
            }
        }
        private void verificarTabla()
        {
            if (dataGridView1.Rows.Count == 0)
            {

                lTablaVacia.Show();
                dataGridView1.Hide();
            }
            else
            {
                lTablaVacia.Hide();
                dataGridView1.Show();
            }
        }
        private void testearTabla()
        {
            // Definir columnas del DataGridView
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Código de Producto";
            dataGridView1.Columns[1].Name = "Nombre del Producto";
            dataGridView1.Columns[2].Name = "Precio";

            // Datos de ejemplo que quieres agregar al DataGridView
            string codigoProducto = "P001";
            string nombreProducto = "Producto de prueba";
            decimal precioProducto = 100.50m;

            // Agregar una nueva fila con los datos al DataGridView
            dataGridView1.Rows.Add(codigoProducto, nombreProducto, precioProducto);
        }

    }
}

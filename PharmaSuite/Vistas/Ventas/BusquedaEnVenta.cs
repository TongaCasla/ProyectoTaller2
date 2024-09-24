using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaSuite.Vistas.Ventas
{
    public partial class BusquedaEnVenta : Form
    {
        private String tituloBusqueda;
        public BusquedaEnVenta(String busquedaARealizar)
        {
            InitializeComponent();
            this.setTituloBusqueda(busquedaARealizar);
            this.testearTabla();
            //this.verificarTabla();
        }
        private void setTituloBusqueda(String busquedaARealizar)
        {
            labelTituloBusqueda.Text += busquedaARealizar;
            this.tituloBusqueda = busquedaARealizar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(sender, e);
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

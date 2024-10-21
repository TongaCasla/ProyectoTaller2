using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaSuite.Vistas.Productos
{
    public partial class ListaProductos : Form
    {
        public ListaProductos()
        {
            InitializeComponent();
            this.mostrarProductos();
        }
        private void cargarProductos(List<Producto> lista)
        {
            dataGridView1.Rows.Clear();
            QueryCategoria qc = new();
            foreach (Producto p in lista)
            {
                dataGridView1.Rows.Add(p.CodBarra, p.NombreProd, qc.buscarPorID(p.IdCategoria).Descripcion, p.PrecioVenta, p.Stock, p.Activo, "Modificar", "Eliminar");
            }

        }
        private void mostrarProductos()
        {
            QueryProducto q = new();
            List<Producto> listaTodos = q.listaProductos();
            this.cargarProductos(listaTodos);
        }

        private void btnMostrarActivos_Click(object sender, EventArgs e)
        {
            this.mostrarProductosActivos();
        }

        private void mostrarProductosActivos()
        {
            QueryProducto q = new();
            List<Producto> listaActivos = q.listaProductosActivos();
            this.cargarProductos(listaActivos);
        }
        private void mostrarProductosInactivos()
        {
            QueryProducto q = new();
            List<Producto> listaInactivos = q.listaProductosInactivos();
            this.cargarProductos(listaInactivos);
        }

        private void btnMostrarInactivos_Click(object sender, EventArgs e)
        {
            this.mostrarProductosInactivos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DbPharmaSuiteContext cn = new DbPharmaSuiteContext();
            QueryProducto query = new();
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                int codProd = int.Parse(selectedRow.Cells["CodBarra"].Value.ToString());
                Producto p = cn.Productos.Where(u => u.CodBarra == codProd).First();

                if (p.Activo == "si")
                {
                    p.Activo = "no";
                    cn.SaveChanges();
                }
                else
                {
                    p.Activo = "si";
                    cn.SaveChanges();
                }
                this.mostrarProductos();
                MessageBox.Show("Se ha modificado correctamente");

            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.mostrarProductos();
        }
    }
}

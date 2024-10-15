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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmaSuite.Vistas.Categorias
{
    public partial class ListaCategorias : Form
    {
        private string valorAnterior = string.Empty;

        public ListaCategorias()
        {
            InitializeComponent();
            this.iniciarTabla();
            this.mostrarCategorias();
        }

        private void mostrarCategorias()
        {
            QueryCategoria query = new();
            List<Categoria> categorias = query.listaCategoria();
            this.cargarTabla(categorias);
        }

        private void iniciarTabla()
        {
            // Hacer editable solo la columna específica 
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = false;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;

            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void cargarTabla(List<Categoria> lista)
        {
            dataGridView1.Rows.Clear();

            foreach (Categoria c in lista)
            {

                dataGridView1.Rows.Add(c.IdCategoria, c.Descripcion, c.Activo, "Eliminar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.agregarCategoria();
            this.mostrarCategorias();
        }

        private void agregarCategoria()
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            Validacion val = new();
            //Verifcamos que no se ingrese campos vacios
            if (txbNombreCat.Text.IsNullOrEmpty())
            {
                MessageBox.Show("No se puede ingresar campos vacíos.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            //Verificamos que no se ingresen numeros
            if (val.EsNumero(txbNombreCat.Text))
            {
                MessageBox.Show("No se puede ingresar números.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            //Instanciamos nuestra categoria y la guardamos en la base de datos
            Categoria c = new();
            c.Descripcion = txbNombreCat.Text;
            dc.Categorias.Add(c);
            dc.SaveChanges();

            MessageBox.Show("Categoría guardada correctamente.",
            "Categoría agregada",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que no sea un encabezado de columna o fila
            if (e.ColumnIndex == 1)
            {
                // Habilita la edición de la celda seleccionada
                dataGridView1.BeginEdit(true);
            }
        }
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Almacenar el valor actual de la celda antes de la edición
            valorAnterior = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        // Este evento se dispara cuando el usuario termina de editar una celda
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            String valorNuevo = string.Empty;
            // Instancia para validar
            Validacion val = new Validacion();

            // Obtener el nuevo valor de la celda editada
            String newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            // Validar si el nuevo valor es nulo o vacío
            if (newValue == null)
            {
                // Mostrar mensaje de validación
                MessageBox.Show("No se pueden ingresar campos vacíos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Restaurar el valor anterior si no pasa la validación
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = valorAnterior;
                return;
            }

            // Validar si el nuevo valor es un número
            if (val.EsNumero(newValue))
            {
                MessageBox.Show("No se pueden ingresar números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Restaurar el valor anterior si no pasa la validación
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = valorAnterior;
                return;
            }
            //Modificamos la descripcion de la categoria
            //Guardamos el valor nuevo
            valorNuevo = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //Guardamos el id de la categoria
            int idCategoria = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //Seleccionamos la misma celda
            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //Guardamos en bd y mostramos mensaje exitoso
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            Categoria c = dc.Categorias.Where(u => u.IdCategoria == idCategoria).First();
            c.Descripcion = valorNuevo;
            dc.SaveChanges();
            MessageBox.Show("Se ha modificado correctamente", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostrarActivos_Click(object sender, EventArgs e)
        {
            this.mostrarCategoriasActivas();
        }

        private void mostrarCategoriasActivas()
        {
            QueryCategoria query = new();
            List<Categoria> categoriasActivas = query.mostrarActivas();
            this.cargarTabla(categoriasActivas);
        }

        private void btnMostrarInactivos_Click(object sender, EventArgs e)
        {
            QueryCategoria query = new();
            List<Categoria> categoriasInactivas = query.mostrarInactivas();
            this.cargarTabla(categoriasInactivas);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            this.mostrarCategorias();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DbPharmaSuiteContext cn = new DbPharmaSuiteContext();
            QueryCategoria query = new();
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                int codCategoria = int.Parse(selectedRow.Cells["Cod"].Value.ToString());
                Categoria c = cn.Categorias.Where(u => u.IdCategoria == codCategoria).First();

                if (c.Activo == "si")
                {
                    c.Activo = "no";
                    cn.SaveChanges();
                    MessageBox.Show("Se ha desactiva correctamente");
                }
                else
                {
                    c.Activo = "si";
                    cn.SaveChanges();
                    MessageBox.Show("Se ha activada correctamente");
                }
                this.mostrarCategorias();

            }
        }
    }
}



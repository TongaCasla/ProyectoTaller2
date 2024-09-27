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
            this.pruebaTablas();
            //this.verificarTabla();

        }
        public MostrarTabla(String tituloLabel, bool habilitarBotones)
        {
            InitializeComponent();
            this.setTitulo(tituloLabel);
            this.verificarTabla();
            btnBuscar.Visible = habilitarBotones;
            btnMostrarActivos.Visible = habilitarBotones;
            btnMostrarInactivos.Visible = habilitarBotones;
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
        private void pruebaTablas()
        {
           
            QueryPersona query = new QueryPersona();
            List <Persona> lista = query.listaPersona();

            foreach (Persona ps in lista) 
            {
                dataGridView1.Rows.Add(ps.Dni, ps.Nombre, ps.IdPerfil, ps.Activo);
            }

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



        //Evento para abrir la informacion de la celda
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la fila no es el encabezado y que se ha hecho clic en una celda válida
            if (e.ColumnIndex != dataGridView1.Columns["action"].Index)

            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Por ejemplo, obtener el valor de la primera columna (Código de Producto)
                string nombrePersona = selectedRow.Cells[1].Value.ToString();

                // Abrir el nuevo formulario y pasarle el dato del código de producto
                //DatosPersona formNuevo = new DatosPersona(nombrePersona, 0);
                //formNuevo.Text = "Datos de " + nombrePersona;
                //formNuevo.Show();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que no sea el encabezado de la columna
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar que se hizo clic en la columna del botón
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    string estadoActual = selectedRow.Cells["EstadoPersona"].Value.ToString();

                    if (estadoActual == "Activo")
                    {
                    selectedRow.Cells["EstadoPersona"].Value = "Inactivo";

                    }
                    else
                    {
                        selectedRow.Cells["EstadoPersona"].Value = "Activo";


                    }

                }
            }
        }
    }
}





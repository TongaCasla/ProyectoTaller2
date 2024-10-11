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
        private String tituloTabla = "Clientes";
        private Persona usuarioActual;
        private string estado = "si";
        private int tipoPerfil = 1;

        int idPerfil;
        public MostrarTabla(Persona usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            this.setTitulo(tituloTabla);
            //this.verificarTabla();
            this.pruebaTablas();
        }

        public MostrarTabla(String titulo,Persona usuarioActual)

        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            this.setTitulo(tituloTabla);
            //this.verificarTabla();
            this.pruebaTablas();

        }
        public MostrarTabla(String tituloLabel, bool habilitarBotones, Persona usuarioActual)
        {
            InitializeComponent();
            this.setTitulo(tituloLabel);
            this.usuarioActual = usuarioActual;
            this.verificarTabla();
            btnBuscar.Visible = habilitarBotones;
            btnMostrarActivos.Visible = habilitarBotones;
            btnMostrarInactivos.Visible = habilitarBotones;

        }
        private void setTitulo(String tituloLabel)
        {
           labelTipo.Text = tituloLabel;

        }

        private void pruebaTablas()
        {
            dataGridView1.Rows.Clear();
            QueryPersona query = new QueryPersona();
            List<Persona> lista = query.listaPersona();

            foreach (Persona ps in lista)
            {
                if (ps.IdPerfil == 1 && tipoPerfil == 1)
                {
                    dataGridView1.Rows.Add(ps.Dni, ps.Nombre, ps.Apellido, ps.Email, ps.IdPerfil, ps.Activo, "Modificar", "Eliminar");
                    dataGridView1.Columns[7].Visible = false;
                }
                else if (tipoPerfil != 1 && ps.Activo == estado && ps.IdPerfil != 1)
                {
                    dataGridView1.Rows.Add(ps.Dni, ps.Nombre, ps.Apellido, ps.Email, ps.IdPerfil, ps.Activo, "Modificar", "Eliminar");
                    dataGridView1.Columns[7].Visible = true;
                }


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
                this.pruebaTablas();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DbPharmaSuiteContext cn = new DbPharmaSuiteContext();
            QueryPersona query = new QueryPersona();
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                int dni = int.Parse(selectedRow.Cells["Dni"].Value.ToString());
                Persona ps = cn.Personas.Where(u => u.Dni == dni).First();

                if (ps.Activo == "si")
                {
                    ps.Activo = "no";
                    cn.SaveChanges();

                }
                else
                {
                    ps.Activo = "si";
                    cn.SaveChanges();


                }
                this.pruebaTablas();
                MessageBox.Show("Se ha modificado el campo correctamente");

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                int dni = int.Parse(selectedRow.Cells["Dni"].Value.ToString());
                Persona ps = cn.Personas.Where(u => u.Dni == dni).First();

                DatosPersona dtPer = new DatosPersona(ps, usuarioActual);

                dtPer.Show();
            }

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            tipoPerfil = 1;
            this.setTitulo("Clientes");
            this.pruebaTablas();

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            tipoPerfil = 0;
            this.setTitulo("Empleados");
            this.pruebaTablas();
        }

        private void btnMostrarActivos_Click(object sender, EventArgs e)
        {
            estado = "si";
            this.pruebaTablas();
        }

        private void btnMostrarInactivos_Click(object sender, EventArgs e)
        {
            estado = "no";
            this.pruebaTablas();
        }

        
    }
}





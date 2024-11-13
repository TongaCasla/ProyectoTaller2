using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaSuite.Vistas.Usuarios
{
    public partial class ListaUsuarios : Form
    {
        private Persona usuarioActual;
        private string estado = "si";
        private int tipoPerfil = 1;

        public ListaUsuarios(Persona usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            this.verificarTipoPerfil();
            this.mostrarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
           BusquedaCliente formBuscar = new(this.usuarioActual);
           formBuscar.ShowDialog();
        }
        private void mostrarClientes()
        {
            btnMostrarActivos.Enabled = false;
            btnMostrarInactivos.Enabled = false;
            btnMostrarActivos.BackColor = Color.FromArgb(211, 211, 211);
            btnMostrarInactivos.BackColor = Color.FromArgb(211, 211, 211);
            dataGridView1.Rows.Clear();
            //Ajustamos el contenido de las columnas
            QueryPersona query = new QueryPersona();
            List<Persona> lista = query.listaPersona();
            string nombrePerfil = "Cliente";

            foreach (Persona ps in lista)
            {
                //Cliente
                if (ps.IdPerfil == 1)
                {
                    dataGridView1.Rows.Add(ps.Dni, ps.Nombre, ps.Apellido, ps.Email, nombrePerfil);

                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                }
            }
        }
        private void mostrarTodosEmpleados()
        {
            btnMostrarActivos.Enabled = true;
            btnMostrarInactivos.Enabled = true;
            btnMostrarActivos.BackColor = Color.PaleGreen;
            btnMostrarInactivos.BackColor = Color.LightCoral;
            dataGridView1.Rows.Clear();
            QueryPersona query = new QueryPersona();
            QueryUsuario queryU = new();
            List<Persona> lista = query.listaPersona();
            string nombrePerfil = "";

            foreach (Persona ps in lista)
            {
                if (ps.IdPerfil != 1)
                {
                    Usuario u = queryU.buscarPorIdPers(ps.IdPersona);

                    switch (ps.IdPerfil)
                    {
                        //Empleado
                        case 2:
                            {
                                nombrePerfil = "Empleado";
                                break;
                            }
                        //Gerente
                        case 3:
                            {
                                nombrePerfil = "Gerente";
                                break;
                            }
                        //Admin
                        case 4:
                            {
                                nombrePerfil = "Administrador";
                                break;
                            }
                    }

                    dataGridView1.Rows.Add(ps.Dni, ps.Nombre, u.Nombre, ps.Email, nombrePerfil, ps.Activo, "Modificar", "Eliminar");
                    dataGridView1.Columns[2].HeaderText = "Usuario";

                    dataGridView1.Columns[5].Visible = true;
                    dataGridView1.Columns[6].Visible = true;
                    dataGridView1.Columns[7].Visible = true;
                }
            }

        }
        private String asignarNombreEmpleado(int perfilEmpleado)
        {
            string nombreEmpleado = "";
            switch (tipoPerfil)
            {
                //Empleado
                case 2:
                    {
                        nombreEmpleado = "Empleado";
                        break;
                    }
                //Gerente
                case 3:
                    {
                        nombreEmpleado = "Gerente";
                        break;
                    }
                case 4:
                    {
                        nombreEmpleado = "Administrador";
                        break;
                    }
            }
            return nombreEmpleado;

        }

        private void verificarTipoPerfil()
        {
            //Perfil empleado
            if (usuarioActual.IdPerfil == 2)
            {
                btnMostrarInactivos.Enabled = false;
                btnMostrarActivos.Enabled = false;
                btnEmpleado.Enabled = false;
                btnMostrarActivos.BackColor = Color.FromArgb(211, 211, 211);
                btnMostrarInactivos.BackColor = Color.FromArgb(211, 211, 211);
                btnEmpleado.BackColor = Color.FromArgb(211, 211, 211);

            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            labelTipo.Text = "Clientes";
            this.mostrarClientes();
            
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            labelTipo.Text = "Empleados";
            this.mostrarTodosEmpleados();
           

        }

        private void mostrarEmplPorEstado(string estadoEmpl)
        {
            dataGridView1.Rows.Clear();
            QueryPersona query = new QueryPersona();
            QueryUsuario queryU = new();
            List<Persona> lista = query.listaPersona();
            string nombrePerfil = "";

            foreach (Persona ps in lista)
            {
                if (ps.IdPerfil != 1 && ps.Activo == estadoEmpl)
                {
                    Usuario u = queryU.buscarPorIdPers(ps.IdPersona);

                    switch (ps.IdPerfil)
                    {
                        //Empleado
                        case 2:
                            {
                                nombrePerfil = "Empleado";
                                break;
                            }
                        //Gerente
                        case 3:
                            {
                                nombrePerfil = "Gerente";
                                break;
                            }
                        //Admin
                        case 4:
                            {
                                nombrePerfil = "Administrador";
                                break;
                            }
                    }

                    dataGridView1.Rows.Add(ps.Dni, ps.Nombre, u.Nombre, ps.Email, nombrePerfil, ps.Activo, "Modificar", "Eliminar");
                    dataGridView1.Columns[2].HeaderText = "Usuario";

                    dataGridView1.Columns[5].Visible = true;
                    dataGridView1.Columns[6].Visible = true;
                    dataGridView1.Columns[7].Visible = true;
                }
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
                this.mostrarTodosEmpleados();
                MessageBox.Show("Se ha modificado el campo correctamente");

            }
            else if (e.RowIndex >= 0 || e.ColumnIndex == 6)
            {
                int dni = int.Parse(selectedRow.Cells["Dni"].Value.ToString());
                Persona ps = cn.Personas.Where(u => u.Dni == dni).First();
                DatosPersona dtPer = new DatosPersona(ps, usuarioActual);
                dtPer.ShowDialog();
            }

        }

        private void btnMostrarActivos_Click(object sender, EventArgs e)
        {
            this.mostrarEmplPorEstado("si");
        }

        private void btnMostrarInactivos_Click(object sender, EventArgs e)
        {
            this.mostrarEmplPorEstado("no");
        }
    }
}

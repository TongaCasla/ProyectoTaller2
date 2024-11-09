using Microsoft.IdentityModel.Tokens;
using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using PharmaSuite.Vistas.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaSuite.Vistas.Reportes
{
    public partial class ListaEmpleados : Form
    {
        public Persona empleadoSeleccionado { get; private set; }

        public ListaEmpleados()
        {
            InitializeComponent();
            this.cargarEmpleados();
        }
        private void cargarEmpleados()
        {
            QueryPersona query = new QueryPersona();
            QueryUsuario queryU = new();
            List<Persona> lista = query.listaPersona();

            foreach (Persona ps in lista)
            {
                if (ps.IdPerfil == 2)
                {
                    dataGridView1.Rows.Add(ps.Dni, ps.Nombre, ps.Apellido);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            QueryPersona qp = new();
            if (txbBusqueda.Text.IsNullOrEmpty())
            {
                MessageBox.Show("No se puede ingresar campos vacíos.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txbBusqueda.Text, out int id))
            {
                MessageBox.Show("Número de DNI incorrecto.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            int dniEmpl = int.Parse(txbBusqueda.Text);
            Persona p;
            p = qp.bucarDni(dniEmpl);
            if (p != null)
            {
                this.empleadoSeleccionado = p;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontró el empleado.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DbPharmaSuiteContext cn = new DbPharmaSuiteContext();
            QueryPersona query = new QueryPersona();
            QueryUsuario qu = new();
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

            if (e.RowIndex >= 0)
            {
                int dni = int.Parse(selectedRow.Cells["Dni"].Value.ToString());
                Persona ps = cn.Personas.Where(u => u.Dni == dni).First();
                this.empleadoSeleccionado = ps;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

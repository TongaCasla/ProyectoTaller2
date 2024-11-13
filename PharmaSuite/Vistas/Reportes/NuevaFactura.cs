using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using PharmaSuite.Vistas.Usuarios;
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

namespace PharmaSuite.Vistas.Reportes
{
    public partial class NuevaFactura : Form
    {
        public NuevaFactura()
        {
            InitializeComponent();
            this.cargarVentas();
        }

        private void cargarVentas()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=CARLOS\\SQLEXPRESS01;Initial Catalog=db_PharmaSuite;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();

                    // Crear un SqlCommand para ejecutar el procedimiento almacenado
                    using (SqlCommand cmd = new SqlCommand("ListadoTodasVentas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        // Crear un SqlDataAdapter para llenar el DataTable con los datos
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        // Crear un DataTable para almacenar los resultados
                        DataTable dt = new DataTable();

                        // Llenar el DataTable con los resultados del procedimiento almacenado
                        da.Fill(dt);

                        // Asignar el DataTable como el origen de datos del DataGridView
                        dataGridView1.DataSource = dt;
                        dataGridView1.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DbPharmaSuiteContext cn = new DbPharmaSuiteContext();
            QueryVenta qv = new();
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                int nroVenta = int.Parse(selectedRow.Cells[0].Value.ToString());
                Venta venta = qv.buscarPorID(nroVenta);
                List<VentaDetalle> lista = qv.buscarVentaDetalle(nroVenta);

                DatosVenta dv = new(venta,lista);
                dv.ShowDialog();
            }
            
        }
    }
}

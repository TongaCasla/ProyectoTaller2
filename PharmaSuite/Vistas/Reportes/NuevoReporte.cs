using PharmaSuite.Modelo.DB;
using System.Data;
using System.Data.SqlClient;
using PharmaSuite.Vistas.Reportes;
using PharmaSuite.Vistas.Usuarios;
using PharmaSuite.Logica.Query;


namespace PharmaSuite.Vistas.Reportes
{
    public partial class NuevoReporte : Form
    {
        private Persona usuarioActual;
        private Persona empleadoSeleccionado;
        public NuevoReporte(Persona usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            this.verificarTipoUsuario();
            comboReporte.SelectedIndex = 0;
        }

        private void verificarTipoUsuario()
        {
            switch (this.usuarioActual.IdPerfil)
            {
                //Empleado
                case 2:
                    {
                        comboReporte.Items.Add("Cierre de caja");
                        comboReporte.Items.Add("Ventas realizadas");
                        break;
                    }
                //Administrador
                case 4:
                    {
                        comboReporte.Items.Add("Recaudación");
                        comboReporte.Items.Add("Producto más vendido");
                        comboReporte.Items.Add("Total ventas");
                        break;
                    }
                //Gerente
                case 3:
                    {
                        comboReporte.Items.Add("Lista de Clientes");
                        comboReporte.Items.Add("Lista de Empleados activos");
                        comboReporte.Items.Add("Productos por categoría");
                        comboReporte.Items.Add("Ventas por empleado");
                        break;
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";
            saveFileDialog.FileName = "archivo.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;

                MessageBox.Show("Archivo guardado en: " + rutaArchivo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostramos un mensaje y guardamos la respuesta
            DialogResult ask = MessageBox.Show(
                "¿Seguro que desea eliminar el reporte existente?",
                "Eliminar reporte",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ask == DialogResult.Yes)
            {
                dataGridView1.Hide();
            }
            lreporte.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboReporte.SelectedItem.ToString() == "Ventas por empleado")
            {
                using (ListaEmpleados seleccionEmpl = new())
                {
                    if (seleccionEmpl.ShowDialog() == DialogResult.OK)
                    {
                        // Obtener el empleado seleccionado del Form B
                        this.empleadoSeleccionado = seleccionEmpl.empleadoSeleccionado;
                    }
                }
                this.cargarReporteConParametro(this.verificarReporte(comboReporte.SelectedItem.ToString()), this.empleadoSeleccionado);
            }
            else
            {

                //MessageBox.Show(comboReporte.SelectedItem.ToString());
                DateOnly fechaInicio = DateOnly.FromDateTime(dateInicio.Value);
                DateOnly fechaFin = DateOnly.FromDateTime(dateFin.Value);
                this.cargarReporte(verificarReporte(comboReporte.SelectedItem.ToString()));
            }
        }

        private string verificarReporte(string opcionSeleccionada)
        {
            string acceso = opcionSeleccionada switch
            {
                "Lista de Clientes" => "ListaClientes",
                "Lista de Empleados activos" => "ListaEmpleadosActivos",
                "Productos por categoría" => "ListaProductosPorCategoria",
                "Ventas por empleado" => "ListaVentasEmpleado",
                _ => "Sin acceso"
            };

            return acceso;

        }
        private void cargarReporteConParametro(string procedimientoSeleccionado, Persona usuario)
        {
            lreporte.Hide();
            dataGridView1.Show();
            using (SqlConnection conn = new SqlConnection("Data Source=CARLOS\\SQLEXPRESS01;Initial Catalog=db_PharmaSuite;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();

                    // Crear un SqlCommand para ejecutar el procedimiento almacenado
                    using (SqlCommand cmd = new SqlCommand(procedimientoSeleccionado, conn))
                    {
                        QueryUsuario qu = new();
                        Usuario u = qu.buscarPorIdPers(usuario.IdPersona);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_empleado", u.IdUsuario);


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

        private void cargarReporte(string procedimientoSeleccionado)
        {
            lreporte.Hide();
            dataGridView1.Show();
            using (SqlConnection conn = new SqlConnection("Data Source=CARLOS\\SQLEXPRESS01;Initial Catalog=db_PharmaSuite;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();

                    // Crear un SqlCommand para ejecutar el procedimiento almacenado
                    using (SqlCommand cmd = new SqlCommand(procedimientoSeleccionado, conn))
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
        /*
        private void guardarPdf()
        {

            // Supongamos que tienes un DataGridView llamado "dataGridView1"

            IronPdf.PdfDocument pdf = new PdfDocument();
            PdfTable table = new PdfTable();

            // Configuración del tamaño y estilo de la tabla
            table.SetWidth(PageSize.A4.Width);
            table.SetHeight(PageSize.A4.Height);
            table.SetBorderWidth(1);
            table.SetBorderColor(Color.Black);

            // Poblar la tabla con los datos del DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                table.AddRow();
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    table.AddCell(row.Cells[column.Index].Value.ToString());
                }
            }

            // Agregar la tabla al documento PDF
            pdf.AddPage(table);

            // Guardar el archivo PDF
            pdf.SaveAs("dataGridView1.pdf");
        }*/

        private void btnImp_Click(object sender, EventArgs e)
        {
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

    }
}

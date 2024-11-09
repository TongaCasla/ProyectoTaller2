using PharmaSuite.Modelo.DB;
using System.Data;
using System.Data.SqlClient;
using PharmaSuite.Vistas.Reportes;
using PharmaSuite.Vistas.Usuarios;
using PharmaSuite.Logica.Query;
using System.Drawing.Printing;
using System.Reflection.Metadata;
using System.Windows.Forms;
using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Globalization;



namespace PharmaSuite.Vistas.Reportes
{
    public partial class NuevoReporte : Form
    {
        private Persona usuarioActual;
        private Persona empleadoSeleccionado;
        private Categoria categoriaSeleccionada;
        private String reporteActual;
        public NuevoReporte(Persona usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            this.verificarTipoUsuario();
            comboReporte.SelectedIndex = 0;
            if (this.verificarReporte(comboReporte.SelectedItem.ToString()) != "ListaVentasPorFecha")
            {
                dateInicio.Enabled = false;
                dateFin.Enabled = false;
            }
            else
            {
                dateInicio.Enabled=true;
                dateFin.Enabled=true;
            }
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
                        comboReporte.Items.Add("Margen de Ganancia por Producto");
                        break;
                    }
                //Gerente
                case 3:
                    {
                        comboReporte.Items.Add("Lista de Clientes");
                        comboReporte.Items.Add("Lista de Empleados activos");
                        comboReporte.Items.Add("Productos por categoría");
                        comboReporte.Items.Add("Ventas por empleado");
                        comboReporte.Items.Add("Ventas por fecha");
                        comboReporte.Items.Add("Productos con stock bajo");
                        comboReporte.Items.Add("Productos próximos a vencer");
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
            string fechaInicio = DateOnly.FromDateTime(dateInicio.Value).ToString();
            string fechaFin = DateOnly.FromDateTime(dateFin.Value).ToString();

            switch (comboReporte.SelectedItem.ToString())
            {
                case "Ventas por empleado":
                    {
                            // Abre el formulario modal para seleccionar el empleado
                            using (ListaEmpleados seleccionEmpl = new ListaEmpleados())
                            {
                                // Si el usuario selecciona un empleado y confirma con OK
                                if (seleccionEmpl.ShowDialog() == DialogResult.OK)
                                {
                                    // Obtener el empleado seleccionado del Form B (ListaEmpleados)
                                    this.empleadoSeleccionado = seleccionEmpl.empleadoSeleccionado;
                                    this.cargarReporteConParametro(this.verificarReporte(comboReporte.SelectedItem.ToString()), this.empleadoSeleccionado);
                                }
                                else
                                {
                                    // Si el usuario cancela la selección, 
                                    MessageBox.Show("No se seleccionó ningún empleado.");
                                    return; 
                                }
                            }
                        break;
                    }
                case "Ventas realizadas":
                    {
                        this.cargarReporteConParametro(this.verificarReporte(comboReporte.SelectedItem.ToString()), usuarioActual);
                        break;
                    }

                case "Ventas por fecha":
                    {
                        this.cargarReporteConFecha(this.verificarReporte(comboReporte.SelectedItem.ToString()), fechaInicio,fechaFin);

                        break;
                    }
                
                default:
                    {
                        this.cargarReporte(verificarReporte(comboReporte.SelectedItem.ToString()));
                        break;
                    }
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
                "Ventas por fecha" => "ListaVentasPorFecha",
                "Productos con stock bajo" => "ListaProductosStockBajo",
                "Ventas realizadas" => "ListaVentasIndividual",
                "Recaudación" => "Recaudacion",
                "Cierre de caja" => "CierreCaja",
                "Margen de Ganancia por Producto" => "GananciaPorProducto",
                _ => "Sin acceso"
            };

            return acceso;

        }
        private void cargarReporteConFecha(string procedimientoSeleccionado, string fechaInicio, string fechaFin)
        {
            this.reporteActual = procedimientoSeleccionado;
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
                        cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fecha_fin", fechaFin);


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
        private void cargarReporteConParametro(string procedimientoSeleccionado, Persona usuario)
        {
            this.reporteActual = procedimientoSeleccionado;
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
            this.reporteActual = procedimientoSeleccionado;
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


        private void btnImp_Click(object sender, EventArgs e)
        {
            //Obtenemos la fecha y hora actual segun nuestro formato
            string fechaActual = DateTime.Now.ToString("dd-MM-yyyy");
            string horaActual = DateTime.Now.ToString("h.mm.ss tt").Replace(" p.m.", " PM").Replace(" a.m.", " AM");


            // Crear el documento PDF
            iTextSharp.text.Document pdfDoc = new(PageSize.A4.Rotate(), 56.7f, 56.7f, 56.7f, 56.7f);
                

            try
            {
                // Seleccionar la ruta y el nombre del archivo PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                //Creamos el nombre del archivo
                //Formato esperado: ListaClientes 03-11-2024 10.57.11 PM.pdf
                saveFileDialog.FileName = reporteActual+" "+fechaActual+" "+ horaActual +".pdf";


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Crear un writer para escribir el archivo PDF
                    PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));

                    // Abrir el documento para añadir contenido
                    pdfDoc.Open();

                    // Crear una tabla PDF con el número de columnas del DataGridView
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);

                    // Añadir los encabezados del DataGridView a la tabla
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                        {
                            BackgroundColor = new BaseColor(187, 222, 251) // Color  para los encabezados
                        };
                        pdfTable.AddCell(cell);
                    }

                    // Añadir las filas del DataGridView a la tabla
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }
                    }

                    // Añadir la tabla al documento PDF
                    pdfDoc.Add(pdfTable);

                    // Cerrar el documento
                    pdfDoc.Close();

                    //Mostramos el mensaje de correctamente
                    MessageBox.Show("Reporte guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //Mostramos mensaje de error si no se pudo generar
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
        }

       
    }
}


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
using System.Reflection;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



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
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.desactivarOpciones();

        }

        private void desactivarOpciones()
        {
            if (this.verificarReporte(comboReporte.SelectedItem.ToString()) == "ListaVentasPorFecha" || this.verificarReporte(comboReporte.SelectedItem.ToString()) == "Recaudacion")
            {
                dateInicio.Enabled = true;
                dateFin.Enabled = true;
            }
            else
            {
                dateInicio.Enabled = false;
                dateFin.Enabled = false;
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
                        comboReporte.Items.Add("Margen de ganancia");
                        comboReporte.Items.Add("Recaudación mensual");
                        comboReporte.Items.Add("Ventas por empleado");
                        comboReporte.Items.Add("Ventas por fecha");
                        break;
                    }
                //Gerente
                case 3:
                    {
                        comboReporte.Items.Add("Lista de clientes");
                        comboReporte.Items.Add("Lista de empleados activos");
                        comboReporte.Items.Add("Productos por categoría");
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
                case "Recaudación mensual":
                    {
                        this.cargarReporteConFecha(this.verificarReporte(comboReporte.SelectedItem.ToString()), fechaInicio, fechaFin);
                        break;
                    }
                case "Cierre de caja":
                    {
                        this.cargarReporteConParametro(this.verificarReporte(comboReporte.SelectedItem.ToString()), usuarioActual);
                        break;
                    }
                case "Ventas realizadas":
                    {
                        this.cargarReporteConParametro(this.verificarReporte(comboReporte.SelectedItem.ToString()), usuarioActual);
                        break;
                    }

                case "Ventas por fecha":
                    {
                        this.cargarReporteConFecha(this.verificarReporte(comboReporte.SelectedItem.ToString()), fechaInicio, fechaFin);

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
                "Lista de clientes" => "ListaClientes",
                "Lista de empleados activos" => "ListaEmpleadosActivos",
                "Productos por categoría" => "ListaProductosPorCategoria",
                "Ventas por empleado" => "ListaVentasEmpleado",
                "Ventas por fecha" => "ListaVentasPorFecha",
                "Productos con stock bajo" => "ListaProductosStockBajo",
                "Productos próximos a vencer" => "ProductosProximosAVencer",
                "Ventas realizadas" => "ListaVentasIndividual",
                "Recaudación mensual" => "Recaudacion",
                "Cierre de caja" => "CierreCaja",
                "Margen de ganancia" => "GananciaPorProducto",
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

        private void crearEncabezadoReporte()
        {
            // Obtener la fecha y hora actual según nuestro formato
            string fechaActual = DateTime.Now.ToString("dd-MM-yyyy");
            string horaActual = DateTime.Now.ToString("h.mm.ss tt").Replace(" p.m.", " PM").Replace(" a.m.", " AM");

            // Crear el documento PDF
            iTextSharp.text.Document pdfDoc = new(PageSize.A4.Rotate(), 30f, 10f, 10f, 10f);
            try
            {
                // Seleccionar la ruta y el nombre del archivo PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = reporteActual + " " + fechaActual + " " + horaActual + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Crear un writer para escribir el archivo PDF
                    PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));

                    // Abrir el documento para añadir contenido
                    pdfDoc.Open();

                    // Crear una tabla con 2 columnas para el encabezado
                    PdfPTable table = new PdfPTable(2);
                    table.WidthPercentage = 100; // Ancho al 100% del documento
                    float[] columnWidths = { 2f, 3f }; // Definir el ancho de las columnas (relación 2:3)
                    table.SetWidths(columnWidths);

                    // 1. Cargar y agregar la imagen (logo)
                    using (Stream inputStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("PharmaSuite.Vistas.Reportes.logo.png"))
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(inputStream);
                        //logo.ScaleToFit(222f, 112.5f); // Ajustar tamaño de la imagen
                        logo.ScaleToFit(300f, 150f); // Ajustar tamaño de la imagen
                        logo.Alignment = iTextSharp.text.Image.ALIGN_LEFT;
                        PdfPCell imageCell = new PdfPCell(logo);
                        imageCell.Border = PdfPCell.NO_BORDER; // Sin borde
                        imageCell.VerticalAlignment = Element.ALIGN_MIDDLE; // Alinear verticalmente
                        table.AddCell(imageCell); // Agregar la celda con la imagen a la tabla
                    }

                    // 2. Crear el texto alineado a la derecha
                    // Usamos un Paragraph con frases en negrita para simular lo que se muestra en la imagen
                    Paragraph text = new Paragraph();
                    text.Add(new Chunk("Reporte: " + this.reporteActual + "\n", FontFactory.GetFont("Arial", "24", Font.Bold)));
                    text.Add(new Chunk("Razón social: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    text.Add(new Chunk("PharmaSuite C.A\n", FontFactory.GetFont("Arial", 12)));
                    text.Add(new Chunk("Domicilio comercial: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    text.Add(new Chunk("Santa Fe 4500 - Corrientes, Corrientes\n", FontFactory.GetFont("Arial", 12)));
                    text.Add(new Chunk("Teléfono: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    text.Add(new Chunk("3795 152229\n", FontFactory.GetFont("Arial", 12)));
                    text.Add(new Chunk("\nFecha de emisión: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    string fechaEmision = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                    text.Add(new Chunk(fechaEmision + "\n", FontFactory.GetFont("Arial", 12)));
                    text.Add(new Chunk("Nombre empleado: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    string nombreCompletoEmpleado = this.usuarioActual.Nombre.ToString() + " " + this.usuarioActual.Apellido.ToString();
                    string cargoEmpleado;
                    if (this.usuarioActual.IdPerfil == 2)
                    {
                        cargoEmpleado = "Empleado";
                    }
                    else if (this.usuarioActual.IdPerfil == 3)
                    {
                        cargoEmpleado = "Gerente";
                    }
                    else
                    {
                        cargoEmpleado = "Administrador";
                    }
                    text.Add(new Chunk(nombreCompletoEmpleado + " - " + cargoEmpleado + "\n", FontFactory.GetFont("Arial", 12)));
                    text.Add(new Chunk("DNI empleado: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    string dniEmpleado = this.usuarioActual.Dni.ToString();
                    text.Add(new Chunk(dniEmpleado + "\n", FontFactory.GetFont("Arial", 12)));


                    PdfPCell textCell = new PdfPCell(text);
                    textCell.Border = PdfPCell.NO_BORDER; // Sin borde
                    textCell.HorizontalAlignment = Element.ALIGN_LEFT; // Alineación horizontal a la izquierda
                    textCell.VerticalAlignment = Element.ALIGN_MIDDLE; // Alinear verticalmente
                    table.AddCell(textCell); // Agregar la celda con el texto a la tabla
                    table.SpacingAfter = 25f;
                    // 3. Añadir la tabla completa al documento
                    pdfDoc.Add(table);

                    // Crear una tabla PDF con el número de columnas del DataGridView
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);

                    // Añadir los encabezados del DataGridView a la tabla
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                        {
                            BackgroundColor = new BaseColor(187, 222, 251) // Color para los encabezados
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
                    pdfDoc.Add(pdfTable);
                    // Cerrar el documento
                    pdfDoc.Close();
                    // Mostrar el mensaje de éxito
                    MessageBox.Show("Reporte guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Manejar el error
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
        }
        private void btnImp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                this.crearEncabezadoReporte();
            }
            else
            {
                MessageBox.Show("Primero seleccione un reporte de la lista");
            }
        }
        private void comboReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.desactivarOpciones();
        }

    }
}


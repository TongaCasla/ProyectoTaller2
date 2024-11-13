using iTextSharp.text.pdf;
using iTextSharp.text;
using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaSuite.Vistas.Reportes
{
    public partial class DatosVenta : Form
    {
        private Venta venta;
        private List<VentaDetalle> detalles;
        public DatosVenta(Venta venta, List<VentaDetalle> lista)
        {
            InitializeComponent();
            this.venta = venta;
            dataGridView1.Columns["sub"].DefaultCellStyle.Format = "C2"; // C2 para formato de moneda con 2 decimales
            dataGridView1.Columns["sub"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("es-AR");

            this.cargarVentaDetalle(lista);
            this.asignarValoresVentaCabecera(venta);
            this.Text = "Datos venta nro. " + venta.IdVenta;
        }

        private void cargarVentaDetalle(List<VentaDetalle> lista)
        {
            foreach (VentaDetalle c in lista)
            {
                QueryProducto qp = new();
                Producto p = qp.buscarCodBarra(c.CodBarra);

                dataGridView1.Rows.Add(c.CodBarra, p.NombreProd, c.Cantidad, c.Subtotal);
            }
        }

        private void asignarValoresVentaCabecera(Venta v)
        {
            QueryUsuario qu = new();
            QueryPersona qp = new();
            Usuario u = qu.buscarPorId(v.IdUsuario);
            Persona empleado = qp.bucarPorId(u.IdPersona);
            Persona cliente = qp.bucarPorId((int)v.Cliente);
            nroVenta.Text = v.IdVenta.ToString();
            fechaVta.Text = v.FechaVta.ToString();
            emplVta.Text = "" + empleado.Nombre + " " + empleado.Apellido;
            clienteVta.Text = "" + cliente.Nombre + " " + cliente.Apellido;
            string formaDePago = "";
            if (v.IdFormapago == 1)
            {
                formaDePago = "Efectivo";
            }
            else if (v.IdFormapago == 2)
            {
                formaDePago = "Débito";
            }
            else
            {
                formaDePago = "Transferencia";
            }

            formaPago.Text = formaDePago;
            totalVenta.Text += v.Total.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            this.crearFactura();
        }
        private void crearFactura()
        {
            // Obtener la fecha y hora actual según nuestro formato
            string fechaActual = this.venta.FechaVta.ToString();
            //string horaActual = DateTime.Now.ToString("h.mm.ss tt").Replace(" p.m.", " PM").Replace(" a.m.", " AM");

            // Crear el documento PDF
            iTextSharp.text.Document pdfDoc = new(PageSize.A4, 10f, 10f, 10f, 10f);
            try
            {
                // Seleccionar la ruta y el nombre del archivo PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "PharmaSuite-Factura-Nro" + this.venta.IdVenta + ".pdf";

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
                        logo.ScaleToFit(200f, 100f); // Ajustar tamaño de la imagen
                        logo.Alignment = iTextSharp.text.Image.ALIGN_LEFT;
                        PdfPCell imageCell = new PdfPCell(logo);
                        imageCell.Border = PdfPCell.NO_BORDER; // Sin borde
                        imageCell.VerticalAlignment = Element.ALIGN_MIDDLE; // Alinear verticalmente
                        table.AddCell(imageCell); // Agregar la celda con la imagen a la tabla
                    }

                    // 2. Crear el texto alineado a la derecha
                    // Usamos un Paragraph con frases en negrita para simular lo que se muestra en la imagen
                    Paragraph text = new Paragraph();
                    text.Add(new Chunk("Factura Nro: " + this.venta.IdVenta + "\n", FontFactory.GetFont("Arial", "24", Font.Bold)));
                    text.Add(new Chunk("Razón social: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    text.Add(new Chunk("PharmaSuite C.A\n", FontFactory.GetFont("Arial", 12)));
                    text.Add(new Chunk("Domicilio comercial: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    text.Add(new Chunk("Santa Fe 4500 - Corrientes, Corrientes\n", FontFactory.GetFont("Arial", 12)));
                    text.Add(new Chunk("Teléfono: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    text.Add(new Chunk("3795 152229\n", FontFactory.GetFont("Arial", 12)));
                    text.Add(new Chunk("\nFecha: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    text.Add(new Chunk(fechaActual + "\n", FontFactory.GetFont("Arial", 12)));
                    text.Add(new Chunk("Nombre empleado: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    text.Add(new Chunk(emplVta.Text+ "\n", FontFactory.GetFont("Arial", 12)));
                    text.Add(new Chunk("Nombre Cliente: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    text.Add(new Chunk(clienteVta.Text + "\n", FontFactory.GetFont("Arial", 12)));
                    text.Add(new Chunk("Forma de pago: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    text.Add(new Chunk(formaPago.Text + "\n", FontFactory.GetFont("Arial", 12)));
                    text.Add(new Chunk("Total: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    text.Add(new Chunk(totalVenta.Text + "\n", FontFactory.GetFont("Arial", 12)));


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
                            BackgroundColor = new BaseColor(251, 251, 251) // Color para los encabezados
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
    }
}

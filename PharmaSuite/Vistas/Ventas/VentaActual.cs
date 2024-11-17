using Microsoft.IdentityModel.Tokens;
using PharmaSuite.Logica;
using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas;
using System.Globalization;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;

// Formato de moneda de Argentina

namespace PharmaSuite.Vistas.Ventas
{
    public partial class VentaActual : Form
    {
        private Persona usuarioActual;
        private Persona clienteVenta;
        private Producto productoActual;
        private List<VentaDetalle> listaVentaDetalle = new List<VentaDetalle>();

        public VentaActual(Persona usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            if (dataGridView1.Rows.Count > 0)
            {
                ltablavacia.Show();
            }
            else
            {
                ltablavacia.Hide();
            }


        }
        public void setCliente(Persona cliente)
        {
            this.clienteVenta = cliente;
            lnrodni.Text = clienteVenta.Dni.ToString();
            lnomyape.Text = clienteVenta.Nombre;
            lnrodni.Show();
            lnomyape.Show();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            this.busquedaProducto(TBCodigoprod.Text);
        }


        private void busquedaProducto(string cadena)
        {
            QueryProducto qp = new();
            List<Producto> products = qp.listaNombreCodBarra(cadena);
            if (string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show("No se puede ingresar campos vacíos.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else if (products.Count == 0)
            {
                MessageBox.Show("No existe producto",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                foreach (Producto producto in products)
                {
                    dataGridView2.Rows.Add(producto.NombreProd);
                }
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QueryProducto qp = new();

            if (e.RowIndex < 0) return;
            DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.productoActual = qp.buscarNombre(selectedRow.Cells["nombreProductoBuscado"].Value.ToString());
                lprecio.Text = productoActual.PrecioVenta.ToString();
                lStock.Text = productoActual.Stock.ToString();
                lproducto.Text = productoActual.NombreProd;
                lventalibre.Text = productoActual.VentaLibre;
                lCategoria.Text = productoActual.IdCategoria.ToString();
                lprecio.Show();
                lStock.Show();
                lproducto.Show();
                lventalibre.Show();
                lCategoria.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validacion val = new();

            if (!val.EsNumero(lStock.Text))
            {
                MessageBox.Show("Error, no se puede agregar el producto",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            else
            {
                DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
                Producto producto = dc.Productos.Where(u => u.CodBarra == this.productoActual.CodBarra).First();
                int cantidadProductoAComprar = int.Parse(cantidadProductoSelec.Value.ToString());
                if (cantidadProductoAComprar > producto.Stock)
                {
                    MessageBox.Show("No hay stock suficiente.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    producto.Stock = producto.Stock - cantidadProductoAComprar;
                    lStock.Text = producto.Stock.ToString();
                    dc.SaveChanges();
                    this.agregarProductoAVenta(this.productoActual, cantidadProductoAComprar);
                }
            }

        }

        private void agregarProductoAVenta(Producto p, int cantidad)
        {
            VentaDetalle ventaActual = new();
            ventaActual.CodBarra = p.CodBarra;
            ventaActual.Cantidad = cantidad;
            ventaActual.Subtotal = (cantidad * p.PrecioVenta);
            this.listaVentaDetalle.Add(ventaActual);
            dataGridView1.Rows.Add(p.NombreProd, cantidad, p.PrecioVenta, (cantidad * p.PrecioVenta), "Borrar");
            totalVenta.Text = this.calcularTotal().ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));
        }

        private double calcularTotal()
        {
            double total = 0;
            foreach (VentaDetalle v in listaVentaDetalle)
            {
                total += v.Subtotal;
            }
            return total;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if ((dataGridView1.Columns[e.ColumnIndex].Name == "Precio") || (dataGridView1.Columns[e.ColumnIndex].Name == "Subtotal"))
            {
                // Verifica que la celda no esté vacía
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal precio))
                {
                    // Aplica el formato de moneda
                    e.Value = precio.ToString("C2");
                    e.FormattingApplied = true;
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Borrar")
            {
                DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
                Producto producto = dc.Productos.Where(u => u.CodBarra == this.listaVentaDetalle[e.RowIndex].CodBarra).First();
                producto.Stock = producto.Stock + this.listaVentaDetalle[e.RowIndex].Cantidad;
                lStock.Text = producto.Stock.ToString();
                dc.SaveChanges();
                this.listaVentaDetalle.RemoveAt(e.RowIndex);
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("Se eliminó correctamente",
                "Aceptar",
                MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                totalVenta.Text = this.calcularTotal().ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show(
                "¿Desea cancelar la venta actual?",
                "Cancelar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ask == DialogResult.Yes)
            {
                DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
                foreach (VentaDetalle vd in this.listaVentaDetalle)
                {
                    Producto producto = dc.Productos.Where(u => u.CodBarra == vd.CodBarra).First();
                    producto.Stock = producto.Stock + vd.Cantidad;
                    dc.SaveChanges();

                }
                this.listaVentaDetalle.Clear();
                dataGridView1.Rows.Clear();
                MessageBox.Show("Se eliminó correctamente el carrito",
                "Aceptar",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Information);



            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show(
               "¿Confirmar compra?",
               "Confirmar compra",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ask == DialogResult.Yes)
            {
                DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
                Venta venta = new Venta();
                venta.IdUsuario = dc.Usuarios.Where(u => u.IdPersona == this.usuarioActual.IdPersona).First().IdUsuario;
                //verificar que haya un cliente
                venta.Cliente = this.clienteVenta.IdPersona;
                venta.Total = this.calcularTotal();
                venta.IdFormapago = this.formaPago();
                dc.Venta.Add(venta);
                dc.SaveChanges();
                int idventa = dc.Venta.OrderByDescending(u => u.IdVenta).First().IdVenta;
                foreach (VentaDetalle vd in listaVentaDetalle)
                {
                    vd.IdVenta = idventa;
                    dc.VentaDetalles.Add(vd);
                    dc.SaveChanges();
                }
                
                MessageBox.Show("Se realizo la venta con éxito",
                "Aceptar",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                this.generarFactura(idventa);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario(this, false);
            nuevoUsuario.Text = "Nuevo cliente";
            nuevoUsuario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusquedaCliente busqueda = new(this);
            busqueda.ShowDialog();
            if (clienteVenta != null)
            {
                CKBConsumidorFinal.Enabled = false;
            }


        }

        private void CKBConsumidorFinal_CheckedChanged(object sender, EventArgs e)
        {
            QueryPersona qp = new QueryPersona();
            this.setCliente(qp.bucarPorId(2));
        }

        private int formaPago() 
        {
            int i = 0;
            if (RBEfectivo.Checked)
            {
                i = 1;
            }else if (RBDebito.Checked)
            {
                i = 2;
            } else if (RBTransferencia.Checked) 
            {
                i = 3;
            }
            return i;
        }


        private void generarFactura(int idventa)
        {
            QueryVenta qv = new();
            Venta v = qv.buscarPorID(idventa);
            // Obtener la fecha y hora actual según nuestro formato
            string fechaActual = v.FechaVta.ToString();
                //string horaActual = DateTime.Now.ToString("h.mm.ss tt").Replace(" p.m.", " PM").Replace(" a.m.", " AM");

                // Crear el documento PDF
                iTextSharp.text.Document pdfDoc = new(PageSize.A4, 10f, 10f, 10f, 10f);
                try
                {
                    // Seleccionar la ruta y el nombre del archivo PDF
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                    saveFileDialog.FileName = "PharmaSuite-Factura-Nro" + idventa + ".pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Crear un writer para escribir el archivo PDF
                        iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));

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
                        iTextSharp.text.Paragraph text = new();
                        text.Add(new Chunk("Factura Nro: " + idventa + "\n", FontFactory.GetFont("Arial", "24", Font.Bold)));
                        text.Add(new Chunk("Razón social: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                        text.Add(new Chunk("PharmaSuite C.A\n", FontFactory.GetFont("Arial", 12)));
                        text.Add(new Chunk("Domicilio comercial: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                        text.Add(new Chunk("Santa Fe 4500 - Corrientes, Corrientes\n", FontFactory.GetFont("Arial", 12)));
                        text.Add(new Chunk("Teléfono: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                        text.Add(new Chunk("3795 152229\n", FontFactory.GetFont("Arial", 12)));
                        text.Add(new Chunk("\nFecha: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                        text.Add(new Chunk(fechaActual + "\n", FontFactory.GetFont("Arial", 12)));
                        text.Add(new Chunk("Nombre empleado: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                        text.Add(new Chunk(usuarioActual.Nombre.ToString() + " " + usuarioActual.Apellido.ToString() + "\n", FontFactory.GetFont("Arial", 12)));
                        text.Add(new Chunk("Nombre Cliente: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                        text.Add(new Chunk(clienteVenta.Nombre.ToString() + " " + clienteVenta.Apellido.ToString() + "\n", FontFactory.GetFont("Arial", 12)));
                    text.Add(new Chunk("DNI Cliente: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    text.Add(new Chunk(clienteVenta.Dni.ToString() + "\n", FontFactory.GetFont("Arial", 12)));


                    text.Add(new Chunk("Forma de pago: ", FontFactory.GetFont("Arial", "18", Font.Bold)));
                    string formaDePago = "";
                    if (this.formaPago() == 1)
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
                    text.Add(new Chunk(formaDePago + "\n", FontFactory.GetFont("Arial", 12)));
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

                        // Crear una tabla PDF con el número de columnas necesarias
                        PdfPTable pdfTable = new PdfPTable(4);
                    //Creamos los header que usaremos
                    PdfPCell headerNombre = new PdfPCell(new Phrase("Nombre Producto"));
                    PdfPCell headerCantidad = new PdfPCell(new Phrase("Cantidad"));
                    PdfPCell headerPrecio = new PdfPCell(new Phrase("Precio"));
                    PdfPCell headerSubtotal = new PdfPCell(new Phrase("Subtotal"));
                    pdfTable.AddCell(headerNombre);
                    pdfTable.AddCell(headerCantidad);
                    pdfTable.AddCell(headerPrecio);
                    pdfTable.AddCell(headerSubtotal);
                    QueryProducto qp = new();
                    // Añadir las filas de la venta a la tabla
                    foreach (VentaDetalle venta in listaVentaDetalle)
                        {
                        Producto p = qp.buscarCodBarra(venta.CodBarra);
                          pdfTable.AddCell(p.NombreProd.ToString());
                          pdfTable.AddCell(venta.Cantidad.ToString());
                          pdfTable.AddCell(p.PrecioVenta.ToString());
                          pdfTable.AddCell(venta.Subtotal.ToString());
                        }
                        pdfDoc.Add(pdfTable);
                        // Cerrar el documento
                        pdfDoc.Close();
                        // Mostrar el mensaje de éxito
                        MessageBox.Show("Factura guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

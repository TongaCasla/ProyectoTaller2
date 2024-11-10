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
using iTextSharp.tool.xml;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Html2pdf;

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

                //this.generarFactura(idventa);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario(this, false);
            nuevoUsuario.Text = "Nuevo cliente";
            nuevoUsuario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusquedaCliente busqueda = new(this);
            busqueda.Show();
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

        /*
        private void generarFactura(int idventa)
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            SaveFileDialog factura= new SaveFileDialog();
            string nombreArchivo = idventa.ToString()+"-"+ DateTime.Now.ToString("ddMMyyyyHHmmss");
            factura.FileName = string.Format("{0}.pdf",nombreArchivo);

            string PlantillaHTML = Properties.Resources.Factura;
            string cliente = this.clienteVenta.Nombre + " " + this.clienteVenta.Apellido;
            PlantillaHTML = PlantillaHTML.Replace("@CLIENTE",cliente);
            PlantillaHTML = PlantillaHTML.Replace("@DOCUMENTO", this.clienteVenta.Dni.ToString());
            PlantillaHTML = PlantillaHTML.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            foreach (VentaDetalle vd in this.listaVentaDetalle)
            {
                Producto prod= dc.Productos.First(d => d.CodBarra.Equals(vd.CodBarra));
                filas += "<tr>";
                filas += "<td>" + prod.NombreProd + "</td>";
                filas += "<td>" + vd.Cantidad.ToString() + "</td>";
                filas += "<td>" + prod.PrecioVenta.ToString() + "</td>";
                filas += "<td>" + vd.Subtotal + "</td>";
                filas += "</tr>";
                total += decimal.Parse(vd.Subtotal.ToString());
            }
            PlantillaHTML = PlantillaHTML.Replace("@FILAS", filas);
            PlantillaHTML = PlantillaHTML.Replace("@TOTAL", total.ToString());
            PlantillaHTML = PlantillaHTML.Replace("@idventa",idventa.ToString());


            if (factura.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(factura.FileName, FileMode.Create))
                {
                    
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    using (StringReader sr = new StringReader(PlantillaHTML))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }
        }
        */


    }

}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmaSuite.Vistas.Productos
{
    public partial class NuevoProducto : Form
    {
        public NuevoProducto()
        {
            InitializeComponent();
            this.cargarCategorias();
            this.cargarMedidas();
        }

        private void cargarCategorias()
        {
            QueryCategoria q = new();
            var categorias = q.mostrarActivas();
            // Consultar las categorías desde la base de datos usando Entity Framework

            // Asignar el origen de datos (lista de categorías) al ComboBox
            comboCategoria.DataSource = categorias;

            // Especificar el campo que se mostrará como texto en el ComboBox
            comboCategoria.DisplayMember = "Descripcion";

            // Especificar el campo que se usará como valor (id_categoria)
            comboCategoria.ValueMember = "IdCategoria";
        }
        private void cargarMedidas()
        {
            QueryMedidas q = new();
            var medidas = q.listaMedidas();
            comboMedida.DataSource = medidas;
            comboMedida.DisplayMember = "UnidadMedida";
            comboMedida.ValueMember = "IdMedida";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigoBarras = "";
            int longitudCod = 9;
            Random random = new Random();
            for (int i = 0; i < longitudCod; i++)
            {
                codigoBarras += random.Next(0, 10);
                // Genera un número aleatorio entre 0 y 9
            }

            txbCodProd.Text = codigoBarras;

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //this.mostraridcategoria();
            this.validarCampos();
        }

        private void validarCampos()
        {

            //Verificamos que ningun campo este vacio
            if (txbCodProd.Text.IsNullOrEmpty())
            {
                this.mostrarError("El Código del producto no puede estar vacío, por favor ingrese un número válido");
                return;
            }
            if (txbNombreProd.Text.IsNullOrEmpty())
            {
                this.mostrarError("El nombre del producto no puede estar vacío, por favor ingrese un nombre válido");
                return;
            }
            if (txbPrecLista.Text.IsNullOrEmpty())
            {
                this.mostrarError("El precio del producto no puede estar vacío, por favor ingrese un número válido");
                return;
            }
            if (txbPrecVenta.Text.IsNullOrEmpty())
            {
                this.mostrarError("El precio del producto no puede estar vacío, por favor ingrese un número válido");
                return;
            }
            if (txbPresentacion.Text.IsNullOrEmpty())
            {
                this.mostrarError("La cantidad de presentación no puede estar vacío, por favor ingrese un número válido");
                return;
            }
            double precioListaParseado;
            double precioVentaParseado;

            //Verificamos que los campos correspondientes sean numeros

            //Validamos el precio lista
            if (validarPrecio(txbPrecLista.Text))
            {
                precioListaParseado = double.Parse(txbPrecLista.Text.Replace(".", ","));

            }
            else
            {
                this.mostrarError("El precio del producto es incorrecto, por favor ingrese un número válido.");
                return;
            }

            //Validamos el precio de venta
            if (validarPrecio(txbPrecVenta.Text))
            {
                precioVentaParseado = double.Parse(txbPrecVenta.Text.Replace(".", ","));
            }
            else
            {
                this.mostrarError("El precio del producto no es correcto, por favor ingrese un número válido.");
                return;
            }

            //Validamos que la cantidad de presentacion sea correcta
            int cantidadPresentacion;

            bool esValidoCantPresentacion = int.TryParse(txbPresentacion.Text, out cantidadPresentacion);


            if (esValidoCantPresentacion)
            {
                if (cantidadPresentacion < 0)
                {
                    this.mostrarError("La cantidad de la presentación no es correcta, por favor ingrese un número válido");
                    return;
                }
            }
            else
            {
                this.mostrarError("La cantidad de la presentación es incorrecta, por favor ingrese un número válido.");
                return;

            }
            //Verificamos que los stocks no sean numeros negativos
            if (stockMax.Value < 0 || stockMin.Value < 0)
            {
                this.mostrarError("La cantidad del stock es incorrecta, por favor ingrese una cantidad válida");
                    return;
            }

            //Verificamos que el stock max no supere al minimo
            if (stockMax.Value < stockMin.Value)
            {
                this.mostrarError(
                    "El stock mínimo no puede ser menos que el máximo, por favor ingrese un stock válido."
                    );
                return;
            }

            // Pedimos confirmacion para agregar el producto 
            DialogResult ask = MessageBox.Show(
                "¿Desea agregar un nuevo producto?",
                "Agregar producto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //Agregamos el producto
            if (ask == DialogResult.Yes)
            {
                this.registrarProducto(precioListaParseado, precioVentaParseado, cantidadPresentacion);
                this.registrarMedida(cantidadPresentacion);
            }

        }

        private void registrarMedida(int cantidadPresentacion)
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            PresentacionProd m = new();
            m.IdProd = int.Parse(txbCodProd.Text);
            m.IdMedida = Convert.ToInt32(comboMedida.SelectedValue);
            m.Cantidad = cantidadPresentacion;
            dc.PresentacionProds.Add(m);
            dc.SaveChanges();
        }

        private bool validarPrecio(string texto)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^\d+(,\d{1,2})?$");
        }

        private void registrarProducto(double precioLista, double precioVenta, int cantidad)
        {

            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            Producto p = new();
            p.CodBarra = int.Parse(txbCodProd.Text);
            p.IdCategoria = Convert.ToInt32(comboCategoria.SelectedValue);
            p.NombreProd = txbNombreProd.Text;
            p.PrecioLista = precioLista;
            p.PrecioVenta = precioVenta;
            p.Stock = (int)stockMax.Value;
            p.StockMin = (int)stockMin.Value;
            p.FechaVencimiento = DateOnly.FromDateTime(dateFecha.Value);
            p.VentaLibre = ventaLibre();
            dc.Productos.Add(p);
            dc.SaveChanges();
            MessageBox.Show("Producto agregado correctamente!",
                   "Exito",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
        }

        private void mostrarError(string msg)
        {
            MessageBox.Show(msg,
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }
        private string ventaLibre()
        {
            string ventaLibre = "";
            if (VentaLibreSiBtn.Checked)
            {
                ventaLibre = "si";
            }
            else
            {
                ventaLibre = "no";
            }
            return ventaLibre;
        }
    }

}

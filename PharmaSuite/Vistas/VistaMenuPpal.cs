using PharmaSuite.Vistas;
using PharmaSuite.Vistas.Categorias;
using PharmaSuite.Vistas.Productos;
using PharmaSuite.Vistas.Reportes;
using PharmaSuite.Vistas.Usuarios;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using Vistas;




namespace Vistas
{
    public partial class VistaMenuPpal : Form
    {
        private bool isVisibleNavbarIzq = true;


        public VistaMenuPpal(String usuario)
        {
            InitializeComponent();
            labelUsuario.Text = usuario;

        }

        //Funcion para mostrar el panel correspondiente
        private void MostrarPanel(Panel panel)
        {
            // Oculta todos los paneles en pSuperior
            pSuperior.Controls.Clear();
            //Agrego el panel correspondiente
            pSuperior.Controls.Add(panel);
            //Asignamos que ocupe todo el ancho del contenedor
            panel.Dock = DockStyle.Fill;
            // Muestra el panel seleccionado
            panel.Visible = true;
        }


        private void btnDesplegable_Click(object sender, EventArgs e)
        {
            // Mostrar/ocultar el navbar 
            if (isVisibleNavbarIzq)
            {
                navbarIzq.Hide();
            }
            else
            {
                navbarIzq.Show();
            }
            // Cambiar el estado de visibilidad
            isVisibleNavbarIzq = !isVisibleNavbarIzq;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Mostramos un mensaje y guardamos la respuesta
            DialogResult ask = MessageBox.Show(
                "¿Seguro que desea cerrar sesión?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ask == DialogResult.Yes)
            {
                this.Hide();
                VistaLogin vistaLogin = new VistaLogin();
                vistaLogin.Show();
            }
        }
        //Metodo para agregar un nuevo form al fondo
        private void agregarNuevoForm(Form formAMostrar)
        {
            //Limpiamos nuestro panel
            pFondo.Controls.Clear();

            /*Codigo para mostrar nuevo form*/
            // Esto es necesario para que el formulario se comporte como un control.
            formAMostrar.TopLevel = false;
            // Opcional: hace que el formulario ocupe todo el panel.
            formAMostrar.Dock = DockStyle.Fill;
            //Quitamos los bordes
            formAMostrar.FormBorderStyle = FormBorderStyle.None;

            // Agregar el formulario hijo al panel y mostrarlo.
            pFondo.Controls.Add(formAMostrar);
            formAMostrar.Show();
        }

        //Metodo para limpiar fondo
        private void limpiarFondo()
        {
            pFondo.Controls.Clear();
        }


        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.MostrarPanel(pUsuarios);
            this.limpiarFondo();
        }
        //Codigos para modularizar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new NuevoUsuario());
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new MostrarTabla("Clientes"));
        }

        private void btnEmpl_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new MostrarTabla("Empleados"));

        }

        //Boton productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.MostrarPanel(pProductos);
            this.limpiarFondo();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.MostrarPanel(pVentas);
            this.limpiarFondo();
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new MostrarTabla("Productos"));
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {

            this.MostrarPanel(pCategorias);
            this.limpiarFondo();

        }

        private void btnMostrarCategorias_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new MostrarTabla("Categorías"));
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.MostrarPanel(pReportes);
            this.limpiarFondo();
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {
            this.MostrarPanel(pBackup);
            this.limpiarFondo();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new NuevaVenta());
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new NuevoProducto());
        }

        private void btnHistorialVentas_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new MostrarTabla("Ventas", false));
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new NuevaCategoria());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new NuevoReporte());
        }
    }
}

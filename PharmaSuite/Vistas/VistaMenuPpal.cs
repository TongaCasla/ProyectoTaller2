using PharmaSuite.Modelo.DB;
using PharmaSuite.Vistas;
using PharmaSuite.Vistas.Categorias;
using PharmaSuite.Vistas.Productos;
using PharmaSuite.Vistas.Reportes;
using PharmaSuite.Vistas.Usuarios;
using PharmaSuite.Vistas.Ventas;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using Vistas;




namespace Vistas
{
    public partial class VistaMenuPpal : Form
    {
        private bool isVisibleNavbarIzq = true;
        private Persona usuarioActual;
        private Button btnActivo;


        public VistaMenuPpal(Persona usuarioActual)
        {
            InitializeComponent();
            this.setUsuario(usuarioActual);
            this.verificarTipoUsuario(this.getUsuario());
            labelUsuario.Text = usuarioActual.Nombre;
        }
        
        private void setUsuario(Persona usuarioActual)
        {
            this.usuarioActual = usuarioActual;
        }
        public Persona getUsuario()
        {
            return this.usuarioActual;
        }

        //Metodo para habilitar/desactivar funciones segun perfil
        private void verificarTipoUsuario(Persona usuarioActual)
        {
            switch (usuarioActual.IdPerfil)
            {
                //Perfil Gerente 
                case 3:
                    {
                        btnNuevaCategoria.Enabled = false;
                        btnNuevaVenta.Enabled = false;
                        btnNuevoProducto.Enabled = false;
                        btnAgregarUsuario.Enabled = false;
                        btnBackup.Enabled = false;
                        labelTipoPerfil.Text = "Gerente";
                        break;
                    }
                //Perfil Empleado
                case 2:
                    {
                        btnAgregarUsuario.Enabled = false;
                        btnReportes.Enabled = false;
                        btnProductos.Enabled = false;
                        btnBackup.Enabled = false;
                        btnCategorias.Enabled = false;
                        btnHistorialVentas.Enabled = false;
                        labelTipoPerfil.Text = "Empleado";
                        break;

                    }
            }
        }
    
        
        //Metodo para mostrar el panel correspondiente
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
                //this.setUsuario(null);
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

        //Metodos para activar/desactivar botones
        private void activarBtn(object btnSender)
        {
            if (btnSender != null)
            {
                if (btnActivo != (Button)btnSender)
                {
                    this.desactivarBtn();
                    btnActivo= (Button)btnSender;
            btnActivo.BackColor = Color.FromArgb(147, 182, 211);
                    btnActivo.Font = new Font("Microsoft Sans Serif",19.75F);
                }
            }
        }
        private void desactivarBtn()
        {
            foreach(Control btnAnterior in navbarIzq.Controls)
            {
                if (btnAnterior.GetType() == typeof(Button))
                {
                    btnAnterior.BackColor = Color.FromArgb(187, 222, 251);
                    btnAnterior.Font = new Font("Microsoft Sans Serif", 18F);
                }
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.activarBtn(sender);
            this.MostrarPanel(pUsuarios);
            this.limpiarFondo();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new NuevoUsuario());
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new MostrarTabla("Clientes",this.getUsuario()));
        }

        //Boton productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.activarBtn(sender);
            this.MostrarPanel(pProductos);
            this.limpiarFondo();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.activarBtn(sender);
            this.MostrarPanel(pVentas);
            this.limpiarFondo();
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new MostrarTabla("Productos",this.getUsuario()));
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            this.activarBtn(sender);
            this.MostrarPanel(pCategorias);
            this.limpiarFondo();

        }

        private void btnMostrarCategorias_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new MostrarTabla("Categorías",this.getUsuario()));
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.activarBtn(sender);
            this.MostrarPanel(pReportes);
            this.limpiarFondo();
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {
            this.activarBtn(sender);
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
            this.agregarNuevoForm(new HistorialVentas());
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

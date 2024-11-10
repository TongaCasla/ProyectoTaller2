using PharmaSuite.Modelo.DB;
using PharmaSuite.Vistas;
using PharmaSuite.Vistas.Back_up;
using PharmaSuite.Vistas.Categorias;
using PharmaSuite.Vistas.Productos;
using PharmaSuite.Vistas.Reportes;
using PharmaSuite.Vistas.Usuarios;
using PharmaSuite.Vistas.Ventas;
using System.Diagnostics;
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
        private List<Button> botonesDesactivadosPermanente = new List<Button>();
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
                        this.desactivarBtn(btnNuevaVenta);
                        this.desactivarBtn(btnNuevoProducto);
                        this.desactivarBtn(btnAgregarUsuario);
                        labelTipoPerfil.Text = "Gerente";
                        break;
                    }
                //Perfil Empleado
                case 2:
                    {
                        this.desactivarBtnPermanentemente(btnAgregarUsuario);
                        this.desactivarBtnPermanentemente(btnProductos);
                        this.desactivarBtnPermanentemente(btnBackup);
                        this.desactivarBtnPermanentemente(btnCategorias);
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
        // Lista para guardar los botones deshabilitados permanentemente

        // Función para desactivar permanentemente un botón
        private void desactivarBtnPermanentemente(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.FromArgb(211, 211, 211);
            if (!botonesDesactivadosPermanente.Contains(btn))
            {
                botonesDesactivadosPermanente.Add(btn);
            }
        }

        // Función para desactivar un botón temporalmente
        private void desactivarBtn(Button btn)
        {
            if (!botonesDesactivadosPermanente.Contains(btn))
            {
                btn.Enabled = false;
                btn.BackColor = Color.FromArgb(176, 196, 222);
            }
        }

        // Función para activar el botón cuando se hace clic
        private void activarBtn(object btnSender)
        {
            if (btnSender != null)
            {
                if (btnActivo != (Button)btnSender && !botonesDesactivadosPermanente.Contains((Button)btnSender))
                {
                    this.desactivarBtn();
                    btnActivo = (Button)btnSender;
                    btnActivo.BackColor = Color.FromArgb(147, 182, 211);
                    btnActivo.Font = new Font("Microsoft Sans Serif", 19.75F);
                }
            }
        }

        // Función para desactivar todos los botones
        private void desactivarBtn()
        {
            foreach (Control btnAnterior in navbarIzq.Controls)
            {
                if (btnAnterior.GetType() == typeof(Button) && !botonesDesactivadosPermanente.Contains((Button)btnAnterior))
                {
                    btnAnterior.BackColor = Color.FromArgb(187, 222, 251);
                    btnAnterior.Font = new Font("Microsoft Sans Serif", 18F);
                }
            }
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
                this.setUsuario(null);
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
            this.agregarNuevoForm(new ListaUsuarios(this.usuarioActual));
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
            this.agregarNuevoForm(new ListaProductos());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            this.activarBtn(sender);
            this.MostrarPanel(pCategorias);
            this.agregarNuevoForm(new ListaCategorias());

        }

        private void btnMostrarCategorias_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new ListaCategorias());
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
            //this.agregarNuevoForm(new NuevaVenta());
            this.agregarNuevoForm(new VentaActual(this.usuarioActual));
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
            //this.agregarNuevoForm(new NuevaCategoria());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new NuevoReporte(this.usuarioActual));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.agregarNuevoForm(new BackUP(this.usuarioActual));
        }
    }
}

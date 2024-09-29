using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using PharmaSuite.Vistas.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaSuite.Vistas
{
    public partial class BusquedaEnTabla : Form
    {
        private String tituloTabla;
        private Persona usuarioActual;
        public BusquedaEnTabla(String tituloTabla,Persona usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            this.setTitulo(verificarCasosTitulo(tituloTabla));
        }
        public BusquedaEnTabla(bool label)
        {
            InitializeComponent();
            labelTitulo.Visible = label;
            this.setTitulo("");

        }

        private void setTitulo(String tituloLabel)
        {
            labelTitulo.Text += tituloLabel;
        }
        private String getTitulo(String tituloLabel)
        {
            return this.tituloTabla;
        }

        private String verificarCasosTitulo(String tituloVista)
        {
            String tituloBusqueda = "";

            switch (tituloVista)
            {
                case "Productos":
                    tituloBusqueda = "Nombre";
                    break;
                case "Categorías":
                    tituloBusqueda = "Categoría";
                    break;
                default:
                    tituloBusqueda = "DNI";
                    break;
            }
            return tituloBusqueda;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Persona ps = new();
            QueryPersona qp = new();
            int dniPersona = int.Parse(txbBusqueda.Text);
            if (qp.bucarDni(dniPersona) == null){
                lTablaVacia.Show();
            }
            else
            {
                ps=qp.bucarDni(dniPersona);
                DatosPersona p = new(ps,this.usuarioActual);
                p.Show();

            }

        }
    }
}

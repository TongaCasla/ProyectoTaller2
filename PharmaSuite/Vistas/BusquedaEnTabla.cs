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
        //private Restricciones restric
        public BusquedaEnTabla(String tituloTabla)
        {
            InitializeComponent();
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
                    tituloBusqueda = "Cod. Prod";
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

        
    }
}

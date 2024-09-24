using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaSuite.Vistas.Categorias
{
    public partial class NuevaCategoria : Form
    {
        public NuevaCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigoBarras = "";
            int longitudCod = 4;
            Random random = new Random();
            for (int i = 0; i < longitudCod; i++)
            {
                codigoBarras += random.Next(0, 10);
                // Genera un número aleatorio entre 0 y 9
            }

            txbCodProd.Text = codigoBarras;
        }
    }
}

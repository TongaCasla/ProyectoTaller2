using PharmaSuite.Logica;
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

namespace PharmaSuite.Vistas.Categorias
{
    public partial class NuevaCategoria : Form
    {
        public NuevaCategoria()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txbCodProd.Text) || string.IsNullOrEmpty(txbDescProd.Text) || 
                string.IsNullOrEmpty(txbNombreProd.Text))
            {
                MessageBox.Show("No pueden haber campos vacíos.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Mostramos un mensaje y guardamos la respuesta
                DialogResult ask = MessageBox.Show(
                    "¿Desea agregar una nueva categoría?",
                    "Agregar cliente",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (ask == DialogResult.Yes)
                {
                    //Enviamos
                    DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
                    Categoria categoria = new();
                    categoria.IdCategoria = int.Parse(txbCodProd.Text);
                    categoria.Descripcion = txbDescProd.Text;

                    dc.Categorias.Add(categoria);
                    dc.SaveChanges();
                    MessageBox.Show("Se ha agregado al cliente correctamente");
                }
            }
            
        }

       
    }
}

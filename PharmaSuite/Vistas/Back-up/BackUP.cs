using Microsoft.EntityFrameworkCore;
using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PharmaSuite.Vistas.Back_up
{
    public partial class BackUP : Form
    {
        Persona usuarioActual;
        Usuario usuario;
       // string cadena = "Data Source=DESKTOP-RLTVHDQ\\SQLEXPRESS;Initial Catalog=db_PharmaSuite;Integrated Security=True;TrustServerCertificate=True";
         string cadena = "Data Source=CARLOS\\SQLEXPRESS01;Initial Catalog=db_PharmaSuite;Integrated Security=True;TrustServerCertificate=True";
        string backupPath;

        public BackUP(Persona usuario)
        {
            InitializeComponent();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            using (DbPharmaSuiteContext dc = new DbPharmaSuiteContext())
            {
                this.backupPath = txbRuta.Text.ToString() + @"\Back_Up_" + DateTime.Now.ToString("ddMMyyyyHHmmss");
                string query = $"BACKUP DATABASE [db_Pharmasuite] TO DISK = '{backupPath}'";

                string q = query;
                MessageBox.Show(q);
                //dc.Database.ExecuteSqlRaw(query);

            }
            //this.registroBackup();
            //MessageBox.Show("Se realizó correctamente el back up");

        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialogo = new FolderBrowserDialog())
            {
                // Mostrar el cuadro de diálogo para que el usuario seleccione una carpeta
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    txbRuta.Text = dialogo.SelectedPath;
                }
            }
        }

        private void registroBackup()
        {
            QueryUsuario queryUsuario = new QueryUsuario();
            using (SqlConnection cn = new SqlConnection(this.cadena))
            {
                cn.Open();
                /* this.usuario = queryUsuario.buscarPorIdPers(this.usuarioActual.IdPersona);
                   string query = "INSERT INTO registro_backup (id_usuario,ruta_guardado)" +
                     "VALUES ("+this.usuario.IdUsuario+","+ txbRuta.Text.ToString()+")";
                 */
                string query = "INSERT INTO registro_buckup (id_usuario,ruta_guardado)" +
                    "VALUES (" + 1 + ",'" + this.backupPath + "')";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                cn.Close();

            }

        }

    }
}

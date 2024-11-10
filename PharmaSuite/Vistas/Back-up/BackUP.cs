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
        string cadena = "Data Source=DESKTOP-RLTVHDQ\\SQLEXPRESS;Initial Catalog=db_PharmaSuite;Integrated Security=True;TrustServerCertificate=True";
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

                dc.Database.ExecuteSqlRaw(query);

            }
            this.registroBackup();

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

        private void btnRutaRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogo = new OpenFileDialog())
            {
                // Mostrar el cuadro de diálogo para que el usuario seleccione una carpeta
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    txbRestore.Text = dialogo.FileName;
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string passGerente;
            using (DbPharmaSuiteContext dc = new DbPharmaSuiteContext())
            {
                passGerente = dc.Usuarios.Single(u => u.IdUsuario.Equals(2)).Pass;
            }
            if (passGerente== txtbPassGerente.Text) 
            {
                using (SqlConnection cn = new SqlConnection(this.cadena))
                {
                    cn.Open();
              
                    string restorepath = txbRestore.Text;
                    string query = $"RESTORE DATABASE [db_PharmaSuite] FROM DISK = '{restorepath}' WITH REPLACE";
                    
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Se realizo el restore de la base de datos",
                    "Aceptar",
                     MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                }

            }
            else 
            {
                MessageBox.Show("Contraseña incorrecta",
                "Aceptar",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}

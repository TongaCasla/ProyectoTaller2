using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaSuite.Vistas.Usuarios
{
    public partial class MostrarTabla : Form
    {
        private String tituloTabla;
        private BusquedaEnTabla formBuscar;
        int idPerfil;
        public MostrarTabla(string tituloLabel)
        {
            InitializeComponent();
            this.setTitulo(tituloLabel);
            this.pruebaTablas();
            //this.verificarTabla();

        }
        public MostrarTabla(String tituloLabel, bool habilitarBotones)
        {
            InitializeComponent();
            this.setTitulo(tituloLabel);
            this.verificarTabla();
            btnBuscar.Visible = habilitarBotones;
            btnMostrarActivos.Visible = habilitarBotones;
            btnMostrarInactivos.Visible = habilitarBotones;
            
        }
        private void setTitulo(String tituloLabel)
        {
            labelTituloTabla.Text += tituloLabel;
            tituloTabla = tituloLabel;
        }
        public String getTitulo()
        {
            return this.tituloTabla;
        }
        private void pruebaTablas()
        {

            QueryPersona query = new QueryPersona();
            List <Persona> lista = query.listaPersona();

            foreach (Persona ps in lista) 
            {
                dataGridView1.Rows.Add(ps.Dni, ps.Nombre,ps.Apellido,ps.Email, ps.IdPerfil, ps.Activo,"Modificar","Eliminar");
            }

        }
               

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verifica si el formulario ya existe y está visible
            if (formBuscar == null)
            {
                // Si no existe o ha sido cerrado, crea una nueva instancia
                formBuscar = new BusquedaEnTabla(this.getTitulo());
                formBuscar.TopLevel = false;
                formBuscar.Dock = DockStyle.Right;
                this.Controls.Add(formBuscar);
                formBuscar.Show();
            }
            else
            {
                // Si ya está abierto, lo trae al frente
                formBuscar.BringToFront();
            }
        }
        private void verificarTabla()
        {
            if (dataGridView1.Rows.Count == 0)
            {

                lTablaVacia.Show();
                dataGridView1.Hide();
            }
            else
            {
                lTablaVacia.Hide();
                dataGridView1.Show();
            }
        }



       
        //mod
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DbPharmaSuiteContext cn = new DbPharmaSuiteContext();
            QueryPersona query = new QueryPersona();
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            // Verificar que no sea el encabezado de la columna
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                    int dni = int.Parse(selectedRow.Cells["Dni"].Value.ToString());
                    Persona ps = cn.Personas.Where(u => u.Dni == dni).First();

                    if (ps.Activo == "si")
                    {
                        ps.Activo = "no";
                        cn.SaveChanges();
                    
                     }
                    else
                    {
                        ps.Activo = "si";
                        cn.SaveChanges();
    

                    }
                    this.pruebaTablas();
                    MessageBox.Show("Se ha modificado el campo correctamente");

            }else if (e.RowIndex >= 0 && e.ColumnIndex == 6) 
            {
                int dni = int.Parse(selectedRow.Cells["Dni"].Value.ToString());
                Persona ps = cn.Personas.Where(u => u.Dni == dni).First();
                DatosPersona dtPer = new DatosPersona(ps);
                dtPer.Show();
            }
            
        }
        }
    }





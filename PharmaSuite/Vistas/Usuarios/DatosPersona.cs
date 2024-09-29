using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmaSuite.Logica;
using PharmaSuite.Logica.Query;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaSuite.Vistas.Usuarios
{
    public partial class DatosPersona : Form
    {

        private Persona usuarioActual;
        public DatosPersona(Persona ps, Persona usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            this.asignarValores(ps);

            this.verificarTipoPerfil(usuarioActual.IdPerfil);


            this.labelPersona.Text += ps.Nombre + " " + ps.Apellido;
            this.Text = "Datos de " + ps.Nombre + " " + ps.Apellido;

        }
        private void verificarTipoPerfil(int tipoPerfil)
        {
            switch (tipoPerfil)
            {
                //Perfil empleado;
                case 2:
                //Perfil Gerente
                case 3:

                    {
                        lPerfil.Hide();
                        comboPerfil.Hide();
                        txbEmail.Enabled = false;
                        txbNombre.Enabled = false;
                        txbApellido.Enabled = false;
                        dateFecha.Enabled = false;
                        txbDni.Enabled = false;
                        txbTele.Enabled = false;
                        comboSexo.Enabled = false;
                        break;
                    }
                //Perfil Admin
                default:
                    {
                        txbDni.Enabled = true;
                        txbEmail.Enabled = true;
                        txbUsuario.Enabled = true;
                        lUsuario.Show();
                        txbUsuario.Show();
                        break;
                    }

            }
        }

        private void asignarValores(Persona ps)
        {

            txbDni.Text = ps.Dni.ToString();
            txbEmail.Text = ps.Email;
            txbNombre.Text = ps.Nombre;
            txbApellido.Text = ps.Apellido;
            txbTele.Text = ps.Telefono;
            dateFecha.Value = ps.FechaNac.ToDateTime(TimeOnly.MinValue);
            this.asignarSexo(ps.Sexo);
            comboPerfil.SelectedIndex = ps.IdPerfil - 1;
           
            QueryUsuario query = new QueryUsuario();
           

            if (query.buscarPorIdPers(ps.IdPersona) != null) 
            {
                txbUsuario.Text = query.buscarPorIdPers(ps.IdPersona).Nombre;
            }
            else
            {
                txbUsuario.Text = "No existe usuario";
            }
            

        }

        private void asignarSexo(string sexo)
        {
            if (sexo == "hombre")
            {
                comboSexo.SelectedIndex = 0;
            }
            else if (sexo == "mujer")
            {
                comboSexo.SelectedIndex = 1;
            }
            else
            {
                comboSexo.SelectedIndex = 2;
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show(
                "¿Desea modificar los datops de la persona?",
                "Modificar datos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ask == DialogResult.Yes && verificarPersona())
            {
                //Enviamos
                DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
                int dni = int.Parse(txbDni.Text);
                Persona persona = dc.Personas.Where(u => u.Dni == dni).First();
                persona.Nombre = txbNombre.Text;
                persona.Apellido = txbApellido.Text;
                //persona.Dni = int.Parse(txbDni.Text);
                //persona.Email = txbEmail.Text;
                //persona.Telefono = txbTele.Text;
                persona.FechaNac = DateOnly.FromDateTime(dateFecha.Value);
                //persona.IdPerfil = (comboPerfil.SelectedIndex) + 1;
                persona.Sexo = sexoSeleccion();
                dc.SaveChanges();
                MessageBox.Show("Se ha modificado correctamente");
                this.Dispose();

            }

        }

        private string sexoSeleccion() 
        {
            string sexo = "";
            int i = comboSexo.SelectedIndex;
            switch (i) 
            {
                case 0: sexo = "hombre";
                    break;
                case 1: sexo = "mujer";
                    break;
                case 2: sexo = "otro";
                    break;

            }
            return sexo;
        }


        private bool verificarPersona()
            {
                string[] datosPersona = new string[5];
                datosPersona[0] = txbNombre.Text;
                datosPersona[1] = txbApellido.Text;
                datosPersona[2] = txbDni.Text;
                datosPersona[3] = txbTele.Text;
                datosPersona[4] = txbEmail.Text;
                Validacion val = new Validacion();
                ValidacionPersona valPer = new ValidacionPersona();
                if (val.EsVacio(txbNombre) && val.EsVacio(txbApellido) && (val.EsVacio(txbDni) && val.EsVacio(txbTele) && val.EsVacio(txbEmail)))
                {
                    return true;
                    //(valPer.validarDatosPersona(datosPersona));
                }
                else
                {
                    MessageBox.Show("Existen campos vacíos, por favor complete todos los campos");
                    return false;
                }
            }


        }
    } 

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaSuite.Vistas.Usuarios
{
    public partial class DatosPersona : Form
    {
        private Persona usuarioActual;
        public DatosPersona(Persona ps,Persona usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual=usuarioActual;
            this.asignarValores(ps);

            this.verificarTipoPerfil(usuarioActual.IdPerfil);
            this.labelPersona.Text += ps.Nombre+" "+ps.Apellido;
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
                        txbTlf.Enabled = false;
                        comboSexo.Enabled = false;
                        break;
                    }
                    //Perfil Admin
                default:
                    {
                        txbDni.Enabled = true;
                        txbEmail.Enabled=true;
                        txbUsuario.Enabled=true;
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
            txbTlf.Text = ps.Telefono;
            dateFecha.Value = ps.FechaNac.ToDateTime(TimeOnly.MinValue);
            this.asignarSexo(ps.Sexo);
            comboPerfil.SelectedIndex = ps.IdPerfil-1;
            
        }

        private void asignarSexo(string sexo) 
        {
            if (sexo == "hombre") 
            {
                comboSexo.SelectedIndex = 0; 
            }else if(sexo == "mujer") 
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
    }
}

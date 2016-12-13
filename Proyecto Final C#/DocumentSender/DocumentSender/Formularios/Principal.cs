using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentSender.Formularios
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            // Revisar la conexion a la base de datos
            if (DB.TestConexion())
            {
                Sistema.Instancia.CargarDatos();
                Formularios.Login login = new Login();
                Sistema.Instancia.Actual = login.Loguear();

                if (Sistema.Instancia.Actual != null)
                {
                    if (!(Sistema.Instancia.Actual.Empleado.Tipo == Clases.TipoEmpleado.Administrador)) // Si no es administrador
                    {
                        toolSistema.Visible = false;

                        if (Sistema.Instancia.Actual.Empleado.Tipo == Clases.TipoEmpleado.Secretaria) // Si es secretaria
                        {
                            toolRegEnvioExterno.Visible = false;
                            toolRegRecExterna.Visible = false;
                            toolRegEnvio.Visible = false;
                        }
                        else
                        {
                            toolRegRecInterna.Visible = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos");
                Application.Exit();
            }
        }
        

        #region Envio/Recepcion de documentos -----------------------------------------------------------------------

        private void toolRegistrarUsuario_Click(object sender, EventArgs e)
        {
            AgEmpleado ag = new AgEmpleado();
            ag.ShowDialog();
        }

        private void toolRegistrarDepartamento_Click(object sender, EventArgs e)
        {
            AgDepartamento ag = new AgDepartamento();
            ag.ShowDialog();
        }

        private void toolRegEnvioDesdeFuera_Click(object sender, EventArgs e)
        {
            Formularios.RegRecInterna rri = new RegRecInterna();
            rri.interno = false;
            rri.ShowDialog();
        }

        private void toolRegEnvioInterno_Click(object sender, EventArgs e)
        {
            Formularios.RegEnvioInterno rei = new Formularios.RegEnvioInterno();
            rei.ShowDialog();
        }

        private void toolRegEnvioExterno_Click(object sender, EventArgs e)
        {
            Formularios.RegEnvioExterno ree = new Formularios.RegEnvioExterno();
            ree.ShowDialog();
        }

        private void toolRegRecInterna_Click(object sender, EventArgs e)
        {
            Formularios.RegRecInterna rri = new RegRecInterna();
            rri.interno = true;
            rri.ShowDialog();
        }

        private void toolRegRecExterna_Click(object sender, EventArgs e)
        {
            Formularios.RegRecExterna rre = new RegRecExterna();
            rre.ShowDialog();
        }

        #endregion Envio/Recepcion de documentos --------------------------------------------------------------------


    }
}

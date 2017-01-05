using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Lavanderia0._1.Modelo;
using Lavanderia0._1.Vista;

namespace Lavanderia0._1
{
    public partial class Usuario : MetroForm, IDatou
    {
        // ********************************************************************************** \\
        // Esta linea de codigo representa el metodo constructor el cual nos va a permitir
        // iniciarlizar todos los componentes del formulario Usuario
        // ********************************************************************************** \\

        public Usuario()
        {
            InitializeComponent();
            consulta();
            dgvusuario.Columns[0].Visible = false;
            metroTabControl1.SelectedTab = metroTabPage1;
        }


        // *************************************************************************************** \\
        // Esta linea de codigo representa la creacion o instanciacion de los objectos da las 
        // diferentes clases que van interactuar con la base de datos dblavanderia
        // *************************************************************************************** \\

        CLUsuario u = new CLUsuario();


        public int Uid_empleado;

        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo consulta() el cual nos va ha atraer todos los 
        // datos de la tabla usuario para llenar el datagridview dgvusuario
        // *************************************************************************************** \\

        private void consulta()
        {
            dgvusuario.DataSource = new CLUsuario().consultar();
        }


        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo obtener() el cual nos va a permitir obtener
        // los datos del usuario que se van a vizualizar en los cuadros de texto del formulario de dicho modulo
        // *************************************************************************************** \\

        private void obtener()
        {
            txtcuenta.Text = dgvusuario.CurrentRow.Cells[1].Value.ToString();
            txtcontrasenia.Text = dgvusuario.CurrentRow.Cells[2].Value.ToString();
            txtempleado.Text = dgvusuario.CurrentRow.Cells[3].Value.ToString();
        }

        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo obtenerlbl() el cual nos va a permitir obtener
        // los datos del usuario que se van a vizualizar en los label del formulario de dicho modulo
        // *************************************************************************************** \\

        private void obtenerlbl()
        {
            lblcuenta.Text = dgvusuario.CurrentRow.Cells[1].Value.ToString();
            lblcontrasenia.Text = dgvusuario.CurrentRow.Cells[2].Value.ToString();
            lblempleado.Text = dgvusuario.CurrentRow.Cells[3].Value.ToString();
        }


        private void obtenerid()
        {
            if (dgvusuario.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Debe de seleccionar una fila con datos");
            }
            else
            {
                u.Id_usuario = Convert.ToInt32(dgvusuario.CurrentRow.Cells[0].Value.ToString());
            }
        }

        // **************************************************************************************** \\
        // Esta linea de codigo representa el metodo pasarvalor() el cual nos va a permitir pasar los
        // datos que estan los diferentes cuadros del texto del formulario y enviar lo a las variables
        // **************************************************************************************** \\

        private void pasarvalor()
        {
            u.Cuenta = txtcuenta.Text;
            u.Clave = txtcontrasenia.Text;
        }

        // ******************************************************************************* \\
        // Esta linea de codigo representa el metodo limpiar() el cual nos va a permitir 
        // limpiar todos los cuadros de textos del formulario cuando llamemo a este
        // ******************************************************************************* \\

        private void limpiar()
        {
            txtcuenta.Text = "";
            txtempleado.Text = "";
            txtcontrasenia.Text = "";
            txtconfirma.Text = "";
        }

        // ******************************************************************************* \\
        // Esta linea de codigo representa el metodo limpiar() el cual nos va a permitir 
        // limpiar todos los cuadros de textos del formulario cuando llamemo a este
        // ******************************************************************************* \\

        private void limpiarlbl()
        {
            lblcuenta.Text = "____________________";
            lblcontrasenia.Text = "____________________";
            lblempleado.Text = "____________________";
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btnregistrar el cual va a utilizar para guardar los datos en la bd
        // ******************************************************************* \\

        private void btnguardar_Click(object sender, EventArgs e)
        {
            pasarvalor();

            // ************************************************************************************************************ \\
            // Esta linea de codigo representa la insercciones de los datos en las diferentes tablas de la base de datos 
            // ************************************************************************************************************ \\

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

            if (new ControlDB().generarInsert(new string[] { "cuenta", "clave", "id_empleado" }, new string[] { u.Cuenta, u.Clave, u.Id_empleado.ToString() }, "usuario"))
            {
                MessageBox.Show("Datos registrados correctamente");
                consulta();
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al registrar los datos solicitados");
            }

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btneditar el cual va a utilizar para modificar los datos en la bd
        // ******************************************************************* \\

        private void btneditar_Click(object sender, EventArgs e)
        {
            pasarvalor();

            // ************************************************************************************************************ \\
            // Esta linea de codigo representa la insercciones de los datos en las diferentes tablas de la base de datos 
            // ************************************************************************************************************ \\

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

            if (new ControlDB().modificar("usuario", "u inner join empleado e on e.id_empleado = u.id_empleado", "id_usuario", u.Id_usuario.ToString(),
                                          new string[] { "u.cuenta", "u.clave", "u.id_empleado" }, new string[] { u.Cuenta, u.Clave, u.Id_empleado.ToString() }))
            {
                MessageBox.Show("Datos modificados correctamente");
                consulta();
                limpiar();
                btnguardar.Enabled = true;
                btnsalir.Enabled = true;
                btnlimpiar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error al modificar los datos correctamente");
            }

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btneditar el cual va a utilizar para modificar los datos en la bd
        // ******************************************************************* \\

        private void btneliminar_Click(object sender, EventArgs e)
        {


            // ************************************************************************************************************ \\
            // Esta linea de codigo representa la insercciones de los datos en las diferentes tablas de la base de datos 
            // ************************************************************************************************************ \\

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

            if (new ControlDB().eliminar("from usuario", "", "id_usuario", u.Id_usuario.ToString()))
            {
                MessageBox.Show("Datos eliminados correctamente");
                consulta();
                limpiarlbl();
            }
            else
            {
                MessageBox.Show("Error al eliminar los datos solicitados");
            }
        }

        private void dgvusuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerlbl();
            obtenerid();
            btneliminar.Enabled = true;
            btnmodificar.Enabled = false;
        }

        private void dgvusuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerid();
            obtenerlbl();
            btneliminar.Enabled = false;
            btnmodificar.Enabled = true;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            btneditar.Enabled = true;
            obtener();
            metroTabControl1.SelectedTab = metroTabPage1;
            btnguardar.Enabled = false;
            btnlimpiar.Enabled = false;
            btnsalir.Enabled = false;
        }

        // ******************************************************************************** ||
        // Esta linea de codigo representa el metodo cargardato() el cual recibe por parametro
        // un objeto de tipo CLUsuario el cual nos va permitir pasar los datos tomados del
        // formulario Empleados_reg de su datagridview
        // ******************************************************************************** ||

        public void cargardato(CLUsuario datos)
        {
            txtempleado.Text = datos.Empleado;
            Uid_empleado = datos.Id_empleado;
        }


        // *********************************************************** ||
        // Esta linea de codigo representa el evento clic del button 
        // button1 el cual nos va permitir llamar el formulario 
        // Empleados_reg el cual utilizaremos para cargar el empleado
        // seleccionado del datagridview de dicho formulario
        // *********************************************************** ||
        private void button1_Click(object sender, EventArgs e)
        {
            Empleados_reg er = new Empleados_reg();
            er.llamador1 = this;
            er.MdiParent = this.MdiParent;
            er.Show();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 0)
            {
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
                limpiarlbl();
            }
            else if (metroTabControl1.SelectedIndex == 1)
            {
                limpiar();
                btnguardar.Enabled = true;
                btnlimpiar.Enabled = true;
                btneditar.Enabled = false;
            }
        }
    }
}

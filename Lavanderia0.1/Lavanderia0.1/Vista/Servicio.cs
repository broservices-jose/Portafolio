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

namespace Lavanderia0._1.Vista
{
    public partial class Servicio : MetroForm
    {
        // ********************************************************************************** \\
        // Esta linea de codigo representa el metodo constructor el cual nos va a permitir
        // iniciarlizar todos los componentes del formulario Servicio
        // ********************************************************************************** \\

        public Servicio()
        {
            InitializeComponent();
            consulta();
            dgvservicio.Columns[0].Visible = false;
            metroTabControl1.SelectedTab = metroTabPage1;
        }

        // *************************************************************************************** \\
        // Esta linea de codigo representa la creacion o instanciacion de los objectos da las 
        // diferentes clases que van interactuar con la base de datos dblavanderia
        // *************************************************************************************** \\
        CLServicio s = new CLServicio();

        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo consulta() el cual nos va ha atraer todos los 
        // datos de las tabla servicio para llenar el datagridview dgvservicio
        // *************************************************************************************** \\
        private void consulta()
        {
            dgvservicio.DataSource = new CLServicio().consulta();
        }


        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo obtener() el cual nos va a permitir obtener
        // los datos del servicio que se van a vizualizar en los cuadros de texto del formulario de dicho modulo
        // *************************************************************************************** \\

        private void obtener()
        {
            txtservicio.Text = dgvservicio.CurrentRow.Cells[1].Value.ToString();
            txtprecio.Text = dgvservicio.CurrentRow.Cells[2].Value.ToString();
            txtdescripcion.Text = dgvservicio.CurrentRow.Cells[3].Value.ToString();
        }

        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo obtener() el cual nos va a permitir obtener
        // los datos del servicio que se van a vizualizar en los cuadros de texto del formulario de dicho modulo
        // *************************************************************************************** \\

        private void obtenerlbl()
        {
            lblservicio.Text = dgvservicio.CurrentRow.Cells[1].Value.ToString();
            lblprecio.Text = dgvservicio.CurrentRow.Cells[2].Value.ToString();
            lbldescripcion.Text = dgvservicio.CurrentRow.Cells[3].Value.ToString();
        }

        // ********************************************************************************************* \\
        // Este linea de codigo representa el metodo obtenerid() el cual nos va a permitir obtener 
        // el id del servicio seleccionado para luego ser utilizado de diversas formas como eliminar, etc
        // ********************************************************************************************** \\

        private void obtenerid()
        {
            if (dgvservicio.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Debe de seleccionar una fila con datos");
            }
            else
            {
                s.Id_servicio = Convert.ToInt32(dgvservicio.CurrentRow.Cells[0].Value.ToString());
            }
        }

        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo pasarvalor() el cual nos va a permitir obtener
        // los datos de los diferentes cuadro de textos que tiene el formulario servicio para luego
        // ser registrado en la tabla servicio de la base de datos dblavanderia
        // *************************************************************************************** \\

        private void pasarvalor()
        {
            s.Tipo = txtservicio.Text;
            s.Precio = Convert.ToDouble(txtprecio.Text);
            s.Descripcion = txtdescripcion.Text;
        }

        // ******************************************************************************* \\
        // Esta linea de codigo representa el metodo limpiar() el cual nos va a permitir 
        // limpiar todos los cuadros de textos del formulario cuando llamemo a este
        // ******************************************************************************* \\

        private void limpiar()
        {
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtservicio.Text = "";
        }

        // ******************************************************************************* \\
        // Esta linea de codigo representa el metodo limpiar() el cual nos va a permitir 
        // limpiar todos los labels de textos del formulario cuando llamemo a este
        // ******************************************************************************* \\

        private void limpiarlbl()
        {
            lbldescripcion.Text = "____________________";
            lblprecio.Text = "____________________";
            lblservicio.Text = "____________________";
        }


        private void btnguardar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnguardar, "Boton Guardar");
        }

        private void btnlimpiar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnlimpiar, "Boton Limpiar");
        }

        private void btnsalir_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnsalir, "Boton Salir");
        }

        private void btnmodificar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnmodificar, "Boton Modificar");
        }

        private void btneliminar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btneliminar, "Boton Eliminar");
        }

        private void btnbuscar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnbuscar, "Boton Buscar");
        }

        private void Servicio_Load(object sender, EventArgs e)
        {

        }

        //==============================================================//
        //metodo para validar los texvos de servicio====================//
        private bool valiservicio() {
            if (txtservicio.Text == "") {
                lbllservicio.Visible = true;
                return false;
            
            }
            if(txtprecio.Text==""){
                lbllprecio.Visible = true;
                return false;
            
            }
            return true;
        }
        //================================================================//
        // metodo para desvalida servicio//
        private void desvaliservicio() {
            lbllprecio.Visible = false;
            lbllprecio.Visible = false;
        
        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btnregistrar el cual va a utilizar para guardar los datos en la bd
        // ******************************************************************* \\

        private void btnguardar_Click(object sender, EventArgs e)
        {
            

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||


           if(valiservicio()==true){
               pasarvalor();
               if (new ControlDB().generarInsert(new string[] { "servicio", "precio", "descripcion" }, new string[] { s.Tipo, s.Precio.ToString(), s.Descripcion }, "servicio"))
            {
                MessageBox.Show("Datos registrados correctamente");
                desvaliservicio();
                consulta();
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al registrar los datos solicitados");
            } }

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||
        
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btnmodificar el cual va a utilizar para modificar los datos socilitados
        // en la base de datos dblavanderia
        // ******************************************************************* \\

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (valiservicio() == true)
            {
                btnguardar.Enabled = false;
                btnmodificar.Enabled = true;
                pasarvalor();
                obtenerid();
                btnguardar.Enabled = false;

                // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

                if (new ControlDB().modificar("servicio", "", "id_servicio", s.Id_servicio.ToString(), new string[] { "servicio", "precio", "descripcion" },
                    new string[] { s.Tipo, s.Precio.ToString(), s.Descripcion }))
                {
                    consulta();
                    limpiar();
                    MessageBox.Show("Datos registrado correctamente");
                    metroTabControl1.SelectedTab = metroTabPage2;
                    desvaliservicio();
                }
                else
                {
                    MessageBox.Show("Error al modificar los datos solicitados");
                }
            }
            else {

                MessageBox.Show("Debe llenar los campos vacio");
            }
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btneliminar el cual va a utilizar para eliminar los datos socilitados
        // desde el formulario empleado en la base de datos dblavanderia
        // ******************************************************************* \\

        private void btneliminar_Click(object sender, EventArgs e)
        {
            obtenerid();

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

            if (new ControlDB().eliminar("from servicio", "", "id_servcio", s.Id_servicio.ToString()))
            {
                MessageBox.Show("Datos eliminados correctamente");
                limpiar();
                consulta();
            }
            else
            {
                MessageBox.Show("Error al eliminar los datos solictados");
            }
        }

        private void dgvservicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerid();
            obtenerlbl();
            btnguardar.Enabled = false;
            btnlimpiar.Enabled = false;
            btnmodificar.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = true;
        }

        private void dgvservicio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerid();
            obtenerlbl();
            btnguardar.Enabled = false;
            btnlimpiar.Enabled = false;
            btnmodificar.Enabled = true;
            btneditar.Enabled = true;
            btneliminar.Enabled = false;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            obtener();
            metroTabControl1.SelectedTab = metroTabPage1;
        }

        private void btneditar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btneditar, "Boton Modificar");
        }

        // *************************************************************************************** \\
        // Esta linea de codigo representa el evento SelectedIndexChanged del metroTabControl1
        // el cual vamos a utilizar para restablecer los controles cuando se seleccione el primer
        // tabpage1 de dicho tabcontrol
        // *************************************************************************************** \\
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
                btnsalir.Enabled = true;
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtservicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

    }
}

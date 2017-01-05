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
using Lavanderia0._1.Modelo; // ojo
using Lavanderia0._1.Vista;

namespace Lavanderia0._1.Vista
{
    public partial class Pago_Nomina : MetroForm, IDatop
    {
        // ************************************************************************************* ||
        // Esta linea de codigo represena el metodo constructor el cual vamos a utilizar para 
        // inicializar todos los componentes del sistema y algunos metodos y operaciones que 
        // queramos inicializar con el formulario
        // ************************************************************************************* ||

        public Pago_Nomina()
        {
            InitializeComponent();
            Consultar();
            dgvpagonomina.Columns[0].Visible = false;
            metroTabControl1.SelectedTab = metroTabPage1;
            llenarcombo();
        }

        private void btnguardar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnguardar, "Boton Guardar");
        }

        // *********************************************************************************** ||
        // Esta linea de codigo representa la instanciacion de los objetos que van interactuar
        // con la tabla pago_nomina de la base de datos dblavanderia
        // *********************************************************************************** ||

        CPagodenomina a = new CPagodenomina();
        private int Pid_empleado;
        
        // ********************************************************************************************* ||
        // Esta linea de codigo representa el metodo Consultar() el cual nos va a permitir llenar el 
        // datagridview dgvpagonomina con los datos traidos de la consulta que se encuentra en la clase
        // CPagodenomina()
        // ********************************************************************************************* ||

        private void Consultar(){
                            // DEbes tener cuidado con este formulario por que no esta agrega
            dgvpagonomina.DataSource = new CPagodenomina().Consultar(); 
           
        }

        // ********************************************************************************************* ||
        // Esta linea de codigo representa el metodo pasarvalores() el cual nos va a permitir pasar los 
        // datos de los diferentes cuadros de textos a las variables que van interactuar con la base de daos
        // ********************************************************************************************* ||

        private void pasarvalores()
        {
            a.Deuda = Convert.ToDouble(txtdeuda.Text);
            a.Fecha = dtpfecha.Value.ToString();
            a.Motivo = txtmotivo.Text;
            a.Pago = cbpago.Text;
            
        }
        
        //=============================================//
        //metodo para limpira los los campos////////////
        //===========================================//
        private void limpiar() {
            txtbeneficiario.Text = "";
            txtcargo.Text = "";
            txtcedula.Text = "";
            txtmotivo.Text ="";
            txtdeuda.Text = "";
            cbpago.Text = "";
            dtpfecha.ResetText();
            txtsueldo.Text = "";
            pictureBox1.Image = Properties.Resources.iconousuario;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        
        }

        //=============================================//
        //metodo para limpira los label////////////
        //===========================================//

        private void limpiarlbl()
        {
            lblcargo.Text = "___________________";
            lblsueldo.Text = "___________________";
            lbldeuda.Text = "___________________";
            lblempleado.Text = "___________________";
            lblcedula.Text = "___________________";
            lblfecha.Text = "___________________";
            lblpago.Text = "___________________";
            lblmotivo.Text = "__________________________________________________";
            pictureBox2.Image = Properties.Resources.iconousuario;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }


         // ******************************************************************************************** ||
        // Esta linea de codigo representa el metodo obtenerid() el cual nos va dar el id_pago_nomina que
        // ha sido seleccionado del datagridview dgvpagonomina 
        // ********************************************************************************************* ||

        private void obtenerid()
        {
            if (dgvpagonomina.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Debe de seleccionar una fila con datos");
            }
            else
            {
                a.Id_pago_nomina = Convert.ToInt32(dgvpagonomina.CurrentRow.Cells[0].Value.ToString());
            }
        }

        // ************************************************************************************************* ||
        // Esta linea de codigo representa el metodo llenarcombo() el cual nos va a permitir llenar 
        // el combobox cbpago con los doces meses del años y visualizarlo desde que se inicie el formulario
        // ************************************************************************************************* ||

        private void llenarcombo()
        {
            cbpago.Items.Add("Enero");
            cbpago.Items.Add("Febrero");
            cbpago.Items.Add("Marzo");
            cbpago.Items.Add("Abril");
            cbpago.Items.Add("Mayo");
            cbpago.Items.Add("Junio");
            cbpago.Items.Add("Julio");
            cbpago.Items.Add("Agosto");
            cbpago.Items.Add("Septiembre");
            cbpago.Items.Add("Octubre");
            cbpago.Items.Add("Noviembre");
            cbpago.Items.Add("Diciembre");
        }

        // ****************************************************************************************** ||
        // Esta linea de codigo representa el metodo obtener() el cual nos va a permitir obtener los 
        // datos seleccionados del datagridview dgvpagonomina y posteriormente visualizarlo en los 
        // diferentes cuadros de textos del formulario
        // ****************************************************************************************** ||


        private void obtener()
        {
            txtbeneficiario.Text = dgvpagonomina.CurrentRow.Cells[1].Value.ToString();
            txtcedula.Text = dgvpagonomina.CurrentRow.Cells[2].Value.ToString();
            txtsueldo.Text = dgvpagonomina.CurrentRow.Cells[3].Value.ToString();
            txtcargo.Text = dgvpagonomina.CurrentRow.Cells[4].Value.ToString();
            txtdeuda.Text = dgvpagonomina.CurrentRow.Cells[5].Value.ToString();
            dtpfecha.Text = dgvpagonomina.CurrentRow.Cells[6].Value.ToString();
            txtmotivo.Text = dgvpagonomina.CurrentRow.Cells[7].Value.ToString();
            cbpago.Text = dgvpagonomina.CurrentRow.Cells[8].Value.ToString();
        }

        // ****************************************************************************************** ||
        // Esta linea de codigo representa el metodo obtenerlbl() el cual nos va a permitir obtener los 
        // datos seleccionados del datagridview dgvpagonomina y posteriormente visualizarlo en los 
        // diferentes labels de textos del formulario
        // ****************************************************************************************** ||

        private void obtenerlbl()
        {
            lblempleado.Text = dgvpagonomina.CurrentRow.Cells[1].Value.ToString();
            lblcedula.Text = dgvpagonomina.CurrentRow.Cells[2].Value.ToString();
            lblsueldo.Text = dgvpagonomina.CurrentRow.Cells[3].Value.ToString();
            lblcargo.Text = dgvpagonomina.CurrentRow.Cells[4].Value.ToString();
            lblpago.Text = dgvpagonomina.CurrentRow.Cells[8].Value.ToString();
            lblfecha.Text = dgvpagonomina.CurrentRow.Cells[6].Value.ToString();
            lblmotivo.Text = dgvpagonomina.CurrentRow.Cells[7].Value.ToString();
            lbldeuda.Text = dgvpagonomina.CurrentRow.Cells[5].Value.ToString();
        }
        

        private void btnlimpiar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnlimpiar, "Boton Limpiar");
        }

        private void btnmodificar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnmodificar, "Boton Modificar");
        }

        private void btnsalir_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnsalir, "Boton Salir");
        }

        private void btnbuscar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnbuscar, "Boton Buscar");
        }

        private void btneliminar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btneliminar, "Boton Eliminar");
        }

        private void btneditar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btneditar, "Boton Modificar");
        }

        // ************************************************************************ ||
        // Esta linea de codigo representa el evento click del boton btnguardar
        // el cual nos va permitir guardar los datos introducidos por teclado desde
        // el formulario Pago de Nomina
        // ************************************************************************ ||
        private void btnguardar_Click(object sender, EventArgs e)
        {
            pasarvalores();
            if (new ControlDB().generarInsert(new string[] { "pago", "fecha", "motivo", 
                "deuda", "id_empleado" }, new string[] {a.Pago, a.Fecha, a.Motivo, 
                    a.Deuda.ToString(), a.Id_empleado.ToString()}, "pago_nomina"))
            {
                MessageBox.Show("Los Datos han sido registrado correctamente");
                Consultar();
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al registrar los datos solicitados");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleados_reg er = new Empleados_reg();
            er.llamador = this;
            er.MdiParent = this.MdiParent;
            er.Show();
        }
        // ************************************************************************ ||
        // Esta linea de codigo en adelante representa el metodo cargardato el cual 
        // nos va permitir pasar datos del datagridview que se encuentra en el 
        // formulario Empleados_reg
        // ************************************************************************ ||

        /// <summary>
        /// Funcion encargada de agregar Los datos a el textbox txtbeneficiario 
        /// </summary>
        /// <param name="datos"> instancia de la clase CPagodenomina </param>
        public void cargardato(CPagodenomina datos)
        {
            txtbeneficiario.Text = datos.Empleado;
            Pid_empleado = datos.Id_empleado;
            pictureBox1.Image = Image.FromFile(datos.Ruta);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
 
        }

        // ************************************************************************ ||
        // Esta linea de codigo representa el evento click del boton btnmodifcar
        // el cual nos va permitir modificar los datos introducidos por teclado desde
        // el formulario Pago de Nomina
        // ************************************************************************ ||

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            pasarvalores();
            obtenerid();
            if (new ControlDB().modificar("pago_nomina", "p inner join empleado e on "+
                "p.id_empleado = e.id_empleado", "p.id_pago_nomina", a.Id_pago_nomina.ToString(), 
                new string[] { "p.pago", "p.fecha", "p.motivo", "p.id_empleado", "p.deuda" }, 
                new string[] {a.Pago, a.Fecha, a.Motivo, a.Id_empleado.ToString(), a.Deuda.ToString()}))
            {
                MessageBox.Show("Datos modificados correctamente");
            }
            else
            {
                MessageBox.Show("Error al modificar los datos socilitados");
            }
        }

        // ************************************************************************ ||
        // Esta linea de codigo representa el evento click del boton btneliminar
        // el cual nos va permitir eliminar los datos seleccionado del datagridview
        // dgvpagonomina del formulario Pago de Nomina
        // ************************************************************************ ||

        private void btneliminar_Click(object sender, EventArgs e)
        {
            obtenerid();
            if (new ControlDB().eliminar("pago_nomina", "from pago_nomina inner join "+
                "empleado on empleado.id_empleado = pago_nomina.id_empleado", 
                "pago_nomina.id_pago_nomina", a.Id_pago_nomina.ToString()))
            {
                MessageBox.Show("Datos eliminados correctamente");
            }
            else
            {
                MessageBox.Show("Error al eliminar los datos solicitados");
            }
        }

        private void dgvpagonomina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerlbl();
            btneliminar.Enabled = true;
            btneditar.Enabled = false;
        }

        private void dgvpagonomina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerlbl();
            btneliminar.Enabled = false;
            btneditar.Enabled = true;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            obtener();
            btnmodificar.Enabled = true;
            btnguardar.Enabled = false;
            btnlimpiar.Enabled = false;
            btnsalir.Enabled = false;
            metroTabControl1.SelectedTab = metroTabPage1;
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 0)
            {
                limpiarlbl();
                btneditar.Enabled = false;
                btneliminar.Enabled = false;
                
            }
            else if (metroTabControl1.SelectedIndex == 1)
            {
                limpiar();
                btnguardar.Enabled = true;
                btnlimpiar.Enabled = true;
                btnmodificar.Enabled = false;
                btnsalir.Enabled = true;
            }
        }

        private void txtdeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtmotivo_KeyPress(object sender, KeyPressEventArgs e)
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

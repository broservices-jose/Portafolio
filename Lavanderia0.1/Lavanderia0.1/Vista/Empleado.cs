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

namespace Lavanderia0._1
{
    public partial class Empleado : MetroForm
    {
        // ********************************************************************************** \\
        // Esta linea de codigo representa el metodo constructor el cual nos va a permitir
        // iniciarlizar todos los componentes del formulario Empleado
        // ********************************************************************************** \\


        public Empleado()
        {
            InitializeComponent();
            cbsexo.Items.Add("Masculino");
            cbsexo.Items.Add("Femenino");
            consulta();
            dgvempleado.Columns[0].Visible = false;
            metroTabControl1.SelectedTab = metroTabPage1;
        }

        // *************************************************************************************** \\
        // Esta linea de codigo representa la creacion o instanciacion de los objectos da las 
        // diferentes clases que van interactuar con la base de datos dblavanderia
        // *************************************************************************************** \\
      
        ControlDB cb = new ControlDB();
        CLEmpleado ce = new CLEmpleado();
        ClRef r = new ClRef();
        OpenFileDialog abrir = new OpenFileDialog();
        private string auxiliar;

        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo consulta() el cual nos va ha atraer todos los 
        // datos de las tablas empleados, imagen y referencia para llenar el datagridview dgvempleado
        // *************************************************************************************** \\
        private void consulta()
        {
            dgvempleado.DataSource = new CLEmpleado().consulta();
        }

        // *************************************************************************** //
        //Metodo de validacion para los textbox
        private  bool Validartext()
        {
            if (txtnombre.Text == "") { lbnombre.Visible = true;
            return false;
            }
            if (txtapellido.Text == "") { lbapellido.Visible = true;
            return false;
            }
            if (cbsexo.Text == "")
            {
                lbsexo.Visible = true;
                return false;
            }
           
            if (txttelefono.Text == "")
            {
                lbtelefono.Visible = true;
                return false;
            }
            if (txtdireccion.Text == "")
            {
                lbdireccion.Visible = true;
                return false;
            }
            if (txtsueldo.Text == "")
            {
                lbsueldo.Visible = true;
                return false;
            }
            if (txtcargo.Text == "")
            {
                lbcargo.Visible = true;
                return false ;
            }
            if (txtcedula.Text=="")
            {
                lbcedula.Visible = true;
                
                return false;
            }
            return true;
            
        }



        //***********************************************************************************//
        // Restablecer valores de los lb de validacion//
        //***********************************************************************************//


        private  void Validarok()
        {
             lbnombre.Visible = false;
             lbapellido.Visible = false; 
             lbsexo.Visible = false;
             lbtelefono.Visible = false;
             lbdireccion.Visible = false;
             lbsueldo.Visible = false;
             lbcargo.Visible = false;
             lbcedula.Visible = false;
        
        }


        // ************************************************************************************** \\
        // Esta linea de codigo representa el metodo visualizar() el cual nos va a mostrar los 
        // cuadros de textos que se van a registrar en la tabla referencia de la base de datos 
        // ************************************************************************************** \\

        private void visualizar()
        {
            groupBox3.Visible = true;
            
        }



        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo obtener() el cual nos va a permitir obtener
        // los datos de empledo que se van a vizualizar en los cuadros de texto del formulario de dicho modulo
        // *************************************************************************************** \\

        private void obtener()
        {     
         // ******************************************************************************** ||
         // Estos son los cuadros de textos que son llenado con su respetiva informacion
         // ******************************************************************************** ||

            txtnombre.Text = dgvempleado.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dgvempleado.CurrentRow.Cells[2].Value.ToString();
            cbsexo.Text = dgvempleado.CurrentRow.Cells[3].Value.ToString();
            txtcedula.Text = dgvempleado.CurrentRow.Cells[4].Value.ToString();
            dtpfecha_n.Text = dgvempleado.CurrentRow.Cells[5].Value.ToString();
            txttelefono.Text = dgvempleado.CurrentRow.Cells[6].Value.ToString();
            txtcorreo.Text = dgvempleado.CurrentRow.Cells[7].Value.ToString();
            txtdireccion.Text = dgvempleado.CurrentRow.Cells[8].Value.ToString();
            txtsueldo.Text = dgvempleado.CurrentRow.Cells[9].Value.ToString();
            dtpfecha_c.Text = dgvempleado.CurrentRow.Cells[10].Value.ToString();
            txtcargo.Text = dgvempleado.CurrentRow.Cells[11].Value.ToString();
            txtreferencia_n.Text = dgvempleado.CurrentRow.Cells[12].Value.ToString();
            txtreferencia_a.Text = dgvempleado.CurrentRow.Cells[13].Value.ToString();
            txtreferencia_t.Text = dgvempleado.CurrentRow.Cells[14].Value.ToString();
            txtruta.Text = dgvempleado.CurrentRow.Cells[15].Value.ToString();
            pictureBox1.Image = Image.FromFile(txtruta.Text);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo obtenerlbl() el cual nos va a permitir obtener
        // los datos de empledo que se van a vizualizar en los label del formulario de dicho modulo
        // *************************************************************************************** \\

        private void obtenerlbl()
        {
            // ******************************************************************************** ||
            // Estos son los label de textos que son llenado con su respetiva informacion
            // ******************************************************************************** ||
            lblnombre.Text = dgvempleado.CurrentRow.Cells[1].Value.ToString();
            lblapellido.Text = dgvempleado.CurrentRow.Cells[2].Value.ToString();
            lblsexo.Text = dgvempleado.CurrentRow.Cells[3].Value.ToString();
            lblcedula.Text = dgvempleado.CurrentRow.Cells[4].Value.ToString();
            lblfecha_n.Text = dgvempleado.CurrentRow.Cells[5].Value.ToString();
            lbltelefono.Text = dgvempleado.CurrentRow.Cells[6].Value.ToString();
            lblcorreo.Text = dgvempleado.CurrentRow.Cells[7].Value.ToString();
            lbldireccion.Text = dgvempleado.CurrentRow.Cells[8].Value.ToString();
            lblsueldo.Text = dgvempleado.CurrentRow.Cells[9].Value.ToString();
            auxiliar = dgvempleado.CurrentRow.Cells[15].Value.ToString();
            pictureBox2.Image = Image.FromFile(auxiliar);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            

        }

        // ********************************************************************************************* \\
        // Este linea de codigo representa el metodo obtenerid() el cual nos va a permitir obtener 
        // el id del empleado seleccionado para luego ser utilizado de diversas formas como eliminar, etc
        // ********************************************************************************************** \\

        private void obtenerid()
        {
            if (dgvempleado.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Debe de seleccionar una fila con datos");
            }
            else
            {
            ce.Id_empleado = Convert.ToInt32(dgvempleado.CurrentRow.Cells[0].Value);  
            }
        }

        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo pasarvalor() el cual nos va a permitir obtener
        // los datos de los diferentes cuadro de textos que tiene el formulario empleado para luego
        // ser registrado en la tabla empleado de la base de datos
        // *************************************************************************************** \\

        private void pasarvalor()
        {   
            ce.Nombre = txtnombre.Text;
            ce.Apellido = txtapellido.Text;
            ce.Correo = txtcorreo.Text;
            ce.Direccion = txtdireccion.Text;
            ce.Fecha_nac = dtpfecha_n.Value.ToString();
            ce.Cedula = txtcedula.Text;
            ce.Fecha_contrato = dtpfecha_c.Value.ToString();
            ce.Telefono = txttelefono.Text;
            ce.Sexo = cbsexo.Text;
            ce.Sueldo = Double.Parse(txtsueldo.Text);
            ce.Cargo = txtcargo.Text;
            ce.Ruta = txtruta.Text;
            r.Nombre = txtreferencia_n.Text;
            r.Apellido = txtreferencia_a.Text;
            r.Telefono = txtreferencia_t.Text;
        }

        // ******************************************************************************* \\
        // Esta linea de codigo representa el metodo limpiar() el cual nos va a permitir 
        // limpiar todos los cuadros de textos del formulario cuando llamemo a este
        // ******************************************************************************* \\

        private void limpiar()
        {
            txttelefono.Text = "";
            txtsueldo.Text = "";
            txtruta.Text = "";
            txtreferencia_t.Text = "";
            txtreferencia_n.Text = "";
            txtreferencia_a.Text = "";
            txtnombre.Text = "";
            txtfiltro.Text = "";
            txtdireccion.Text = "";
            txtcorreo.Text = "";
            txtcedula.Text = "";
            txtcargo.Text = "";
            txtapellido.Text = "";
            cbsexo.Text = "";
            pictureBox1.Image = Properties.Resources.iconousuario;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            dtpfecha_c.ResetText();
            dtpfecha_n.ResetText();
            
        }

        // **************************************************************************************************** ||
        // Esta linea de codigo representa el metodo limpiarlbl() el cual nos va permitir limpiar los label
        // que se encuentra en tabpage2 en este formulario
        // **************************************************************************************************** ||

        private void limpiarlbl()
        {
            lblapellido.Text = "_______________________";
            lblnombre.Text = "_______________________";
            lblcedula.Text = "_______________________";
            lblcorreo.Text = "_______________________";
            lbldireccion.Text = "______________________________________________________________________";
            lblfecha_n.Text = "_______________________";
            lblsexo.Text = "_______________________";
            lblsueldo.Text = "_______________________";
            lbltelefono.Text = "_______________________";
            pictureBox2.Image = Properties.Resources.iconousuario;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btnregistrar el cual va a utilizar para guardar los datos en la bd
        // ******************************************************************* \\

        private void btnregistrar_Click(object sender, EventArgs e)
        {
           
            // *************************************** \\
            // Esta linea de codigo representa la 
            // llamada del metodo pasarvalor el cual
            // nos va dar los datos del los cuadro_textos
            // *************************************** \\
            pasarvalor();

            // ************************************************************************************************************ \\
            // Esta linea de codigo representa la insercciones de los datos en las diferentes tablas de la base de datos 
            // ************************************************************************************************************ \\

                // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

            if (Validartext() == true)
            {

                if (new CLImagen().insertarimg(ce.Ruta))
                {

                    if (new ControlDB().generarInsert(new string[] { "rnombre", "rapellido", "rtelefono" }, new string[]{r.Nombre, r.Apellido,
                                                  r.Telefono}, "referencia"))
                    {

                        if (new ControlDB().generarInsert(new string[]{"nombre", "apellido", "Sexo", "fecha_nac", "telefono", "correo", "direccion", 
                                              "sueldo", "fecha_contrato", "cargo", "cedula"}, new string[]{ce.Nombre, ce.Apellido, ce.Sexo, 
                                               ce.Fecha_nac.ToString(), ce.Telefono, ce.Correo, ce.Direccion, ce.Sueldo.ToString(), 
                                               ce.Fecha_contrato, ce.Cargo, ce.Cedula}, "empleado"))
                        {
                            MessageBox.Show("Los datos se han registrado correctamente");
                            Validarok();
                            limpiar();
                            consulta();

                        }
                        else
                        {
                            MessageBox.Show("Error al registrar los datos solicitados");
                        }
                    }
                }
            }
            else {
                MessageBox.Show(" todos los campos vacio", "Completar",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||
            
            
        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btnruta el cual va a utilizar para obtener la ruta le la imagen y esta
        // ******************************************************************* \\

        private void btnruta_Click(object sender, EventArgs e)
        {
            abrir.Title = "buscar imagen";
            abrir.Filter = "Jpg files (*.jpg )|*.jpg| GIF files (*.gif)|*.gif|Bitmap files (*.Bmp)|*.bmp|PNG files (*.png)|*.png";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                ce.Ruta = abrir.FileName;
                pictureBox1.Image = Image.FromFile(abrir.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                txtruta.Text = ce.Ruta;
            }
        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btnlimpiar el cual va a utilizar para limpiar todos los cuadros_textos
        // ******************************************************************* \\

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btnmodificar el cual va a utilizar para modificar los datos socilitados
        // en la base de datos dblavanderia
        // ******************************************************************* \\

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            pasarvalor();
            obtenerid();
            
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||
            
             if(new ControlDB().modificar("empleado", "e inner join imagen i on e.id_imagen = i.id_imagen inner join referencia r on r.id_referencia = e.id_referencia",
                                          ce.Id_empleado.ToString(), "e.id_empleado", new string[]{"e.nombre", "e.apellido", "e.Sexo", "e.cedula", "e.fecha_nac", "e.telefono",
                                              "e.correo", "e.direccion", "e.sueldo", "e.fecha_contrato", "e.cargo", "r.rnombre", "r.rapellido", "r.rtelefono"}, 
                                              new string[]{ce.Nombre, ce.Apellido, ce.Sexo, ce.Cedula, ce.Fecha_nac.ToString(), ce.Telefono, ce.Correo, ce.Direccion, ce.Sueldo.ToString(), 
                                               ce.Fecha_contrato, ce.Cargo, r.Nombre, r.Apellido, r.Telefono}))
             {
                 if (new CLImagen().modificar(ce.Ruta,"empleado ", ce.necesito(ce.Id_empleado)))
                 {
                     MessageBox.Show("Datos Modificados Correctamente");
                     consulta();
                     limpiar();
                     
                     metroTabControl1.SelectedTab = metroTabPage2;
                 }
                 else
                 {
                     MessageBox.Show("Error al Modificar los datos solictados");
                 }
                 
             }
             

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                metroTabControl1.SelectedTab = metroTabPage1;
                btnmodificar.Enabled = true;
                obtener();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        // evento para solo permitir letra
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }






            
        }
               // evento para solo permitir letra
        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {      
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }


        }

        private void dgvempleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerid();
            obtenerlbl();
            btneliminar.Enabled = true;
            btneditar.Enabled = false;
        }

        private void dgvempleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerlbl();
            btneditar.Enabled = true;
            btneliminar.Enabled = false;
            btnregistrar.Enabled = false;
            btnlimpiar.Enabled = false;
            btnsalir.Enabled = false;
        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btneliminar el cual va a utilizar para eliminar los datos socilitados
        // desde el formulario empleado en la base de datos dblavanderia
        // ******************************************************************* \\

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

            obtenerid();
            if (new ControlDB().eliminar("empleado", ", imagen, referencia from empleado"+
                "  inner join imagen  on imagen.id_imagen = empleado.id_imagen inner join "+
                "referencia  on referencia.id_referencia = empleado.id_referencia", 
                "empleado.id_empleado", ce.Id_empleado.ToString()))
            {
                MessageBox.Show("Datos eliminado correctamente");
                consulta();
            }
            else
            {
                MessageBox.Show("Error al eliminar los datos socilitados");
            }

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsalir2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked == true)
            {
                visualizar();
            }
            else
            {
                groupBox3.Visible = false;
            }
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 0)
            {
                limpiarlbl();
                if (metroToggle1.Checked == false)
                {
                    metroToggle1.Checked = true;
                }
            }
            else if(metroTabControl1.SelectedIndex == 1) {
                limpiar();
                try
                {
                    
                    btnmodificar.Enabled = false;
                    btnlimpiar.Enabled = true;
                    btnsalir.Enabled = true;
                    btnregistrar.Enabled = true;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                
                
            }
        }

        private void txtsueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcargo_KeyPress(object sender, KeyPressEventArgs e)
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

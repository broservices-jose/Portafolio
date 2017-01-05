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
    public partial class Cliente : MetroForm
    {       
        public Cliente()
        {
            InitializeComponent();
            Consultar();
            dgvcliente.Columns[0].Visible = false;
            cbsexo.Items.Add("Masculino");
            cbsexo.Items.Add("Femenino");
            metroTabControl1.SelectedTab = metroTabPage1;
        }
        // *************************************************************************************** \\
        // Esta linea de codigo representa la creacion o instanciacion de los objectos da las 
        // diferentes clases que van interactuar con la base de datos fulanita
        // *************************************************************************************** \\
        ControlDB cb = new ControlDB();
        CLCliente cli = new CLCliente();
        OpenFileDialog abrir = new OpenFileDialog();
        private string auxiliar;

        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo consulta() el cual nos va ha atraer todos los 
        // datos de las tablas empleados, imagen y referencia para llenar el datagridview dgvempleado
        // *************************************************************************************** \\


      private bool validartxt() {
          if (txtnombre.Text=="")
          {
              lbnombre.Visible = true;
              return false;
  
          }
          if (txtapellido.Text=="")
          {
              lbapellido.Visible = true;
              return false;
          }
          if (txtdireccion.Text=="")
          {
              lbdireccion.Visible = true;
              return false;
          }
          if (txttelefono.Text=="")
          {
              lbtelefono.Visible = true;
              return false;
          }
          if (cbsexo.Text=="")
          {
              lbsexo.Visible = true;
              return false;
          }


          return true;
      }

      private void Consultar() {
          dgvcliente.DataSource = new CLCliente().Consultar();
      
      }

      private void obtenerid()
      {
          if (dgvcliente.CurrentRow.Cells[0].Value.ToString() == string.Empty)
          {
              MessageBox.Show("Debe de seleccionar una fila con datos");
          }
          else 
          { 
              cli.Id_cliente = Convert.ToInt32(dgvcliente.CurrentRow.Cells[0].Value);  
          }
      }

      private void pasarvalor() {

          cli.Nombre = txtnombre.Text;
          cli.Apellido = txtapellido.Text;
          cli.Cedula = txtcedula.Text;
          cli.Direccion = txtdireccion.Text;
          cli.Telefono = txttelefono.Text;
          cli.Sexo = cbsexo.Text;
          cli.Correo = txtcorreo.Text;
          cli.Comentario = txtcomentario.Text;
          cli.Ruta = txtruta.Text;
      
      }

        // metodo para limpiar los controles
      private void limpiar() {
          txtnombre.Text = "";
          txtapellido.Text = "";
          txtcedula.Text = "";
          txtdireccion.Text = "";
          txttelefono.Text = "";
          cbsexo.Items.Clear();
          txtcorreo.Text = "";
          txtcomentario.Text = "";
          txtruta.Text = "";
          cbsexo.Text = "";
          txtnombre.Focus();
          pictureBox1.Image = Properties.Resources.iconousuario;
          pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

      }


        // ******************************************************************************* ||
        // Esta linea de codigo representa el metodo limpiarlbl() el cual nos va a permiitr
        // limpiar los label de formulario
        // ******************************************************************************* ||

      private void limpiarlbl()
      {
          lblapellido.Text = "_______________________";
          lblnombre.Text = "_______________________";
          lblcedula.Text = "_______________________";
          lblcomentario.Text = "_____________________________________________________________________";
          lbldireccion.Text = "_____________________________________________________________________";
          lblsexo.Text = "______________________________";
          lbltelefono.Text = "______________________________";
          lblcorreo.Text = "______________________________";
          pictureBox2.Image = Properties.Resources.iconousuario;
          pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
      }
     
        // ************************************************************************************* ||
        // Esta linea de codigo representa el metodopasarvalorlabel()el cual le pasamos el valor de 
        // los datagriwview a los label
        // ************************************************************************************* ||
        
        private void pasarvalorlabel() {

            if (dgvcliente.CurrentRow.Cells[9].Value.ToString() == "" ||
                dgvcliente.CurrentRow.Cells[9].Value.ToString() == "no disponible")
            {
                lblnombre.Text = dgvcliente.CurrentRow.Cells[1].Value.ToString();
                lbapellido.Text = dgvcliente.CurrentRow.Cells[2].Value.ToString();
                lblcedula.Text = dgvcliente.CurrentRow.Cells[4].Value.ToString();
                lbdireccion.Text = dgvcliente.CurrentRow.Cells[7].Value.ToString();
                lbltelefono.Text = dgvcliente.CurrentRow.Cells[5].Value.ToString();
                lblsexo.Text = dgvcliente.CurrentRow.Cells[3].Value.ToString();
                lblcorreo.Text = dgvcliente.CurrentRow.Cells[6].Value.ToString();
                lblcomentario.Text = dgvcliente.CurrentRow.Cells[8].Value.ToString();
            }
            else
            {
                lblnombre.Text = dgvcliente.CurrentRow.Cells[1].Value.ToString();
                lbapellido.Text = dgvcliente.CurrentRow.Cells[2].Value.ToString();
                lblcedula.Text = dgvcliente.CurrentRow.Cells[4].Value.ToString();
                lbdireccion.Text = dgvcliente.CurrentRow.Cells[7].Value.ToString();
                lbltelefono.Text = dgvcliente.CurrentRow.Cells[5].Value.ToString();
                lblsexo.Text = dgvcliente.CurrentRow.Cells[3].Value.ToString();
                lblcorreo.Text = dgvcliente.CurrentRow.Cells[6].Value.ToString();
                lblcomentario.Text = dgvcliente.CurrentRow.Cells[8].Value.ToString();
                auxiliar = dgvcliente.CurrentRow.Cells[9].Value.ToString();
                pictureBox2.Image = Image.FromFile(auxiliar);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }

      }
         //metodo para llenar los txt  para editar
      private void obtenerdatos() {

          if (dgvcliente.CurrentRow.Cells[9].Value.ToString() == "" ||
              dgvcliente.CurrentRow.Cells[9].Value.ToString() == "no disponible")
          {
              txtnombre.Text = dgvcliente.CurrentRow.Cells[1].Value.ToString();
              txtapellido.Text = dgvcliente.CurrentRow.Cells[2].Value.ToString();
              cbsexo.Text = dgvcliente.CurrentRow.Cells[3].Value.ToString();
              txtcedula.Text = dgvcliente.CurrentRow.Cells[4].Value.ToString();
              txttelefono.Text = dgvcliente.CurrentRow.Cells[5].Value.ToString();
              txtcorreo.Text = dgvcliente.CurrentRow.Cells[6].Value.ToString();
              txtdireccion.Text = dgvcliente.CurrentRow.Cells[7].Value.ToString();
              txtcomentario.Text = dgvcliente.CurrentRow.Cells[8].Value.ToString();
              txtruta.Text = dgvcliente.CurrentRow.Cells[9].Value.ToString();
          }
          else
          {
              txtnombre.Text = dgvcliente.CurrentRow.Cells[1].Value.ToString();
              txtapellido.Text = dgvcliente.CurrentRow.Cells[2].Value.ToString();
              cbsexo.Text = dgvcliente.CurrentRow.Cells[3].Value.ToString();
              txtcedula.Text = dgvcliente.CurrentRow.Cells[4].Value.ToString();
              txttelefono.Text = dgvcliente.CurrentRow.Cells[5].Value.ToString();
              txtcorreo.Text = dgvcliente.CurrentRow.Cells[6].Value.ToString();
              txtdireccion.Text = dgvcliente.CurrentRow.Cells[7].Value.ToString();
              txtcomentario.Text = dgvcliente.CurrentRow.Cells[8].Value.ToString();
              txtruta.Text = dgvcliente.CurrentRow.Cells[9].Value.ToString();
              pictureBox1.Image = Image.FromFile(txtruta.Text);
              pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
          }
          

      
      
      }
        private void metroTabPage2_Click(object sender, EventArgs e)
        {
            btnregistrar.Enabled = true;
            btnlimpiar.Enabled = true;
            btnsalir2.Enabled = true;
            btnmodificar.Enabled = false;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
          //  if (new ControlDB().generarInsert(new string[] { "ruta" }, new string[] { i.Ruta }, "imagen"))
            //{
            pasarvalor();

            if (new CLImagen().insertarimg(cli.Ruta))
            {
                if (new ControlDB().generarInsert(new string[] { "nombre", "apellido", "sexo", "cedula", "telefono", "correo", "direccion", "comentario" }, new string[]{cli.Nombre, cli.Apellido, cli.Sexo, 
                       cli.Cedula  , cli.Telefono, cli.Correo, cli.Direccion, cli.Comentario, }, "cliente"))
                {
                    MessageBox.Show("Los datos se han registrado correctamente");
                    //   Validarok();
                    limpiar();
                    Consultar();

                }
                else
                {
                    MessageBox.Show("Error al registrar los datos solicitados");
                }
            }

        }

        private void btnruta_Click(object sender, EventArgs e)
        {
            abrir.Title = "buscar imagen";
            abrir.Filter = "Jpg files (*.jpg )|*.jpg| GIF files (*.gif)|*.gif|Bitmap files (*.Bmp)|*.bmp|PNG files (*.png)|*.png";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                cli.Ruta = abrir.FileName;
                pictureBox1.Image = Image.FromFile(cli.Ruta);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                txtruta.Text = cli.Ruta;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
                metroTabControl1.SelectedTab = metroTabPage1;
                limpiar();
                btnregistrar.Enabled = false;
                btnlimpiar.Enabled = false;
                btnmodificar.Enabled = true;
                btnsalir2.Enabled = false;
                obtenerdatos();

        }

        // ************************************************************************** ||
        // Esta linea de codigo representa el evento click del boton btneliminar el 
        // cual vamos utilizar para eliminar los datos socilitados por el usuario  
        // ************************************************************************** ||

        private void btneliminar_Click(object sender, EventArgs e)
        {    obtenerid();
        if (new ControlDB().eliminar("from cliente", "", "id_cliente", cli.Id_cliente.ToString()))
        {
            MessageBox.Show("Datos eliminados correctamente");
            Consultar();
            
        }
        else
        {
            MessageBox.Show("Error al eliminar los datos solicitados");
        }

          
        }

        // ************************************************************************** ||
        // Esta linea de codigo representa el evento click del boton btnmodificar el 
        // cual utilizamos para modificar los datos socilitados por el usuario
        // ************************************************************************** ||

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            pasarvalor();
            obtenerid();

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

            if (new ControlDB().modificar("cliente", "c inner join imagen i on i.id_imagen = c.id_imagen", "c.id_cliente", cli.Id_cliente.ToString(), 
                new string[] { "c.nombre", "c.apellido", "c.sexo","c.cedula","c.telefono","c.correo","c.direccion","c.comentario" },
                new string[] { cli.Nombre, cli.Apellido, cli.Sexo, cli.Cedula, cli.Telefono, cli.Correo, cli.Direccion,cli.Comentario }))
            {      
                if (new CLImagen().modificar(cli.Ruta, "cliente ", cli.necesito(cli.Id_cliente)))
                {
                    MessageBox.Show("Los datos se han modificados correctamente");
                    Consultar();
                    limpiar();
                    metroTabControl1.SelectedTab = metroTabPage2;
               
                }

                else
                {
                    MessageBox.Show("Error al modificar los datos seleccionado ");
                }
            }
            



        }

        private void dgvcliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pasarvalorlabel();
            btneditar.Enabled = true;
            btneliminar.Enabled = false;
        }

        private void dgvcliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pasarvalorlabel();
            btneditar.Enabled = false;
            btneliminar.Enabled = true;
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
                btnregistrar.Enabled = true;
                btnlimpiar.Enabled = true;
                btnmodificar.Enabled = false;
                btnsalir2.Enabled = true;
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void Cliente_Load_1(object sender, EventArgs e)
        {

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtcomentario_KeyPress(object sender, KeyPressEventArgs e)
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

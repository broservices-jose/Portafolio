using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDiagramaClase
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
            controles();
            consultar();
            dgvcliente.Columns[0].Visible = false;
            dgvmostrarcl.Columns[0].Visible = false;
        }


        private void consultar()
        {
            dgvcliente.DataSource = new Cliente().consultar();
            dgvmostrarcl.DataSource = new Cliente().consultar();
            
            //  dgvcliente.DataSource = new Persona().consular();
           //pictureBox1.DataBindings = new Imagen().consultar();
        }


        string id;
        DataSet registros = new DataSet();
        OpenFileDialog abrir = new OpenFileDialog();
        OpenFileDialog open = new OpenFileDialog();
        int cantidadregistro;

        private void obtenerid()
        {
            cl.Id_cliente = Convert.ToInt32(dgvcliente.CurrentRow.Cells[0].Value);
        }

        
        private void obtenerdatos()
        {
            obtenerid();
         //   pasarvalores();
            txtnombre.Text = dgvcliente.CurrentRow.Cells[1].Value.ToString() ;
            txtapellido.Text = dgvcliente.CurrentRow.Cells[2].Value.ToString();
            cbsexo.Text = dgvcliente.CurrentRow.Cells[3].Value.ToString() ;
            dtpnacimiento.Text = dgvcliente.CurrentRow.Cells[4].Value.ToString() ;
            txttelefono.Text = dgvcliente.CurrentRow.Cells[5].Value.ToString() ;
            txtcorreo.Text = dgvcliente.CurrentRow.Cells[6].Value.ToString();
            txtdireccion.Text = dgvcliente.CurrentRow.Cells[7].Value.ToString();
            txtnacionalidad.Text = dgvcliente.CurrentRow.Cells[8].Value.ToString();
            txttrato.Text = dgvcliente.CurrentRow.Cells[9].Value.ToString();
            txtdocumento.Text = dgvcliente.CurrentRow.Cells[10].Value.ToString();
            txtnodocumento.Text = dgvcliente.CurrentRow.Cells[11].Value.ToString();
            rtbcomentarios.Text = dgvcliente.CurrentRow.Cells[12].Value.ToString();
            txtrnc.Text = dgvcliente.CurrentRow.Cells[13].Value.ToString();
            txtnfc.Text = dgvcliente.CurrentRow.Cells[14].Value.ToString();
            txtruta.Text = dgvcliente.CurrentRow.Cells[16].Value.ToString();
            Bitmap Picture = new Bitmap(txtruta.Text);
            pictureBox1.Image = (Image)Picture;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // dgvcliente.CurrentRow.Cells[15].Value.ToString();
        }


        private void filtrado(string filtro)
        {
            dgvmostrarcl.DataSource = new Cliente().filtrar(filtro);
        }
        private void filtrado1(string filtro)
        {
            dgvmostrarcl.DataSource = new Cliente().filtrar1(filtro);
        }
        private void filtrado2(string filtro)
        {
            dgvmostrarcl.DataSource = new Cliente().filtrar2(filtro);
        }

        private void controles()
        {
            this.txtcodigo.Clear();
            this.txtnombre.Clear();
            this.txtapellido.Clear();
            this.txtcorreo.Clear();
            this.txtdireccion.Clear();
            this.txtdocumento.Clear();
            this.txtnodocumento.Clear();
            this.txttelefono.Clear();
            this.txtruta.Clear();
            this.txtnfc.Clear();
            this.txtrnc.Clear();
            this.rtbcomentarios.Clear();
            this.txttrato.Clear();
            this.cbsexo.Text = "";
            this.txtnacionalidad.Clear();
            this.btncancelar.Enabled = false;
            this.btnmodificar.Enabled = false;
        }
        Cliente cl = new Cliente();

        Imagen ma = new Imagen();

        private void pasarvalores()
        {
           cl.Tipo_cliente = "Llenar requisito";
            cl.Nombre = txtnombre.Text;
           // cl.Id_cliente = Convert.ToInt32(txtcodigo.Text);
            cl.Tipo_documento = txtdocumento.Text;
            cl.Trato = txttrato.Text;
            cl.Num_documento = txtnodocumento.Text;
            cl.Apellido = txtapellido.Text;
            cl.Sexo = cbsexo.Text;
            cl.Nacimiento = dtpnacimiento.Value;
            cl.Telefono = txttelefono.Text;
            cl.Correo = txtcorreo.Text;
            cl.Direccion = txtdireccion.Text;
            cl.Nacionalidad = txtnacionalidad.Text;
            cl.Comentarios = rtbcomentarios.Text;
            cl.Rnc = txtrnc.Text;
            cl.Nfc = txtnfc.Text;
            cl.Id_persona = 32323;
            ma.Tipo_imagen = "cliente";
            
       }



        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            cbsexo.Items.Add("Masculino");
            cbsexo.Items.Add("Femenino");
        }

   



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            abrir.Title = "abri mienda";
            abrir.Filter = "Jpg files (*.jpg )|*.jpg| GIF files (*.gif)|*.gif|Bitmap files (*.Bmp)|*.bmp|PNG files (*.png)|*.png";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                ma.Imagen1 = abrir.FileName;
                Bitmap picture = new Bitmap(ma.Imagen1);
                pictureBox1.Image = (Image)picture;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                id = abrir.SafeFileName;
                txtruta.Text = id;
            }
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
           pasarvalores();

            if (new Persona().insertar(new string[] { cl.Trato.ToString(), cl.Tipo_documento.ToString(), cl.Num_documento.ToString(), cl.Nombre.ToString(), cl.Apellido.ToString(), cl.Sexo.ToString(), cl.Nacimiento.ToString(), cl.Telefono.ToString(), cl.Correo.ToString(), cl.Direccion.ToString(), cl.Nacionalidad.ToString() }))
            {
                MessageBox.Show("Registro Ingresado Exitosamente en persona");
            }
            else
            {
                MessageBox.Show("Error al Insertar los datos en Persona");
            }

            if (new Imagen().registrar(ma.Imagen1.ToString(), ma.Tipo_imagen.ToString()))
            {
                MessageBox.Show("Registro Ingresado Exitosamente");
            }
            else
            {
                MessageBox.Show("Error al Insertar la imagen seleccionada");
            }

            controles();
            if (new Cliente().ingresar(new string[] { cl.Comentarios.ToString(), cl.Rnc.ToString(), cl.Nfc.ToString(), cl.Tipo_cliente.ToString() }))
            {
                MessageBox.Show("Registro Ingresado Exitosamente");
                consultar();
            }
            else
            {
                MessageBox.Show("Error al Insertar los datos en Cliente");
            }
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistroVehiculo rv = new RegistroVehiculo();
            rv.Show();
        }
        
        private void tabPage2_Click(object sender, EventArgs e)
        {
            

           
        }

        private void dgvmostrarcl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerdatos();
            this.btncancelar.Enabled = false;
            this.btnmodificar.Enabled = true;
        }

        private void dgvmostrarcl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controles();
            obtenerid();
            this.btncancelar.Enabled = true;
            
            lblcodigo.Text = dgvmostrarcl.CurrentRow.Cells[0].Value.ToString();
            lblnombre.Text = dgvmostrarcl.CurrentRow.Cells[1].Value.ToString();
            lblapellido.Text = dgvmostrarcl.CurrentRow.Cells[2].Value.ToString();
            lblsexo.Text = dgvmostrarcl.CurrentRow.Cells[3].Value.ToString();
            lblfecha_nac.Text = dgvmostrarcl.CurrentRow.Cells[4].Value.ToString();
            lbltelefono.Text = dgvmostrarcl.CurrentRow.Cells[5].Value.ToString();
            lblcorreo.Text = dgvmostrarcl.CurrentRow.Cells[6].Value.ToString();
            lbldireccion.Text = dgvmostrarcl.CurrentRow.Cells[7].Value.ToString();
            lblnacionalidad.Text = dgvmostrarcl.CurrentRow.Cells[8].Value.ToString();
            lbltrato.Text = dgvmostrarcl.CurrentRow.Cells[9].Value.ToString();
            lbltipo_doc.Text = dgvmostrarcl.CurrentRow.Cells[10].Value.ToString();
            lblnun_doc.Text = dgvmostrarcl.CurrentRow.Cells[11].Value.ToString();
            lblcomentarios.Text = dgvmostrarcl.CurrentRow.Cells[12].Value.ToString();
            lblrnc.Text = dgvmostrarcl.CurrentRow.Cells[13].Value.ToString();
            lblnfc.Text = dgvmostrarcl.CurrentRow.Cells[14].Value.ToString();
            lbltipocliente.Text = dgvmostrarcl.CurrentRow.Cells[15].Value.ToString();
            Bitmap Picture = new Bitmap(dgvmostrarcl.CurrentRow.Cells[16].Value.ToString());
            pictureBox3.Image = (Image)Picture;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
          // pictureBox3.Image = System.Drawing.Image.FromFile(ma.Imagen1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            if (rbid.Checked == true)
            {
                filtrado1(this.txtfiltrar.Text);
            }
            else if (rbnombre.Checked == true)
            {
                filtrado(this.txtfiltrar.Text);
            }
            else if (rbapellido.Checked == true)
            {
                filtrado2(this.txtfiltrar.Text);
            }
        }

        private void dgvcliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerdatos();
            this.btncancelar.Enabled = false;
            this.btnmodificar.Enabled = true;
        }

        private void dgvcliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controles();
            obtenerid();
            this.btncancelar.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            controles();
            if (new Cliente().eliminar(cl.Id_cliente))
            {
                MessageBox.Show("Registro Eliminado Correctamente");
                consultar();
            }

            else
            {
                MessageBox.Show("Error al Eliminar ");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (new Cliente().modificar(new object[] { cl.Id_cliente.ToString(), cl.Nombre, cl.Apellido, cl.Sexo, cl.Nacimiento, cl.Telefono, cl.Correo, cl.Direccion, cl.Nacionalidad, cl.Trato, cl.Tipo_documento, cl.Num_documento, cl.Comentarios, cl.Rnc, cl.Nfc, cl.Tipo_cliente, ma.Imagen1 }))
            {
                MessageBox.Show("Registro Actualizado Correctamente");
                consultar();
            }

            else
            {
                MessageBox.Show("Error al Actualizar");
            }
            controles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (new Cliente().modificar(new object[] { cl.Id_cliente.ToString(), cl.Nombre, cl.Apellido, cl.Sexo, cl.Nacimiento, cl.Telefono, cl.Correo, cl.Direccion, cl.Nacionalidad, cl.Trato, cl.Tipo_documento, cl.Num_documento, cl.Comentarios, cl.Rnc, cl.Nfc, cl.Tipo_cliente, ma.Imagen1 }))
            {
                MessageBox.Show("Registro Actualizado Correctamente");
                consultar();
            }

            else
            {
                MessageBox.Show("Error al Actualizar");
            }
            controles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controles();
            if (new Cliente().eliminar(cl.Id_cliente))
            {
                MessageBox.Show("Registro Eliminado Correctamente");
                consultar();
            }

            else
            {
                MessageBox.Show("Error al Eliminar ");
            }
        }


        private void dgvmostrarcl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerdatos();
            this.btncancelar.Enabled = false;
            this.btnmodificar.Enabled = true;
        }


        

       


    }
}

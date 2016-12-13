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
        string[] valor;

        private void obtenerid()
        {
            cl.Id_cliente = Convert.ToInt32(dgvcliente.CurrentRow.Cells[0].Value);
        }
        
        private void obtenerdatos()
        {
            obtenerid();
            pasarvalores();
           // cl.Id_persona = Convert.ToInt32( dgvcliente.CurrentRow.Cells[1].Value);
            cl.Comentarios = dgvcliente.CurrentRow.Cells[1].Value.ToString() ;
            cl.Rnc = dgvcliente.CurrentRow.Cells[2].Value.ToString();
            cl.Nfc = dgvcliente.CurrentRow.Cells[3].Value.ToString() ;
            cl.Tipo_cliente = dgvcliente.CurrentRow.Cells[4].Value.ToString() ;
            cl.Trato = dgvcliente.CurrentRow.Cells[5].Value.ToString() ;
            cl.Tipo_documento = dgvcliente.CurrentRow.Cells[6].Value.ToString();
            cl.Num_documento = dgvcliente.CurrentRow.Cells[7].Value.ToString();
            cl.Nombre = dgvcliente.CurrentRow.Cells[8].Value.ToString();
            cl.Apellido = dgvcliente.CurrentRow.Cells[9].Value.ToString();
            cl.Sexo = dgvcliente.CurrentRow.Cells[10].Value.ToString();
            cl.Nacimiento = dgvcliente.CurrentRow.Cells[11].Value.ToString();
            cl.Telefono = dgvcliente.CurrentRow.Cells[12].Value.ToString();
            cl.Correo = dgvcliente.CurrentRow.Cells[13].Value.ToString();
            cl.Direccion = dgvcliente.CurrentRow.Cells[14].Value.ToString();
            cl.Nacimiento = dgvcliente.CurrentRow.Cells[15].Value.ToString();
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
            cl.Nacimiento = dateTimePicker1.Value.Year + "/"+ dateTimePicker1.Value.Month+ "/"+ dateTimePicker1.Value.Day;
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

            if (new Persona().insertar(new string[] { cl.Trato, cl.Tipo_documento, cl.Num_documento, cl.Nombre, cl.Apellido, cl.Sexo, cl.Nacimiento.ToString(), cl.Telefono, cl.Correo, cl.Direccion, cl.Nacionalidad }))
            {
                MessageBox.Show("Registro Ingresado Exitosamente en persona");
                consultar();
            }
            else
            {
                MessageBox.Show("Error al Insertar los datos en Persona");
            }

            if (new Imagen().registrar(ma.Imagen1, ma.Tipo_imagen))
            {
                MessageBox.Show("Registro Ingresado Exitosamente");
                consultar();
            }
            else
            {
                MessageBox.Show("Error al Insertar la imagen seleccionada");
            }

            controles();
            if (new Cliente().ingresar(new string[] { cl.Comentarios.ToString(), cl.Rnc.ToString(), cl.Nfc.ToString(), cl.Tipo_cliente }))
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
            

            registros = new Imagen().numeroregistro();
            cantidadregistro = registros.Tables[0].Rows.Count;
            for (int i = 0; i < cantidadregistro; i++)
            {
                dgvmostrarcl.Rows.Add(registros.Tables[0].Rows[i]["id"].ToString());

            }
            registros.Clear();
            MessageBox.Show("Registro encontrado");

        }

        private void dgvmostrarcl_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvmostrarcl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblnombre.Text = dgvmostrarcl.CurrentRow.Cells[0].Value.ToString();
            lblapellido.Text = dgvmostrarcl.CurrentRow.Cells[1].Value.ToString();
            lblsexo.Text = dgvmostrarcl.CurrentRow.Cells[2].Value.ToString();
            lblfecha_nac.Text = dgvmostrarcl.CurrentRow.Cells[3].Value.ToString();
            lbltelefono.Text = dgvmostrarcl.CurrentRow.Cells[4].Value.ToString();
            lblcorreo.Text = dgvmostrarcl.CurrentRow.Cells[5].Value.ToString();
            lbldireccion.Text = dgvmostrarcl.CurrentRow.Cells[6].Value.ToString();
            lblnacionalidad.Text = dgvmostrarcl.CurrentRow.Cells[7].Value.ToString();
            lbltrato.Text = dgvmostrarcl.CurrentRow.Cells[8].Value.ToString();
            lbltipo_doc.Text = dgvmostrarcl.CurrentRow.Cells[9].Value.ToString();
            lblnun_doc.Text = dgvmostrarcl.CurrentRow.Cells[10].Value.ToString();
            lblcomentarios.Text = dgvmostrarcl.CurrentRow.Cells[11].Value.ToString();
            lblrnc.Text = dgvmostrarcl.CurrentRow.Cells[12].Value.ToString();
            lblnfc.Text = dgvmostrarcl.CurrentRow.Cells[13].Value.ToString();
            lbltipocliente.Text = dgvmostrarcl.CurrentRow.Cells[14].Value.ToString();
          // pictureBox3.Image = System.Drawing.Image.FromFile(ma.Imagen1);
        }
        

       


    }
}

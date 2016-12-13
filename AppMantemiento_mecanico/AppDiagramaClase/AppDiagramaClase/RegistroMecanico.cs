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
    public partial class RegistroMecanico : Form
    {
        public RegistroMecanico()
        {
            InitializeComponent();
            consultar();
            controles();
            dgvmecanico.Columns[0].Visible = false;
        }
        private void consultar()
        {
            dgvmecanico.DataSource = new Mecanico().consultar();
          //  dgvmecanico.DataSource = new Persona().consular();
        }

        string id;
        DataSet registros = new DataSet();
        int j = 0;
        OpenFileDialog abrir = new OpenFileDialog();

        private void controles()
        {
            this.txtcodigo.Clear();
            this.txtnombre.Clear();
            this.txtapellido.Clear();
            this.txtcorreo.Clear();
            this.txtdireccion.Clear();
            this.txttelefono.Clear();
            this.txtruta.Clear();
            this.txtsueldobase.Clear();
            this.txtruta.Clear();
            this.txtpreciohora.Clear();
            this.txttaller.Clear();
            this.txttrato.Clear();
            this.txtnacionalidad.Clear();
            this.txtdocumento.Clear();
            this.txtnumdocumento.Clear();      
            this.cbsexo.SelectedText = "";
        }


        Mecanico mc = new Mecanico();
        Imagen ma = new Imagen();



        private void obtenerid()
        {
            mc.Id_mecanico = Convert.ToInt32(dgvmecanico.CurrentRow.Cells[0].Value);
        }

        private void obtenerdatos()
        {
            obtenerid();
            pasavalores();
            mc.Id_mecanico = Convert.ToInt32(dgvmecanico.CurrentRow.Cells[0].Value.ToString());
            mc.Id_persona = Convert.ToInt32( dgvmecanico.CurrentRow.Cells[1].Value);
            mc.Fecha_contratacion = dgvmecanico.CurrentRow.Cells[2].Value.ToString();
            mc.Taller = dgvmecanico.CurrentRow.Cells[3].Value.ToString();
            mc.Sueldo_base = Convert.ToDouble(dgvmecanico.CurrentRow.Cells[4].Value);
            mc.Precio_hora = Convert.ToDouble(dgvmecanico.CurrentRow.Cells[5].Value);
            mc.Trato = dgvmecanico.CurrentRow.Cells[7].Value.ToString();
            mc.Num_documento = dgvmecanico.CurrentRow.Cells[8].Value.ToString();
            mc.Tipo_documento = dgvmecanico.CurrentRow.Cells[9].Value.ToString();
            mc.Nombre = dgvmecanico.CurrentRow.Cells[10].Value.ToString();
            mc.Apellido = dgvmecanico.CurrentRow.Cells[11].Value.ToString();
            mc.Sexo = dgvmecanico.CurrentRow.Cells[12].Value.ToString();
            mc.Nacimiento = dgvmecanico.CurrentRow.Cells[13].Value.ToString();
            mc.Telefono = dgvmecanico.CurrentRow.Cells[14].Value.ToString();
            mc.Correo = dgvmecanico.CurrentRow.Cells[15].Value.ToString();
            mc.Direccion = dgvmecanico.CurrentRow.Cells[16].Value.ToString();
            mc.Nacionalidad = dgvmecanico.CurrentRow.Cells[17].Value.ToString();
        }

        private void pasavalores()
        {
            mc.Num_documento = txtnumdocumento.Text;
            mc.Tipo_documento = txtdocumento.Text;
            mc.Nombre = txtnombre.Text;
            mc.Apellido = txtapellido.Text;
            mc.Direccion = txtdireccion.Text;
            mc.Correo = txtcorreo.Text;
            mc.Nacionalidad = txtnacionalidad.Text;
            mc.Sexo = cbsexo.Text;
            mc.Precio_hora = Convert.ToDouble( txtpreciohora.Text);
            mc.Taller = txttaller.Text;
            mc.Telefono = txttelefono.Text;
            mc.Trato = txttrato.Text;
            mc.Sueldo_base = Convert.ToDouble(txtsueldobase.Text);
            mc.Fecha_contratacion =  dtpfecha_contrato.Value.Year + "/" + dtpfecha_contrato.Value.Month + "/" + dtpfecha_contrato.Value.Day.ToString();
            mc.Nacimiento = dtpnacimiento.Value.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            pasavalores();
            controles();

            if (new Persona().insertar(new string[] { mc.Trato, mc.Tipo_documento, mc.Num_documento, mc.Nombre, mc.Apellido, mc.Sexo, mc.Nacimiento.ToString(), mc.Telefono, mc.Correo, mc.Direccion, mc.Nacionalidad.ToString()}))
            {
                MessageBox.Show("Registro Ingresado Exitosamente");
                consultar();
            }
            else
            {
                MessageBox.Show("Error al Insertar los datos en Persona");
            }

            if (new Imagen().registrar(ma.Imagen1, ma.Id_imagen.ToString()))
            {
                MessageBox.Show("Registro Ingresado Exitosamente");
            }
            else
            {
                MessageBox.Show("Error al Insertar la imagen seleccionada");
            }
            if (new Mecanico().ingresar(new string[] { mc.Fecha_contratacion.ToString(), mc.Taller, mc.Sueldo_base.ToString(), mc.Precio_hora.ToString() }))
            {
                MessageBox.Show("Registro Ingresado Exitosamente");
                consultar();
            }
            else
            {
                MessageBox.Show("Error al Insertar los datos en la tabla mecanico");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RegistroMecanico_Load(object sender, EventArgs e)
        {
            cbsexo.Items.Add("Masculino");
            cbsexo.Items.Add("Femenino");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}

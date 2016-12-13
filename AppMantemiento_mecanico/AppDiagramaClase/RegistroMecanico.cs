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
            dgvmostrarmec.Columns[0].Visible = false;
        }
        private void consultar()
        {
            dgvmecanico.DataSource = new Mecanico().consultar();
            dgvmostrarmec.DataSource = new Mecanico().consultar();
        }



        private void filtrado(string filtro)
        {
            dgvmostrarmec.DataSource = new Mecanico ().filtrar(filtro);
        }
        private void filtrado1(string filtro)
        {
            dgvmostrarmec.DataSource = new Mecanico().filtrar1(filtro);
        }
        private void filtrado2(string filtro)
        {
            dgvmostrarmec.DataSource = new Mecanico().filtrar2(filtro);
        }


        string id;
        DataSet registros = new DataSet();
        //int j = 0;
        OpenFileDialog abrir = new OpenFileDialog();
        //int cantidadregistro;

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
            this.btncancelar.Enabled = false;
            this.btnmodificar.Enabled = false;

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
            txtnombre.Text = dgvmecanico.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dgvmecanico.CurrentRow.Cells[2].Value.ToString();
            cbsexo.Text  = dgvmecanico.CurrentRow.Cells[3].Value.ToString();
            dtpnacimiento.Text = dgvmecanico.CurrentRow.Cells[4].Value.ToString();
            txttelefono.Text = dgvmecanico.CurrentRow.Cells[5].Value.ToString();
            txtcorreo.Text = dgvmecanico.CurrentRow.Cells[6].Value.ToString();
            txtdireccion.Text = dgvmecanico.CurrentRow.Cells[7].Value.ToString();
            txtnacionalidad.Text = dgvmecanico.CurrentRow.Cells[8].Value.ToString();
            txttrato.Text = dgvmecanico.CurrentRow.Cells[9].Value.ToString();
            txtdocumento.Text = dgvmecanico.CurrentRow.Cells[10].Value.ToString();
            txtnumdocumento.Text = dgvmecanico.CurrentRow.Cells[11].Value.ToString();
            dtpfecha_contrato.Text = dgvmecanico.CurrentRow.Cells[12].Value.ToString();
            txttaller.Text = dgvmecanico.CurrentRow.Cells[13].Value.ToString();
            txtsueldobase.Text = dgvmecanico.CurrentRow.Cells[14].Value.ToString();
            txtpreciohora.Text = dgvmecanico.CurrentRow.Cells[15].Value.ToString();
            txtruta.Text = dgvmecanico.CurrentRow.Cells[16].Value.ToString();
            Bitmap Picture = new Bitmap(txtruta.Text);
            pictureBox1.Image = (Image)Picture;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            mc.Taller = txttaller.Text;
            mc.Telefono = txttelefono.Text;
            mc.Trato = txttrato.Text;
            mc.Fecha_contratacion = dtpfecha_contrato.Value;
            mc.Nacimiento = dtpnacimiento.Value;
            mc.Sueldo_base = Convert.ToDouble(txtsueldobase.Text);
            mc.Precio_hora = Convert.ToDouble(txtpreciohora.Text);
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



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RegistroMecanico_Load(object sender, EventArgs e)
        {
            cbsexo.Items.Add("Masculino");
            cbsexo.Items.Add("Femenino");
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            pasavalores();
            controles();

            if (new Persona().insertar(new string[] { mc.Trato, mc.Tipo_documento, mc.Num_documento, mc.Nombre, mc.Apellido, mc.Sexo, mc.Nacimiento.ToString(), mc.Telefono, mc.Correo, mc.Direccion, mc.Nacionalidad.ToString() }))
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

        private void tabPage2_Click(object sender, EventArgs e)
        {
            /*
            registros = new Imagen().numeroregistro();
            cantidadregistro = registros.Tables[0].Rows.Count;
            for (int i = 0; i < cantidadregistro; i++)
            {
                dgvmostrarmec.Rows.Add(registros.Tables[0].Rows[i]["id"].ToString());
                dgvmostrarmec.Rows.Add(registros.Tables[1].Rows[i]["imagen"].ToString());

            }
            registros.Clear();
            MessageBox.Show("Registro encontrado");*/
        }

        private void dgvmostrarmec_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblcodigo.Text = dgvmostrarmec.CurrentRow.Cells[0].Value.ToString();
            lblnombre.Text = dgvmostrarmec.CurrentRow.Cells[1].Value.ToString();
            lblapellido.Text = dgvmostrarmec.CurrentRow.Cells[2].Value.ToString();
            lblsexo.Text = dgvmostrarmec.CurrentRow.Cells[3].Value.ToString();
            lblfecha_nac.Text = dgvmostrarmec.CurrentRow.Cells[4].Value.ToString();
            lbltelefono.Text = dgvmostrarmec.CurrentRow.Cells[5].Value.ToString();
            lblcorreo.Text = dgvmostrarmec.CurrentRow.Cells[6].Value.ToString();
            lbldireccion.Text = dgvmostrarmec.CurrentRow.Cells[7].Value.ToString();
            lblnacionalidad.Text = dgvmostrarmec.CurrentRow.Cells[8].Value.ToString();
            lbltrato.Text = dgvmostrarmec.CurrentRow.Cells[9].Value.ToString();
            lbltipo_doc.Text = dgvmostrarmec.CurrentRow.Cells[10].Value.ToString();
            lblnun_doc.Text = dgvmostrarmec.CurrentRow.Cells[11].Value.ToString();
            lblfechacontra.Text = dgvmostrarmec.CurrentRow.Cells[12].Value.ToString();
            lbltaller.Text = dgvmostrarmec.CurrentRow.Cells[13].Value.ToString();
            lblsueldob.Text = dgvmostrarmec.CurrentRow.Cells[14].Value.ToString();
            lblprecioh.Text = dgvmostrarmec.CurrentRow.Cells[15].Value.ToString();
            txtruta.Text = dgvmostrarmec.CurrentRow.Cells[16].Value.ToString();
            Bitmap Picture = new Bitmap(txtruta.Text);
            pictureBox3.Image = (Image)Picture;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

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

        private void dgvmecanico_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerdatos();
            this.btncancelar.Enabled = false;
            this.btnmodificar.Enabled = true;
        }

        private void dgvmecanico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controles();
            obtenerid();
            this.btncancelar.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            controles();
            if (new Mecanico().eliminar(mc.Id_mecanico))
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
            if (new Mecanico().modificar(new object[] { mc.Id_mecanico.ToString(), mc.Nombre, mc.Apellido, mc.Sexo, mc.Nacimiento, mc.Telefono, mc.Correo, mc.Direccion, mc.Nacionalidad, mc.Trato, mc.Tipo_documento, mc.Num_documento, mc.Fecha_contratacion.ToString(), mc.Taller, mc.Sueldo_base.ToString(), mc.Precio_hora.ToString() }))
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}

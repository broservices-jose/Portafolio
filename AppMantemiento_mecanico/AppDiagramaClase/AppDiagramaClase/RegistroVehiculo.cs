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
    public partial class RegistroVehiculo : Form
    {
        public RegistroVehiculo()
        {
            InitializeComponent();
            dgvvehiculo.Columns[0].Visible = false;
        }
        private void consultar()
        {
            dgvvehiculo.DataSource = new Vehiculo().consultar();
        }


        OpenFileDialog open = new OpenFileDialog();
        string id;
        DataSet registros = new DataSet();
        int j = 0;
        int cantidadregistro;


        Vehiculo vc = new Vehiculo();
        Imagen ma = new Imagen();

        private void pasarvalore()
        {
            vc.Modelo = txtmodelo.Text;
            vc.Matricula = txtmatricula.Text;
            vc.Placa = txtplaca.Text;
            vc.Traccion = txttraccion.Text;
            vc.Transmision = txttransimision.Text;
            vc.Version = txtversion.Text;
            vc.Marca = txtmarca.Text;
            vc.Observaciones = rtobservacion.Text;
            vc.Anio = dtpanio.Value.Year + "/"+ dtpanio.Value.Month+ "/"+ dtpanio.Value.Day;
            vc.Chasis = txtchasis.Text;
            vc.Color = txtcolor.Text;
            vc.Fecha_registro = dtpfechaingre.Value.Year + "/" + dtpfechaingre.Value.Month + "/" + dtpfechaingre.Value.Day;
            vc.Tipo_combustible = cbcombustible.Text;
            ma.Tipo_imagen = "vehiculo";
            vc.Id_cliente = Convert.ToInt32( txtidcliente.Text);
            
        }

        private void controles()
        {
            this.txtchasis.Clear();
            this.txtcolor.Clear();
            this.txtmarca.Clear();
            this.txtmatricula.Clear();
            this.txtmodelo.Clear();
            this.txtplaca.Clear();
            this.txtruta.Clear();
            this.txttraccion.Clear();
            this.txttransimision.Clear();
            this.txtversion.Clear();
            this.cbcombustible.Text = "";
            
        }
        private void obtenerdatos()
        {
            pasarvalore();
            vc.Matricula = dgvvehiculo.CurrentRow.Cells[0].Value.ToString();
            vc.Chasis = dgvvehiculo.CurrentRow.Cells[1].Value.ToString();
            vc.Placa = dgvvehiculo.CurrentRow.Cells[2].Value.ToString();
            vc.Marca = dgvvehiculo.CurrentRow.Cells[3].Value.ToString();
            vc.Modelo = dgvvehiculo.CurrentRow.Cells[4].Value.ToString();
            vc.Version = dgvvehiculo.CurrentRow.Cells[5].Value.ToString();
            vc.Anio = dgvvehiculo.CurrentRow.Cells[6].Value.ToString();
            vc.Color = dgvvehiculo.CurrentRow.Cells[7].Value.ToString();
            vc.Traccion = dgvvehiculo.CurrentRow.Cells[8].Value.ToString();
            vc.Transmision = dgvvehiculo.CurrentRow.Cells[9].Value.ToString();
            vc.Tipo_combustible = dgvvehiculo.CurrentRow.Cells[10].Value.ToString();
            vc.Fecha_registro = dgvvehiculo.CurrentRow.Cells[11].Value.ToString();
            vc.Observaciones = dgvvehiculo.CurrentRow.Cells[12].Value.ToString();
            
            

        }
        private void RegistroVehiculo_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open.Title = "abri mienda";
            open.Filter = "Jpg files (*.jpg )|*.jpg| GIF files (*.gif)|*.gif|Bitmap files (*.Bmp)|*.bmp|PNG files (*.png)|*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                ma.Imagen1 = open.FileName;
                Bitmap picture = new Bitmap(ma.Imagen1);
                pictureBox1.Image = (Image)picture;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                id = open.SafeFileName;
                txtruta.Text = id;
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (txtidcliente.Text == "")
            {
                MessageBox.Show("No se ha seleccionado el propietrario de Este Vehiculo");
            }

            else
            {
                controles();

                if (new Imagen().registrar(ma.Imagen1, ma.Tipo_imagen))
                {
                    MessageBox.Show("Registro Ingresado Exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al Insertar la imagen seleccionada");
                }

                if (new Vehiculo().insertar(new string[] {vc.Id_cliente.ToString(), vc.Matricula, vc.Chasis, vc.Placa, vc.Marca, vc.Modelo, vc.Version, vc.Anio, vc.Color, vc.Traccion, vc.Transmision, vc.Tipo_combustible, vc.Fecha_registro, vc.Observaciones }))
                {
                    MessageBox.Show("Registro Insertado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al Insertar los datos en la tabla vehiculo");
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            registros = new Imagen().numeroregistro();
            cantidadregistro = registros.Tables[0].Rows.Count;
            for (int i = 0; i  < cantidadregistro; i++)
            {
                dgvmostrarveh.Rows.Add(registros.Tables[0].Rows[i]["id"].ToString());

            }
            registros.Clear();
            MessageBox.Show("Registro encontrado");

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vehiculosregistrado vr = new Vehiculosregistrado();
            vr.Show();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncreacliente_Click(object sender, EventArgs e)
        {
            RegistroVehiculo rv = new RegistroVehiculo();
            rv.Show();
        }
    }
}

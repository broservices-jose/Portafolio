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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
            controles();
            consular();
            //dgvusuario.Columns[0].Visible = false;
        }

        string id;
        DataSet registros = new DataSet();
        int j = 0;
        OpenFileDialog open = new OpenFileDialog();


        private void consular()
        {
             dgvusuario.DataSource = new Usuario().consultar();
        }

        Usuario ua = new Usuario();
        Imagen ma = new Imagen();

        private void controles()
        {
            this.txtidusuario.Clear();
            this.txtfiltrar.Clear();
            this.txtnombre.Clear();
            this.txtpermiso.Clear();
            this.txtidusuario.Clear();
        }



        private void pasarvalores()
        {
            ua.Nombre_usuario = txtnombre.Text;
            ua.Permiso = txtpermiso.Text;
            ua.Clave = txtclave.Text;
            ua.Departamento = txtdepartamento.Text;
            ua.Fecha_ingreso = "17/1/10";
            ma.Imagen1 = txtruta.Text;
            ma.Tipo_imagen = "usuario";

        }

                private void obtenerdatos()
        {
            pasarvalores();
            ua.Nombre_usuario = dgvusuario.CurrentRow.Cells[1].Value.ToString();
            ua.Permiso = dgvusuario.CurrentRow.Cells[2].Value.ToString();
            ua.Clave = dgvusuario.CurrentRow.Cells[3].Value.ToString();
            ua.Departamento = dgvusuario.CurrentRow.Cells[4].Value.ToString();
            ua.Fecha_ingreso = dgvusuario.CurrentRow.Cells[5].Value.ToString();
        }

         private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            pasarvalores();
            if (new Usuario().ingresar(new string[] { ua.Nombre_usuario, ua.Permiso, ua.Clave, ua.Departamento, ua.Fecha_ingreso }))
            {
                MessageBox.Show("Registro insertado correctamente");
                consular();

            }
            else
            {
                MessageBox.Show("Error al insetar los datos");
            }

            if (new Imagen().registrar(ma.Imagen1, ma.Id_imagen.ToString()))
            {
                MessageBox.Show("Registro Ingresado Exitosamente");
            }
            else
            {
                MessageBox.Show("Error al Insertar la imagen seleccionada");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

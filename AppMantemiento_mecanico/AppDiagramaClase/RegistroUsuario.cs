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
            dgvusuario.Columns[0].Visible = false;
        }

        string id;
        DataSet registros = new DataSet();
        int j = 0;
        OpenFileDialog open = new OpenFileDialog();
        

        private void consular()
        {
             dgvusuario.DataSource = new Usuario().consultar();
        }

        private void filtrado(string filtro)
        {
            dgvusuario.DataSource = new Usuario().filtrar(filtro);
        }

        private void obtenerid()
        {
            ua.Id_usuario = Convert.ToInt32(dgvusuario.CurrentRow.Cells[0].Value);
        }
        Usuario ua = new Usuario();
        Imagen ma = new Imagen();

        private void controles()
        {
            this.txtidusuario.Clear();
            this.txtfiltrar.Clear();
            this.txtnombre.Clear();
            this.cbpermiso.Text = "";
            this.txtidusuario.Clear();
            this.btneliminar.Enabled = false;
            this.btnmodificar.Enabled = false;
        }



        private void pasarvalores()
        {
            ua.Nombre_usuario = txtnombre.Text;
            ua.Permiso = cbpermiso.Text;
            ua.Clave = txtclave.Text;
            ua.Departamento = txtdepartamento.Text;
            ua.Fecha_ingreso = Convert.ToDateTime( DateTime.Now.ToString());
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
            ua.Fecha_ingreso = Convert.ToDateTime(dgvusuario.CurrentRow.Cells[5].Value);
            ma.Imagen1 = dgvusuario.CurrentRow.Cells[6].Value.ToString();
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


            if (new Imagen().registrar(ma.Imagen1, ma.Id_imagen.ToString()))
            {
                MessageBox.Show("Registro Ingresado Exitosamente");
            }
            else
            {
                MessageBox.Show("Error al Insertar la imagen seleccionada");
            }

            pasarvalores();
            if (new Usuario().ingresar(new string[] { ua.Nombre_usuario, ua.Permiso, ua.Clave, ua.Departamento, ua.Fecha_ingreso.ToString() }))
            {
                MessageBox.Show("Registro insertado correctamente");
                consular();

            }
            else
            {
                MessageBox.Show("Error al insetar los datos");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            filtrado(this.txtfiltrar.Text);
        }

        private void dgvusuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controles();
            obtenerid();
            this.btneliminar.Enabled = true;
        }

        private void dgvusuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerdatos();
            this.btneliminar.Enabled = false;
            this.btnmodificar.Enabled = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            controles();
            if (new Usuario().eliminar(ua.Id_usuario))
            {
                MessageBox.Show("Registro Eliminado Correctamente");
                consular();
            }

            else
            {
                MessageBox.Show("Error al Eliminar ");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (new Usuario().modificar(new object[] { ua.Id_usuario.ToString(), ua.Nombre_usuario, ua.Permiso, ua.Clave, ua.Departamento, ua.Fecha_ingreso.ToString(), ma.Imagen1}))
            {
                MessageBox.Show("Registro Actualizado Correctamente");
                consular();
            }

            else
            {
                MessageBox.Show("Error al Actualizar");
            }
            controles();
        }

    }
}

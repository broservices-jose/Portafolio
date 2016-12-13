using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppDiagramaClase
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private MySqlConnection cn;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        //private DataTable tabla = null;

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try 
            { 
            string query = "SELECT * FROM usuario WHERE nombre_usuario ='" + this.txtnombre.Text + "'AND permiso ='" + this.cbpermiso.Text + "'AND clave ='" + this.txtclave.Text+"'";
           //string query = "SELECT * FROM usuario WHERE nombre_usuario ='" +this.txtnombre.Text + "' AND clave ='" + this.txtclave.Text+"'"  ;
           //  string query = "SELECT * FROM usuario WHERE (nombre_usuario ='" + this.txtnombre.Text + "' AND clave ='" + this.txtclave.Text + "') AND  permiso='"+ this.cbpermiso.SelectedIndex +"'";
  
 
            cn = conexion.conectar();
            cn.Open();
            cmd = new MySqlCommand(query, cn);
            leer = cmd.ExecuteReader();
            int c = 0;
            while (leer.Read())
            {
                c = c + 1;
            }
            if (c == 1)
            {
                MessageBox.Show("Bienvenido");
                this.Hide();
                Menu rc = new Menu();
                rc.Show();
            }
            else if (c > 1)
            {
                MessageBox.Show("Acceso denegado");
            }
            else
            {
                MessageBox.Show("Nombre o Contraseña incorrecta");
            }
            cn.Close();
           }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message);
            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
            }
       }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

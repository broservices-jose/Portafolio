using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentSender.Formularios
{
    public partial class Login : Form
    {
        Clases.Usuario _usuario;

        public Login()
        {
            InitializeComponent();
        }

        public Clases.Usuario Loguear()
        {
            if (this.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return _usuario;
            }
            else
            {
                Application.Exit();
                return null;
            }
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (Clases.Validacion.EsValido(tboxUsuario)
                && Clases.Validacion.EsValido(tboxContraseña))
            {
                if ((_usuario = Sistema.Instancia.Loguear(tboxUsuario.Text, tboxContraseña.Text)) == null)
                {
                    MessageBox.Show("Usuario invalido");
                }
                else
                {
                    MessageBox.Show("Bienvenido al sistema");
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }
    }
}

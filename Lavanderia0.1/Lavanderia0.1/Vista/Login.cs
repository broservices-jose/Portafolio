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
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        // ************************************************************************ ||
        // Esta linea de codigo representa el metodo el evento click del boton 
        // btnacceder el cual nos va permitir validar el usuario que se ha logeado
        // existe
        // ************************************************************************ ||

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if (new CLUsuario().validar(txtusuario.Text, txtcontrasenia.Text) == 1)
            {
                MessageBox.Show("Bienvenido");
                this.Hide();
                Menu m = new Menu();
                m.Show();
            }
            else
            {
                MessageBox.Show("Contraseña o Usuario Incorrecta");
            }
        }

        // ************************************************************************ ||
        // Esta linea de codigo representa el metodo el evento click del boton 
        // btncancelar el cual nos va permitir cerrar el formulario
        // ************************************************************************ ||

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

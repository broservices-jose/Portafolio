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
    public partial class AgDepartamento : Form
    {
        public AgDepartamento()
        {
            InitializeComponent();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (Clases.Validacion.EsValido(tboxNombre))
            {
                Sistema.Instancia.AgregarDepartamento(tboxNombre.Text);
                this.Close();
            }
        }
    }
}

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
    public partial class Clienteregistrado : Form
    {
        public Clienteregistrado()
        {
            InitializeComponent();
            dgvclienter.Columns[0].Visible = false;
        }

        private void consultar()
        {
            dgvclienter.DataSource = new Cliente().consultar();
        }
        private void Clienteregistrado_Load(object sender, EventArgs e)
        {

        }
    }
}

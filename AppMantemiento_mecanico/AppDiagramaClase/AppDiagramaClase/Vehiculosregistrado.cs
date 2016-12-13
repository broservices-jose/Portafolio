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
    public partial class Vehiculosregistrado : Form
    {
        public Vehiculosregistrado()
        {
            InitializeComponent();
            dgvvehiculor.Columns[0].Visible = false;
        }

        private void consultar()
        {
            dgvvehiculor.DataSource = new Vehiculo().consultar();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvvehiculor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}

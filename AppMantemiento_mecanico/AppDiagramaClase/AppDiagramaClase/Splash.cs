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
    public partial class Splash : Form
    {
        int c = 0;
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c == 100)
            {
                timer1.Stop();
                this.Hide();
                Login lo = new Login();
                lo.Show();
            }
            else
            {
                c = c + 5;
                progressBar1.Value = c;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 5;
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

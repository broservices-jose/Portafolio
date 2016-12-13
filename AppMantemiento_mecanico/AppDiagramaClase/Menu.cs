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
    public partial class Menu : Form
    {
        private int childFormNumber = 0;

        public Menu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroCliente rc = new RegistroCliente();
            rc.MdiParent = this;
            rc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistroVehiculo rv = new RegistroVehiculo();
            rv.MdiParent = this;
            rv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroMecanico rm = new RegistroMecanico();
            rm.MdiParent = this;
            rm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistroOrden ro = new RegistroOrden();
            ro.MdiParent = this;
            ro.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Servicio ms = new Servicio();
            ms.MdiParent = this;
            ms.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistroUsuario ru = new RegistroUsuario();
            ru.MdiParent = this;
            ru.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCliente pA = new RegistroCliente();
            pA.MdiParent = this;
            pA.Show();
        }

        private void mecanicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroMecanico pm = new RegistroMecanico();
            pm.MdiParent = this;
            pm.Show();
        }

        private void ordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroOrden po = new RegistroOrden();
            po.MdiParent = this;
            po.Show();
        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicio ps = new Servicio();
            ps.MdiParent = this;
            ps.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroVehiculo pv = new RegistroVehiculo();
            pv.MdiParent = this;
            pv.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario pu = new RegistroUsuario();
            pu.MdiParent = this;
            pu.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

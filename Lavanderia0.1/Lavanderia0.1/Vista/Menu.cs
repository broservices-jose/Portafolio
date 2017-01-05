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

namespace Lavanderia0._1.Vista
{
    public partial class Menu : MetroForm
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
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in MdiChildren)
            {

                childForm.Close();
            }
           
           Factura f = new Factura();
            f.MdiParent = this;
            f.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {

                childForm.Close();
            }

            
         Empleado em = new Empleado();
         
            em.MdiParent = this;
            em.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in MdiChildren)
            {

                childForm.Close();
            }
            Articulo ar = new Articulo();
            ar.MdiParent = this;
            ar.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in MdiChildren)
            {

                childForm.Close();
            }
            Servicio se = new Servicio();
            se.MdiParent = this;
            se.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in MdiChildren)
            {

                childForm.Close();
            }
            Usuario u = new Usuario();
            u.MdiParent = this;
            u.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {


            foreach (Form childForm in MdiChildren)
            {

                childForm.Close();
            }
            Cliente c = new Cliente();
            c.MdiParent = this;
            c.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in MdiChildren)
            {

                childForm.Close();
            }
            Orden o = new Orden();
            o.MdiParent = this;
            o.Show();

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnfactura, "Modulo Factura");
        }

        private void btnservicio_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnservicio, "Modulo Servicio");
        }

        private void btnarticulo_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnarticulo, "Modulo Articulo");
        }

        private void btnusuario_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnusuario, "Modulo Usuario");
        }

        private void btnempleado_MouseHover(object sender, EventArgs e)
        {
           // this.toolTip1.IsBalloon = true;
           
            this.toolTip1.SetToolTip(btnempleado, "Modulo empleado");
        }

        private void btncliente_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btncliente, "Modulo Cliente");
        }

        private void btnpagonomina_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnpagonomina, "Modulo de Pago de  nomina");
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

    }
}

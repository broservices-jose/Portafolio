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
            consultar();
            dgvclienter.Columns[0].Visible = false;
            
        }
        
        

        private void consultar()
        {
            dgvclienter.DataSource = new Cliente().consultar();
        }

        private void obtenerid()
        {
            na.Id_cliente = Convert.ToInt32(dgvclienter.CurrentRow.Cells[0].Value);
        }

        Cliente na = new Cliente();
/*
        private void obtenerdatos()
        {
            obtenerid();
            // cl.Id_persona = Convert.ToInt32( dgvcliente.CurrentRow.Cells[1].Value);
            na.Comentarios = dgvclienter.CurrentRow.Cells[1].Value.ToString();
            na.Rnc = dgvclienter.CurrentRow.Cells[2].Value.ToString();
            na.Nfc = dgvclienter.CurrentRow.Cells[3].Value.ToString();
            na.Tipo_cliente = dgvclienter.CurrentRow.Cells[4].Value.ToString();
            na.Trato = dgvclienter.CurrentRow.Cells[5].Value.ToString();
            na.Tipo_documento = dgvclienter.CurrentRow.Cells[6].Value.ToString();
            na.Num_documento = dgvclienter.CurrentRow.Cells[7].Value.ToString();
            na.Nombre = dgvclienter.CurrentRow.Cells[8].Value.ToString();
            na.Apellido = dgvclienter.CurrentRow.Cells[9].Value.ToString();
            na.Sexo = dgvclienter.CurrentRow.Cells[10].Value.ToString();
            na.Nacimiento = dgvclienter.CurrentRow.Cells[11].Value.ToString();
            na.Telefono = dgvclienter.CurrentRow.Cells[12].Value.ToString();
            na.Correo = dgvclienter.CurrentRow.Cells[13].Value.ToString();
            na.Direccion = dgvclienter.CurrentRow.Cells[14].Value.ToString();
            na.Nacimiento = dgvclienter.CurrentRow.Cells[15].Value.ToString();
        }*/

        private void Clienteregistrado_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
              Pasar.ro.txtcodgocliente.Text =  dgvclienter.CurrentRow.Cells[0].Value.ToString();
              Pasar.ro.txtnombrecliente.Text = dgvclienter.CurrentRow.Cells[1].Value.ToString();
              Pasar.ro.txtapellidocliente.Text = dgvclienter.CurrentRow.Cells[2].Value.ToString();
              Pasar.ro.txttelefonocliente.Text = dgvclienter.CurrentRow.Cells[3].Value.ToString();
              Pasar.ro.txtemailcliente.Text = dgvclienter.CurrentRow.Cells[4].Value.ToString();
              Pasar.ro.txtdireccioncliente.Text = dgvclienter.CurrentRow.Cells[5].Value.ToString();
              Pasar.ro.txtnodoccliente.Text = dgvclienter.CurrentRow.Cells[7].Value.ToString();
              Pasar.ro.cbtipo_docucliente.Text = dgvclienter.CurrentRow.Cells[8].Value.ToString();         

            
        }

        private void dgvclienter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void dgvclienter_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

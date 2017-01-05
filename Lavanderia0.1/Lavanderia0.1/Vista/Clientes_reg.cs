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
    public partial class Clientes_reg : MetroForm
    {
        public Clientes_reg()
        {
            InitializeComponent();
            consulta();
            dgvclientes.Columns[6].Visible = false;
            dgvclientes.Columns[7].Visible = false;
            dgvclientes.Columns[8].Visible = false;
            dgvclientes.Columns[9].Visible = false;

        }

        // ***************************************************************************************** \\
        // Esta linea de codigo representa el metodo consultar2() el cual nos va ha atraer todos los 
        // datos de las tablas cliente, imagen para llenar el datagridview dgvclientes
        // ***************************************************************************************** \\

        private void consulta()
        {
            dgvclientes.DataSource = new CLCliente().Consultar();
        }

        /// **************************************************************************** ||
        //Creamos una instancia de la interfaz IProducto para establecer el 
        // formulario llamador el cual 
        // **************************************************************************** ||

        public IDatoc llamador { private get; set; }

        private void btncargar_Click(object sender, EventArgs e)
        {
            if (llamador == null)
            {
                MessageBox.Show("Esta nulo");
            }
            else
            {
                CLCliente c = new CLCliente { 
                Nombre = dgvclientes.CurrentRow.Cells[1].Value.ToString(), 
                Apellido = dgvclientes.CurrentRow.Cells[2].Value.ToString(),
                Telefono = dgvclientes.CurrentRow.Cells[5].Value.ToString()
                };
                llamador.cargardato(c);
            }
            this.Close();
        }

        private void dgvclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btncargar.Enabled = true;

        }

        private void dgvclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btncargar.Enabled = true;
        }


    }
}

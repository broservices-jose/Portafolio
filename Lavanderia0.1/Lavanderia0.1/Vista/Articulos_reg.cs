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
using Lavanderia0._1.Vista;

namespace Lavanderia0._1.Vista
{
    public partial class Articulos_reg : MetroForm
    {
        public Articulos_reg()
        {
            InitializeComponent();
            consulta();
            dgvarticulos.Columns[0].Visible = false;
        }

        // ***************************************************************************************** \\
        // Esta linea de codigo representa el metodo consultar2() el cual nos va ha atraer todos los 
        // datos de las tablas cliente, imagen para llenar el datagridview dgvclientes
        // ***************************************************************************************** \\

        private void consulta()
        {
            dgvarticulos.DataSource = new CLArticulo().consultar();
        }

        /// **************************************************************************** ||
        //Creamos una instancia de la interfaz IProducto para establecer el 
        // formulario llamador el cual 
        // **************************************************************************** ||

        public IDatoa llamador { private get; set; }

        private void btncargar_Click(object sender, EventArgs e)
        {
            if (llamador == null)
            {
                MessageBox.Show("Esta nullo");
            }
            else
            {
                CLArticulo a = new CLArticulo 
                {
                    Id_articulo = Convert.ToInt32(dgvarticulos.CurrentRow.Cells[0].Value.ToString()),
                    Articulo = dgvarticulos.CurrentRow.Cells[1].Value.ToString(),
                    Categoria = dgvarticulos.CurrentRow.Cells[2].Value.ToString()
                };
                llamador.cargardato(a);
                this.Close();
            }
        }

        private void dgvarticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btncargar.Enabled = true;
        }

        private void dgvarticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btncargar.Enabled = true;
        }
    }
}

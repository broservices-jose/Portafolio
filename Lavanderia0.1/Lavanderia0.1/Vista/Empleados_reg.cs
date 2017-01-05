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
    public partial class Empleados_reg : MetroForm
    {
        public Empleados_reg()
        {
            InitializeComponent();
            consulta();
            dgvempledos.Columns[0].Visible = false;
            dgvempledos.Columns[5].Visible = false;
        }

        // ***************************************************************************************** \\
        // Esta linea de codigo representa el metodo consultar2() el cual nos va ha atraer todos los 
        // datos de las tablas empleados, imagen y referencia para llenar el datagridview dgvempleados
        // ***************************************************************************************** \\
        private void consulta()
        {
            dgvempledos.DataSource = new CLEmpleado().consultar2();
        }

        // **************************************************************************** ||
        //Creamos una instancia de la interfaz IProducto para establecer el 
        // formulario llamador el cual 
        // **************************************************************************** ||

        public IDatop llamador { private get; set; }

        public IDatou llamador1 { private get; set; }


        private void btncargar_Click(object sender, EventArgs e)
        {

            if (llamador != null && llamador1 == null)
            {
                CPagodenomina pn = new CPagodenomina
                {
                    Id_empleado = Convert.ToInt32(dgvempledos.CurrentRow.Cells[0].Value.ToString()),
                    Empleado = dgvempledos.CurrentRow.Cells[1].Value.ToString(),
                    Ruta = dgvempledos.CurrentRow.Cells[5].Value.ToString()
                };

                // ************************************************************************************* ||
                //Si no existe llamador para nuestro formulario nos retornamos sin hacer ninguna acción
                // ************************************************************************************* ||
                if (llamador == null)
                {
                    MessageBox.Show("Esta nulo");
                    return;
                }
                llamador.cargardato(pn);
            }
            else if (llamador1 != null && llamador == null) {
                CLUsuario u = new CLUsuario { 
                Id_empleado = Convert.ToInt32(dgvempledos.CurrentRow.Cells[0].Value.ToString()),
                Empleado = dgvempledos.CurrentRow.Cells[1].Value.ToString()
                };

                // ************************************************************************************* ||
                //Si no existe llamador para nuestro formulario nos retornamos sin hacer ninguna acción
                // ************************************************************************************* ||
                if (llamador1 == null)
                {
                    MessageBox.Show("Esta nulo");
                    return;
                }
                llamador1.cargardato(u);
            }


            this.Hide();
        }

        private void dgvempledos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvempledos.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Debe de seleccionar una fila con datos");
            }
            else
            {
                btncargar.Enabled = true;
            }
        }

        private void dgvempledos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvempledos.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Debe de seleccionar una fila con datos");
            }
            else
            {
                btncargar.Enabled = true;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btncargar, "B");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lollipopTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

  
    }
}

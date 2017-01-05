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
    public partial class Orden : MetroForm
    {
        // **************************************************************************************** ||
        // Esta linea de codigo representa el metodo constructor Orden() el cual vamos utilizar 
        // para iniciar todos los componentes del modulo orden y sus respectivos metodos o funcioens
        // que vallamos a utilizar para inicializar 
        // **************************************************************************************** ||

        public Orden()
        {
            InitializeComponent();
            consultar();
            dgvorden.Columns[0].Visible = false;
        }

        // ************************************************************************************************ ||
        // Esta linea de codigo representa el metodo consultar() el cual nos va permitir llenar el 
        // datagridview dgvorden con los datos de la tabla factura
        // ************************************************************************************************ ||

        private void consultar()
        {
            dgvorden.DataSource = new CLFactura().mostrarfactura(); 
        }

        // ************************************************************************************************** ||
        // Esta linea de codigo representa la declaracion de las variables y la instanciacion de los objetos
        // que vamos a utilizar en este modulo
        // ************************************************************************************************** ||
        int pagar, entregar;

        CLFactura f = new CLFactura();

        // ************************************************************************************************** ||
        // Esta linea de codigo representa el metodo obtener el cual nos va permitir obtener los datos de la
        // fila seleccionada del datagridview dgvorden con su respectivo evento
        // ************************************************************************************************** ||

        private void obtener()
        {
            
            lblfactura.Text = dgvorden.CurrentRow.Cells[0].Value.ToString();
            lblcliente.Text = dgvorden.CurrentRow.Cells[1].Value.ToString();
            lblrecibido.Text = dgvorden.CurrentRow.Cells[2].Value.ToString();
            lblentrega.Text = dgvorden.CurrentRow.Cells[3].Value.ToString();
            lblhora.Text = dgvorden.CurrentRow.Cells[4].Value.ToString();
            lbldescuent.Text = dgvorden.CurrentRow.Cells[5].Value.ToString();
            lbltotal.Text = dgvorden.CurrentRow.Cells[6].Value.ToString();
            f.Entregado = Convert.ToBoolean(dgvorden.CurrentRow.Cells[7].Value.ToString());
            f.Pagado = Convert.ToBoolean(dgvorden.CurrentRow.Cells[8].Value.ToString());

            if (f.Entregado == false)
            {
                cbentregado_no.Checked = true;
                cbentregado_si.Checked = false;
            }
            else { cbentregado_si.Checked = true; cbentregado_no.Checked = false; }

            if (f.Pagado == false) { cbpagado_no.Checked = true; cbpagado_si.Checked = false; }
            else { cbpagado_si.Checked = true; cbpagado_no.Checked = false; }
            
        }

        // *************************************************************************************** ||
        // Esta linea de codigo representa el metodo pasarvalor el cual nos va permitir obtenr el 
        // estado de los radiosbuttons para luego ser registrado en la tabla factura
        // *************************************************************************************** ||

        private void pasarvalor()
        {
            f.Pagado = Convert.ToBoolean(cbpagado_si.CheckState);
            f.Entregado = Convert.ToBoolean(cbentregado_si.CheckState);
            if (f.Pagado == true)
            {
                pagar = 1;
            }
            else {pagar = 0;}
            if (f.Entregado == true)
            {
                entregar = 1;
            }
            else { entregar = 0; }
        }


        // ******************************************************************************** ||
        // Esta linea de codigo representa el metodo obtenerid() el cual nos va permitir
        // el id_factura de la fila que halla sido seleccionada en el datagridview dgvorden
        // ******************************************************************************** ||

        private void obtenerid()
        {
            f.Id_factura = Convert.ToInt32(dgvorden.CurrentRow.Cells[0].Value.ToString());
        }

        // ********************************************************************************** ||
        // Esta linea de codigo representa el metodo limpiarlbl() el cual nos va permitir 
        // restablecer los labels que muestran informacion de la factura seleccionada
        // ********************************************************************************** ||

        private void limpiarlbl()
        {
            lblcliente.Text = "_____________";
            lbldescuent.Text = "_____________";
            lblentrega.Text = "_____________";
            lblfactura.Text = "_____________";
            lblhora.Text = "_____________";
            lblrecibido.Text = "_____________";
            lbltotal.Text = "_____________";
            cbentregado_no.Checked = false;
            cbentregado_si.Checked = false;
            cbpagado_no.Checked = false;
            cbpagado_si.Checked = false;

        }

        private void dgvorden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtener();
            obtenerid();
            btnguardar.Enabled = true;
            btneliminar.Enabled = false;
        }

        private void dgvorden_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtener();
            obtenerid();
            btnguardar.Enabled = false;
            btneliminar.Enabled = true;
        }

        // ************************************************************************************************** ||
        // Esta linea de codigo representa el evento click del boton btnguardar el cual nos va permitir 
        // cambiar a true el registro registrado en los campos entregado y pagado de la tabla factura
        // ************************************************************************************************** ||

        private void btnguardar_Click(object sender, EventArgs e)
        {
            pasarvalor();
            if (new ControlDB().modificar("factura", " f inner join detalle_orden d on d.id_factura = f.id_factura",
                f.Id_factura.ToString(), " f.id_factura", new string[] { " f.entregado", " f.pagado" }, new string[] { 
                    entregar.ToString(), pagar.ToString() }))
            {
                MessageBox.Show("Estado cambiado correctamente");
                consultar();
                limpiarlbl();
            }
            else
            {
                MessageBox.Show("Error al cambio los datos solicitados");
            }
        }

        // ******************************************************************************************** ||
        // Esta linea de codigo representa el evento click del boton eliminar el cual nos va a permitir
        // modficar el campos estado a desabilitado para no mostrar dicha facutra y si se es que elimino
        // los datos financieros haciendo creer que esta eliminado pero no es asi que los ocultamos
        // ********************************************************************************************* ||

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (new ControlDB().modificar("factura", " f inner join detalle_orden d on d.id_factura = f.id_factura",
                "f.id_factura", f.Id_factura.ToString(), new string[] { "f.estado" }, new string[] { "'desabilitado'" }))
            {
                MessageBox.Show("Factura Eliminada correctamente");
                consultar();
                limpiarlbl();
            }
            else
            {
                MessageBox.Show("Error al Eliminar la factura seleccionada");
            }
        }

        private void cbpagado_si_CheckedChanged(object sender, EventArgs e)
        {
            if (cbpagado_si.Checked == true)
            {
                cbpagado_no.Checked = false;
            }
            else
            {
                cbpagado_no.Checked = true;
            }
        }

        private void cbpagado_no_CheckedChanged(object sender, EventArgs e)
        {
            if (cbpagado_no.Checked == true)
            {
                cbpagado_si.Checked = false;
            }
            else
            {
                cbpagado_si.Checked = true;
            }
        }

        private void cbentregado_si_CheckedChanged(object sender, EventArgs e)
        {
            if (cbentregado_si.Checked == true)
            {
                cbentregado_no.Checked = false;
            }
            else { cbentregado_no.Checked = true; }
        }

        private void cbentregado_no_CheckedChanged(object sender, EventArgs e)
        {
            if (cbentregado_no.Checked == true)
            {
                cbentregado_si.Checked = false;
            }
            else
            {
                cbentregado_si.Checked = true;
            }
        }



    }
}

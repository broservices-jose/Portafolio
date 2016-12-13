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
    public partial class RegistroOrden : Form
    {
        public RegistroOrden()
        {
            InitializeComponent();
            controles();
            consultar();
            dgvorden.Columns[0].Visible = false;
        }

        private void consultar()
        {
            dgvorden.DataSource = new Orden().consultar();
        }

        Orden ro = new Orden();

        private void controles ()
        {
            txtfecha.Clear();
            txtnoorden.Clear();
            txtsituacion.Clear();
            txtfecha_sal.Clear();
            txthora.Clear();
            cbnivel_combustible.Text = "";
            txtotro.Clear();
            rtevaluacion_previa.Clear();
            ckllave.Checked = false;
            ckllave_rueda.Checked = false;
            ckgato.Checked = false;
            ckrepuesta.Checked = false;
            ckencendedor.Checked = false;
            cktapabocina.Checked = false;
            ckradio.Checked = false;
            cktriangulo.Checked = false;
            

        }
        private void obtenerdatos()
        {
            pasavalres();
            ro.Num_orden = Convert.ToInt32(dgvorden.CurrentRow.Cells[0].Value);
            ro.Fecha = dgvorden.CurrentRow.Cells[1].Value.ToString();
            ro.Situacion = dgvorden.CurrentRow.Cells[2].Value.ToString();
            ro.Fecha_salida = dgvorden.CurrentRow.Cells[3].Value.ToString();
            ro.Combustible = dgvorden.CurrentRow.Cells[4].Value.ToString();
            ro.Llave = Convert.ToBoolean ( dgvorden.CurrentRow.Cells[5].Value);
            ro.Llave_rueda = Convert.ToBoolean(dgvorden.CurrentRow.Cells[6].Value);
            ro.Gato = Convert.ToBoolean(dgvorden.CurrentRow.Cells[7].Value);
            ro.Repuesta = Convert.ToBoolean(dgvorden.CurrentRow.Cells[8].Value);
            ro.Encededor = Convert.ToBoolean(dgvorden.CurrentRow.Cells[9].Value);
            ro.Tapabocina = Convert.ToBoolean(dgvorden.CurrentRow.Cells[10].Value);
            ro.Radio = Convert.ToBoolean(dgvorden.CurrentRow.Cells[11].Value);
            ro.Evaluacion_previa = dgvorden.CurrentRow.Cells[12].Value.ToString();

        }

        private void pasavalres()
        {
            ro.Num_orden = Convert.ToInt32( txtnoorden.Text);
            ro.Fecha = txtfecha.Text;
            ro.Situacion = txtsituacion.Text;
            ro.Fecha_salida = txtfecha_sal.Text;
            ro.Combustible = cbnivel_combustible.Text;
            ro.Combustible = cbnivel_combustible.Text;
            ro.Llave = Convert.ToBoolean( ckllave.CheckState);
            ro.Llave_rueda = Convert.ToBoolean(ckllave_rueda.CheckState);
            ro.Gato = Convert.ToBoolean(ckrepuesta.CheckState);
            ro.Repuesta = Convert.ToBoolean(ckrepuesta.CheckState);
            ro.Encededor = Convert.ToBoolean(ckencendedor.CheckState);
            ro.Tapabocina = Convert.ToBoolean(cktapabocina.CheckState);
            ro.Radio = Convert.ToBoolean(cktriangulo.CheckState);
            ro.Evaluacion_previa = rtevaluacion_previa.Text;  
        }
        
        private void RegistroOrden_Load(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (new Orden().ingresar(new string[] { ro.Num_orden.ToString(), ro.Fecha, ro.Situacion, ro.Kilometraje, ro.Combustible, ro.Llave.ToString(), ro.Llave_rueda.ToString(), ro.Gato.ToString(), ro.Tapabocina.ToString(), ro.Radio.ToString(), ro.Triangulo.ToString(), ro.Evaluacion_previa, ro.Repuesta.ToString(), ro.Estado_ingreso, ro.Fecha_salida }))
            {
                MessageBox.Show("Registro Ingresado Exitosamente");
                consultar();
            }
            else 
            {
                MessageBox.Show("Error al Insertar los datos");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clienteregistrado cr = new Clienteregistrado();
            cr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vehiculosregistrado vr = new Vehiculosregistrado();
            vr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistroVehiculo rv = new RegistroVehiculo();
            rv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistroCliente rc = new RegistroCliente();
            rc.Show();
        }



    }
}

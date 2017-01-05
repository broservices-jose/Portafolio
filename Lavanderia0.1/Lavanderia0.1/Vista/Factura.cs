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
using CrystalDecisions.CrystalReports;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Lavanderia0._1
{
    public partial class Factura : MetroForm, IDatoc, IDatoa
    {
        // ************************************************************** ||
        // Esta linea de codigo representa el metodo constructor Factura
        // el cual utilizamos para incializar los componentes de diseño 
        // y algunos metodos y funciones al realizar
        // ************************************************************** ||

        public Factura()
        {
            InitializeComponent();
            llenar();
            comparar();
            if (compara1 == compara2)
            {
                limpiardgv();
                textBox1.Text = "0.0";
                textBox2.Text = "0.0";
            }
            else
            {
                consultardetalle();
                llenarfact();
                dgvdetalle.Columns[0].Visible = false;
            }
            textBox1.BackColor = Color.Red;
            textBox2.BackColor = Color.Green;

        }


        // ************************************************************ ||
        // Esta linea de codigo representa  la declaracion de las varaibles
        // que se van utilizar en este formulario 
        // ************************************************************ ||

        private double subtotal =0;
        private int compara1, compara2, fid_cliente, fid_articulo;

        // ************************************************************************** ||
        // Esta linea de codigo representa la instanciacion de los objetos que van
        // interactura con la base de dato
        // ************************************************************************** ||
        CLFactura f = new CLFactura();
        CLServicio s = new CLServicio();

        // ************************************************************************* ||
        // Esta linea de codigo representa el metodo comparar() el cual nos va permitir
        // saber si al servicio sin imprimir
        // ************************************************************************* ||

        private void comparar()
        {
            compara1 = f.dameid1();
            compara2 = f.dameid2();
        }

        // ******************************************************************************************* ||
        // Esta linea de codigo representa el metodo consultardetalle() el cual nos va permitir llenar
        // el datagridview dgvfactura con los datos de los servicios realizados de la factura en la cual
        // se este trabajando
        // ******************************************************************************************* ||

        private void consultardetalle()
        {
            dgvdetalle.DataSource = new CLFactura().mostrardetalle(f.dameid2());
        }

        // ******************************************************************************************* ||
        // Esta linea de codigo representa el metodo consultardetalle() el cual nos va permitir llenar
        // el datagridview dgvfactura con los datos de los servicios realizados de la factura en la cual
        // se este trabajando
        // ******************************************************************************************* ||

        private void llenarfact()
        {
            f.llenarfac(textBox2, textBox1);
        }

        // ****************************************************************************** ||
        // Esta linea de codigo representa el metodo pasarfactura() el cual nos va permitir
        // tomar los datos de los diferentes cuadros de textos y almacenarlos en las variables
        // que van interactuar con la base de datos en la tabla detalle_orden
        // ****************************************************************************** ||


        private void pasardetalle()
        {
            f.Cantidad_articulo = Convert.ToInt32(txtcantidad.Text);
            f.Color = txtcolor.Text;
            f.Descuento = Convert.ToDouble(txtdescuento.Text);
            f.Subtotal = Convert.ToDouble(txtsubotal.Text);
           
        }

        // ***************************************************************************** ||
        // Esta linea de codigo representa el metodo pasarfactura() el cual nos va permitir
        // tomar los datos de los diferentes cuadros de textos y almacenarlos en las
        // variables que van interactuar con la base de datos en la tabla factura
        // ***************************************************************************** ||
        private void pasarfactura()
        {
            f.Fecha_recibido = dtf_recibo.Text;
            f.Fecha_entrega = dtf_entrega.Text;
            f.Hora_entrega = dthora_e.Text;

        }

         // ********************************************************************************** ||
        // Esta linea de codigo representa el metodo llenar el cual nos va permitir llenar el 
        // combobox cbservicio desde la tabla servicio
        // *********************************************************************************** ||

        private void llenar()
        {
            s.llenarcombo(cbservicio);
        }


        // ********************************************************************************** ||
        // Esta linea de codigo representa el metodo limpiar el cual nos va a permitir limpiar
        // los diferentes cuadros de textos
        // ********************************************************************************** ||

        private void limpiar()
        {
            txtdescuento.Text = "";
            txtcolor.Text = "";
            txtcategoria.Text = "";
            txtcantidad.Text = "";
            txtarticulo.Text = "";
            txtprecio.Text = "";
            txtsubotal.Text = "";
            dtf_entrega.ResetText();
        }

        // ********************************************************************************** ||
        // Esta linea de codigo representa el metodo limpiarcliente() el cual nos va a permitir
        // limpiar los datos del cliente y el del detalle_horario desde que se imprima una factura
        // ********************************************************************************** ||

        private void limpiarcliente()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txttelefono.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            dtf_entrega.ResetText();
            dthora_e.ResetText();

        }

        // ************************************************************************************* ||
        // Esta linea de codigo representa el metodo limpiardgv() el cual nos va permitir limpiar
        // todas las filas del datagridview dgvdetalle
        // ************************************************************************************* ||

        private void limpiardgv()
        {
            while (dgvdetalle.RowCount > 1)
            {
                dgvdetalle.Rows.Remove(dgvdetalle.CurrentRow);
            }
        }

        // *************************************************************************************************** ||
        // Esta linea de codigo representa el metodo obtener el cual nos va a permitir llenar los diferentes
        // cuadros de textos cuando seleccionemos una fila del datagridview dgvdetalle
        // *************************************************************************************************** ||

        private void obtener()
        {
            txtnombre.Text = dgvdetalle.CurrentRow.Cells[1].Value.ToString();
            cbservicio.Text = dgvdetalle.CurrentRow.Cells[2].Value.ToString();
            txtarticulo.Text = dgvdetalle.CurrentRow.Cells[3].Value.ToString();
            txtcategoria.Text = dgvdetalle.CurrentRow.Cells[4].Value.ToString();
            txtcolor.Text = dgvdetalle.CurrentRow.Cells[5].Value.ToString();
            txtcantidad.Text = dgvdetalle.CurrentRow.Cells[6].Value.ToString();
            dtf_recibo.Text = dgvdetalle.CurrentRow.Cells[7].Value.ToString();
            dtf_entrega.Text = dgvdetalle.CurrentRow.Cells[8].Value.ToString();
            txtdescuento.Text = dgvdetalle.CurrentRow.Cells[10].Value.ToString();
            txtsubotal.Text = dgvdetalle.CurrentRow.Cells[9].Value.ToString();
        }

        // *************************************************************************************************** ||
        // Esta linea de codigo representa el metodo obtenerid() el cual nos va a permitir pasarle el id del 
        // de detalle de orden de la tabla detalle_orden a la variable Id_detalle_orden la cual se encuentra 
        // encapsulada
        // *************************************************************************************************** ||

        private void obtenerid()
        {
            if (dgvdetalle.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Debe de seleccionar una fila con datos");
            }
            else
            {
                f.Id_detalle_orden = Convert.ToInt32(dgvdetalle.CurrentRow.Cells[0].Value.ToString());
            }
        }

  //    || ******************************************************************************** ||
  //    || Esta linea de codigo en adelante el cual tiene su inicio y su final representa   ||
  //    || los mensajes para el usuario que se van a presentar a la hora de pasar el mouse  ||
  //    || sobre uno de los botones del formulario                                          ||
  //    || ******************************************************************************** ||
                                                                                      //    ||
        private void btnmodificar_MouseHover_1(object sender, EventArgs e)            //    ||
        {                                                                             //    ||
            this.toolTip1.IsBalloon = true;                                           //    ||
        }                                                                             //    ||
                                                                                      //    ||
        private void btneliminar_MouseHover(object sender, EventArgs e)               //    ||
        {                                                                             //    ||
            this.toolTip1.IsBalloon = true;                                           //    ||
            this.toolTip1.SetToolTip(btneliminar, "Boton Eliminar");                  //    ||
        }                                                                             //    ||
                                                                                      //    ||
        private void btnlimpiar_MouseHover(object sender, EventArgs e)                //    ||
        {                                                                             //    ||
            this.toolTip1.IsBalloon = true;                                           //    ||
            this.toolTip1.SetToolTip(btnlimpiar, "Boton Limpiar");                    //    ||
        }                                                                             //    ||
                                                                                      //    ||
        private void btnguardar_MouseHover(object sender, EventArgs e)                //    ||
        {                                                                             //    ||
            this.toolTip1.IsBalloon = true;                                           //    ||
            this.toolTip1.SetToolTip(btnguardar, "Boton Guardar");                    //    ||
        }                                                                             //    ||
                                                                                      //    ||
        private void button1_MouseHover(object sender, EventArgs e)                   //    ||
        {                                                                             //    ||
            this.toolTip1.IsBalloon = true;                                           //    ||
            this.toolTip1.SetToolTip(button1, "Boton Buscar Cliente");                //    ||
        }                                                                             //    ||

        private void button2_MouseHover(object sender, EventArgs e)                   //    ||
        {                                                                             //    ||
            this.toolTip1.IsBalloon = true;                                           //    ||
            this.toolTip1.SetToolTip(button2, "Boton Buscar Articulo");               //    ||
        }                                                                             //    ||
                                                                                      //    ||
        private void button9_MouseHover(object sender, EventArgs e)                   //    ||
        {                                                                             //    ||
            this.toolTip1.IsBalloon = true;                                           //    ||
            this.toolTip1.SetToolTip(button9, "Boton Salir");                         //    ||
        }                                                                             //    ||
                                                                                      //    ||
        private void btnimprimir_MouseHover(object sender, EventArgs e)               //    ||
        {                                                                             //    ||
            this.toolTip1.IsBalloon = true;                                           //    ||
            this.toolTip1.SetToolTip(btnimprimir, "Boton Imprimir");                  //    ||
        }                                                                             //    ||
                                                                                      //    ||
        // *********************************************************************************||
        //Aqui ha finalizado la linea de codigo que nos permite mostra un mensaje al usuario||
        // *********************************************************************************||


        // ***********************************************************************************
        // Esta linea de codigo representa el evento Leave el cual nos va permitir calcular 
        // subtotal del servicio seleccionado
        // ***********************************************************************************

        private void txtdescuento_Leave(object sender, EventArgs e)
        {
            if (txtprecio.Text == "")
            {
                MessageBox.Show("Debe de seleccionar un servicio");
            }
            else
            {
                if (txtdescuento.Text == "")
                {
                    MessageBox.Show("Debe de introducir un porcetaje");
                }
                else
                {
                        f.Total_desc = Convert.ToDouble(txtdescuento.Text) / 100;
                        subtotal = Convert.ToDouble(txtprecio.Text) * Convert.ToInt32(txtcantidad.Text);
                        f.Total_desc = Convert.ToDouble(txtprecio.Text) * f.Total_desc;
                        subtotal -= f.Total_desc;
                        txtsubotal.Text = subtotal.ToString();
                }
            }
        }

        private void cbservicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtprecio.Text = s.obtenerp(Convert.ToInt32(cbservicio.SelectedValue));
            f.Id_servicio = Convert.ToInt32(cbservicio.SelectedValue);
        }

        private void Factura_FormClosed(object sender, FormClosedEventArgs e)
        {
            ///=============================
            ///
            //Menu f = ((Menu)this.MdiParent);
            //f.btnservicio.Enabled = true;

            
            
        }

        // ********************************************************************************** ||
        // Esta linea de codigo representa el evento click del boton btnguardar el cual vamos
        // a utilizar para guardar los datos socilicito de este formulario
        // ********************************************************************************** ||

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (validetalle() == true)
            {
        
                    // ************************************* ||
                    // Este metodo es para pasar los datos 
                    // de los cuadros de textos a la variables
                    // ************************************ ||

                    pasardetalle();

                    // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                    if (new ControlDB().generarInsert(new string[]{"cantida_articulo", "color",  
                          "subtotal", "descuento", "totaldesc", "id_servicio", "id_articulo" },
                         new string[]{f.Cantidad_articulo.ToString(), f.Color, f.Subtotal.ToString(),
                         f.Descuento.ToString(), f.Total_desc.ToString(), f.Id_servicio.ToString(),
                          fid_articulo.ToString()}, "detalle_orden"))
                    {
                        MessageBox.Show("Servicio registrado correctamente");
                        limpiar();
                        consultardetalle();
                        llenarfact();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el servicio solicitado");
                    }

                    // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            }
            else {
                MessageBox.Show("Deve llenar los campos");
            }
            
        }

        private void dgvdetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtener();
            btneliminar.Enabled = true;
            btnguardar.Enabled = false;
            
        }

        private void dgvdetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtener();
            btneliminar.Enabled = true;
            btnguardar.Enabled = false;

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            btnguardar.Enabled = true;
            btnlimpiar.Enabled = false;
        }

        // **************************************************************************************** ||
        // Esta linea de codigo representa el evento click del boton btneliminar el cual nos va 
        // permitir eliminar los datos del servicio seleccionados por el usuario
        // **************************************************************************************** ||

        private void btneliminar_Click(object sender, EventArgs e)
        {
 
            if (new ControlDB().eliminar("detalle_orden", "delete detalle_orden from detalle_orden"+
                " inner join articulo on articulo.id_articulo = detalle_orden.id_articulo"+ 
                " inner join servicio on servicio.id_servicio = detalle_orden.id_servicio",
                " detalle_orden.id_detalle_orden", f.Id_detalle_orden.ToString()))
            {
                MessageBox.Show("Servicio eliminado correctamente");
                limpiar();
                consultardetalle();
            }
            else
            {
                MessageBox.Show("Error al eliminar el servicio solicitado ");
            }
        }


        //============================================================================//
        //Metodo para validar el cliente==============================================//
        private bool valicliente() {
            if(txtnombre.Text==""){
                lbllnombre.Visible = true;
                return false;
            }
            if(txtapellido.Text==""){
                lbllapellido.Visible = true;
                return false;
            }
            if(txttelefono.Text ==""){
                lblltelefono.Visible = true;
                return false;
            }
            return true;
        }

        // =======================================================================//
        // metodo para desvalidar cliente========================================
        private void desvalicliente() {
            lbllnombre.Visible = false;
            lbllapellido.Visible = false;
            lblltelefono.Visible = false;
        }

        // ================================================================================================= ||
        // Esta linea de codigo representa el metodo imprimir() para imprimir la factura en la cual estemos 
        // trabajando 
        // ================================================================================================= ||

        private void imprimir()
        {
            try
            {
                ReportDocument crystalrpt = new ReportDocument();
                crystalrpt.Load("C:\\Users\\JOSE\\Documents\\Visual Studio 2013\\Projects\\Proyectos\\Lavanderia0.1\\Lavanderia0.1\\reporte1.rpt");

                ParameterFieldDefinition definicion_parametro;
                ParameterFieldDefinitions definiciones_parametros;
                ParameterValues valor = new ParameterValues();
                ParameterDiscreteValue discretevalor = new ParameterDiscreteValue();

                discretevalor.Value = 3; //f.dameid1();
                definiciones_parametros = crystalrpt.DataDefinition.ParameterFields;
                definicion_parametro = definiciones_parametros["param1"];
                valor = definicion_parametro.CurrentValues;

                valor.Clear();
                valor.Add(discretevalor);
                definicion_parametro.ApplyCurrentValues(valor);
                crystalrpt.PrintToPrinter(1, true, 0, 0);
            }
            catch (CrystalReportsException cr)
            {
                MessageBox.Show(cr.Message);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            
        }            


        //  ***************************************************************************** ||
        // Esta linea de codigo representa el evento click del boton btnimprimir el cual 
        // nos va permitir imprimir y guardar al mismo tiempo la factura en la que estemos
        // trabajemos 
        // ****************************************************************************** ||

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            // ************************************************************************* ||
            // Esta linea de codigo representa la llamada del metodo pasarfactura el cual
            // nos va permitir llenar las variables que se almacenar en la tabla factura
            // ************************************************************************* ||

            pasarfactura();

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


            if (valicliente() == true)
            {
                if (fid_cliente == 0)
                {
                    if (new CLCliente().generarproc(txtnombre.Text, txtapellido.Text, txttelefono.Text))
                    {
                        if (new ControlDB().generarInsert(new string[] { "total_desc", "total", "id_cliente", "fecha_recibido",
                            "fecha_entrega", "hora_entrega" }, new string[] { textBox2.Text, textBox1.Text,
                             new CLCliente().ultimoid().ToString(), f.Fecha_recibido, f.Fecha_entrega, f.Hora_entrega }, "factura"))
                        {
                            
                            desvalicliente();
                            limpiardgv();
                            limpiarcliente();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo imprimir ");
                        }
                    }
                }
                else
                {
                    if (new ControlDB().generarInsert(new string[] { "total_desc", "total", "id_cliente", "fecha_recibido", 
                        "fecha_entrega", "hora_entrega" }, new string[] { textBox2.Text, textBox1.Text, fid_cliente.ToString(),
                         f.Fecha_recibido, f.Fecha_entrega, f.Hora_entrega}, "factura"))
                    {
                        MessageBox.Show("Aqui va la impresion");
                        desvalicliente();
                        limpiardgv();
                        limpiarcliente();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo imprimir ");
                    }
                }

                // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            }
            else {
                MessageBox.Show("Debe llenar los datos del cliente");
            }
        }

        private void txtdescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtdescuento_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtcolor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        //==================================================///
        //metodo para validar detalle=======================//
        private bool validetalle() {
            if (cbservicio.Text == "") { 
            lbllservicio.Visible = true;
            return false;
            }
            if (txtcantidad.Text == "") {
                lbllcantidad.Visible = true;
                return false;
            }
            if (txtarticulo.Text == "") {
                lbllarticulo.Visible = true;
                return false;
            }
            return true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        // ****************************************************************** ||
        // Esta linea de codigo representa el evnto click del boton button1
        // el cual nos va a permitir llamar el formulario clientes_reg que
        // vamos a utilizar para cargar los datos del cliente seleccionado 
        // ****************************************************************** ||


        private void button1_Click(object sender, EventArgs e)
        {
            Clientes_reg c = new Clientes_reg();
            c.llamador = this;
            c.MdiParent = this.MdiParent;
            c.Show();
        }

        // **************************************************************************** ||
        // Esta linea de codigo representa el metodo cargardato() el cual recibe como
        // parametro un objecto de la clase CLCliente que nos va retornar, dicho metodo
        // es el que nos permite la comunicacion entre los dos formulario que van a interactuar
        // **************************************************************************** ||

        public void cargardato(CLCliente datos)
        {
            fid_cliente = datos.Id_cliente;
            txtnombre.Text = datos.Nombre;
            txtapellido.Text = datos.Apellido;
            txttelefono.Text = datos.Telefono;
        }

        // ****************************************************************** ||
        // Esta linea de codigo representa el evnto click del boton button2
        // el cual nos va a permitir llamar el formulario articulos_reg que
        // vamos a utilizar para cargar los datos del articulo seleccionado 
        // ****************************************************************** ||

        private void button2_Click(object sender, EventArgs e)
        {
            Articulos_reg a = new Articulos_reg();
            a.llamador = this;
            a.MdiParent = this.MdiParent;
            a.Show();
            
        }


        // **************************************************************************** ||
        // Esta linea de codigo representa el metodo cargardato() el cual recibe como
        // parametro un objecto de la clase CLCliente que nos va retornar, dicho metodo
        // es el que nos permite la comunicacion entre los dos formulario que van a interactuar
        // **************************************************************************** ||

        public void cargardato(CLArticulo datos)
        {
            fid_articulo = datos.Id_articulo;
            txtarticulo.Text = datos.Articulo;
            txtcategoria.Text = datos.Categoria;
        }
       

    }
}


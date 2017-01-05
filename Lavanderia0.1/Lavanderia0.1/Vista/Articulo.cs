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
    public partial class Articulo : MetroForm
    {

        // ********************************************************************************** \\
        // Esta linea de codigo representa el metodo constructor el cual nos va a permitir
        // iniciarlizar todos los componentes del formulario Articulo
        // ********************************************************************************** \\

        public Articulo()
        {
            InitializeComponent();
            consulta();
            dgvarticulo.Columns[0].Visible = false;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
         
        }

        // *************************************************************************************** \\
        // Esta linea de codigo representa la creacion o instanciacion de los objectos da las 
        // diferentes clases que van interactuar con la base de datos fulanita
        // *************************************************************************************** \\

        CLArticulo a = new CLArticulo();


        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo consulta() el cual nos va ha atraer todos los 
        // datos de las tablas articulo para llenar el datagridview dgvarticulo
        // *************************************************************************************** \\

        private void consulta()
        {
            dgvarticulo.DataSource = new CLArticulo().consultar();
        }

        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo obtener() el cual nos va a permitir obtener
        // los datos de empledo que se van a vizualizar en los cuadros de texto del formulario de dicho modulo
        // *************************************************************************************** \\

        private void obtener()
        {
            txtarticulo.Text = dgvarticulo.CurrentRow.Cells[1].Value.ToString();
            txtcategoria.Text = dgvarticulo.CurrentRow.Cells[2].Value.ToString();
            txtdescripcion.Text = dgvarticulo.CurrentRow.Cells[3].Value.ToString();
        }


        // ********************************************************************************************* \\
        // Este linea de codigo representa el metodo obtenerid() el cual nos va a permitir obtener 
        // el id del empleado seleccionado para luego ser utilizado de diversas formas como eliminar, etc
        // ********************************************************************************************** \\

        private void obtenerid()
        {
            if (dgvarticulo.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Debe de seleccionar una fila con datos");
            }
            else
            {
                a.Id_articulo = Convert.ToInt32(dgvarticulo.CurrentRow.Cells[0].Value.ToString());

            }
        }


        // *************************************************************************************** \\
        // Esta linea de codigo representa el metodo pasarvalor() el cual nos va a permitir obtener
        // los datos de los diferentes cuadro de textos que tiene el formulario empleado para luego
        // ser registrado en la tabla empleado de la base de datos
        // *************************************************************************************** \\

        private void pasarvalor()
        {
            a.Articulo = txtarticulo.Text;
            a.Categoria = txtcategoria.Text;
            a.Descripcion = txtdescripcion.Text;
        }

        // ===========================================================================================//
        // ESte es el metodo para validar los campos

        private bool validartxt() {

            if (txtarticulo.Text == "") {
                lbllarticulo.Visible = true;
                return false;
            
            

           
           }

            return true;
        }

        ///==========================================================///
        ///METODO PARA RESTABLECER VALIDACIONES======================///
        ///==========================================================///
        private void desvalidartxt()
        {
            
            lbllarticulo.Visible = false;
         


        }



        // ******************************************************************************* \\
        // Esta linea de codigo representa el metodo limpiar() el cual nos va a permitir 
        // limpiar todos los cuadros de textos del formulario cuando llamemo a este
        // ******************************************************************************* \\

        private void limpiar()
        {
            txtarticulo.Text = "";
            txtcategoria.Text = "";
            txtdescripcion.Text = "";
        }


        private void btnguardar_MouseHover(object sender, EventArgs e)
        {
           
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnguardar, "Boton Guardar");
        }

        private void btnlimpiar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnlimpiar, "Boton Eliminar");
        }

        private void btnmodificar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnmodificar, "Boton Modificar");
        }

        private void btneliminar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btneliminar, "Boton Eliminar");
        }

        private void btnbuscar_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnbuscar, "Boton Buscar ");
        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btnregistrar el cual va a utilizar para guardar los datos en la bd
        // ******************************************************************* \\

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (validartxt() == true)
            {
                pasarvalor();
                if (new ControlDB().generarInsert(new string[] { "articulo", "categoria", "descripcion" }, new string[] { a.Articulo, a.Categoria, a.Descripcion }, "articulo"))
                {   
                    MessageBox.Show("Los Datos han sido registrado correctamente");
                    consulta();
                    desvalidartxt();
                    limpiar();
                    
                }
                else
                {
                    MessageBox.Show("Error al registrar los datos solicitados");
                }
            }
            else {
                MessageBox.Show("HAY CAMPOS VACIOS");
            }
        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btnlimpiar el cual va a utilizar para limpiar todos los cuadros_textos
        // ******************************************************************* \\

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            desvalidartxt();
            limpiar();
        }

        private void dgvarticulo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerid();
            obtener();
            btnmodificar.Enabled = false;
            btneliminar.Enabled = true;
            btnguardar.Enabled = false;
            btnlimpiar.Enabled = false;
        }

        private void dgvarticulo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtener();
            btnmodificar.Enabled = true;
            btneliminar.Enabled = false;
            btnguardar.Enabled = false;
            btnlimpiar.Enabled = false;
        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btnmodificar el cual va a utilizar para modificar los datos socilitados
        // en la base de datos dblavanderia
        // ******************************************************************* \\

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            
            if(validartxt()==true){
            
            pasarvalor();
            obtenerid();

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

            if (new ControlDB().modificar("articulo", "", "id_articulo", a.Id_articulo.ToString(), new string[] { "articulo", "categoria", "descripcion" }, 
                new string[] { a.Articulo, a.Categoria, a.Descripcion }))
            {
                MessageBox.Show("Los datos se han modificados correctamente");
                consulta();
                limpiar();
                desvalidartxt();
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
                btnguardar.Enabled = true;
                btnlimpiar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error al modificar los datos seleccionado");
            }  }

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

        }

        // ******************************************************************* \\
        // Esta linea de codigo en adelante representa el vento clic del boton
        // btneliminar el cual va a utilizar para eliminar los datos socilitados
        // desde el formulario empleado en la base de datos dblavanderia
        // ******************************************************************* \\

        private void btneliminar_Click(object sender, EventArgs e)
        {
            obtenerid();
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

            if (new ControlDB().eliminar("from articulo", "", "id_articulo", a.Id_articulo.ToString()))
            {
                MessageBox.Show("Datos eliminados correctamente");
                consulta();
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
                btnguardar.Enabled = true;
                btnlimpiar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error al eliminar los datos solicitados");
            }

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ||

        }

        private void txtarticulo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void Articulo_Load(object sender, EventArgs e)
        {

        }


    }
}

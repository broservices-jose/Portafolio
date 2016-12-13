using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentSender.Formularios
{
    public partial class AgEmpleado : Form
    {
        public AgEmpleado()
        {
            InitializeComponent();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            bool empleadoValido = false;
            bool tieneUsuario = false;

            if (Clases.Validacion.EsValido(tboxNombre)
                && Clases.Validacion.EsValido(tboxApellido)
                && Clases.Validacion.EsValido(tboxCedula)
                && Clases.Validacion.EsValido(comboTipo)
                && Clases.Validacion.EsValido(comboDepartamento))
            {
                // Si el tipo es secretaria o recepcionista, verificar cuenta y contraseña
                if (comboTipo.SelectedItem.ToString() == Clases.TipoEmpleado.Secretaria.ToString() || comboTipo.SelectedItem.ToString() == Clases.TipoEmpleado.Recepcionista.ToString())
                {
                    tieneUsuario = true;

                    if ((Clases.Validacion.EsValido(tboxCuenta) && Clases.Validacion.EsValido(tboxContraseña)))
                    {
                        empleadoValido = true; // todo esta valido
                    }
                    else
                    {
                        empleadoValido = false; // se indico que es secretaria/recepcionista, pero uno de los campos cuenta o contraseña no es valido
                    }
                }
                else
                {
                    empleadoValido = true; // El empleado no lleva usuario
                }
            }

            if (empleadoValido)
            {
                Sistema.Instancia.AgregarEmpleado(
                       tboxNombre.Text,
                       tboxApellido.Text,
                       tboxCedula.Text,
                       (Clases.TipoEmpleado)comboTipo.SelectedIndex + 1,
                       comboDepartamento.SelectedItem.ToString());
                
                if (tieneUsuario)
                {
                    Sistema.Instancia.AgregarUsuario(Sistema.Instancia.Empleados.Last(), tboxCuenta.Text, tboxContraseña.Text);
                }

                this.Close();
            }
        }

        private void AgEmpleado_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            comboDepartamento.Items.Clear();

            foreach (object departamento in Sistema.Instancia.Departamentos.Select(x => x.Nombre).ToArray())
            {
                comboDepartamento.Items.Add(departamento);
            }
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // activar o desactivar el GroupBox de usuario dependiendo del tipo que se escogio
            if (comboTipo.SelectedItem.ToString() == Clases.TipoEmpleado.Secretaria.ToString() || comboTipo.SelectedItem.ToString() == Clases.TipoEmpleado.Recepcionista.ToString())
            {
                groupBox1.Enabled = true;
            }
            else groupBox1.Enabled = false;
        }
    }
}

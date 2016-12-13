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
    public partial class RegRecExterna : Form
    {
        public RegRecExterna()
        {
            InitializeComponent();
        }

        private void RegRecExterna_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection lDocs = new AutoCompleteStringCollection();
            //lDocs.AddRange(Sistema.Instancia.Documentos.Where(x => x.UltimoEnvio.Completado == true).Select(x => x.Numero).ToArray());
            //MessageBox.Show(Sistema.Instancia.Documentos.Where(x => x.UltimoEnvio.Completado == true).Select(x => x.Numero).ToArray().Count().ToString());
            //tboxNumeroDoc.AutoCompleteCustomSource = lDocs;
            tboxNumeroDoc.Text = Clases.Validacion.GenerarNumeroDocumento();

            AutoCompleteStringCollection lEmpl = new AutoCompleteStringCollection();
            lEmpl.AddRange(Sistema.Instancia.Empleados.Select(x => x.Nombre + " " + x.Apellido).ToArray());
            tboxRemitente.AutoCompleteCustomSource = lEmpl;

            AutoCompleteStringCollection lMens = new AutoCompleteStringCollection();
            lMens.AddRange(Sistema.Instancia.Empleados.Where(x => x.Tipo == Clases.TipoEmpleado.Mensajero).Select(x => x.Nombre + " " + x.Apellido).ToArray());
            tboxMensajero.AutoCompleteCustomSource = lMens;
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            DateTime hora;
            Clases.Empleado destinatario;
            Clases.Empleado mensajero;

            if (Clases.Validacion.EsValido(tboxNumeroDoc)
                && Clases.Validacion.EsValido(tboxAsunto)
                && Clases.Validacion.ExisteEmpleado(tboxRemitente, out destinatario)
                && Clases.Validacion.ExisteMensajero(tboxMensajero, out mensajero)
                && Clases.Validacion.HoraValida(tboxHora, out hora)
                && Clases.Validacion.EsValido(tboxDireccion)
                && Clases.Validacion.EsValido(tboxEmpresa)
                && Clases.Validacion.EsValido(tboxTelefono))
            {
                Sistema.Instancia.RegistrarEnvioExterno(tboxNumeroDoc.Text, null, destinatario, mensajero, null, Clases.Validacion.SumarTiempo(dateFecha.Value, hora), tboxAsunto.Text, tboxDireccion.Text, tboxTelefono.Text, tboxEmpresa.Text);
                this.Close();
            }
        }
    }
}

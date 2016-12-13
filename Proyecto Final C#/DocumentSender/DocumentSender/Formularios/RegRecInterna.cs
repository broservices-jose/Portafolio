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
    public partial class RegRecInterna : Form
    {
        /// <summary>
        /// Establece si sera recepcion de documetos internos. Si es falso, tendra todos los documentos
        /// </summary>
        public bool interno;

        public RegRecInterna()
        {
            InitializeComponent();
        }

        private void RegRecInterna_Load(object sender, EventArgs e)
        {
            // Seleccionar solo los documentos (el numero) cuyo ultimo envio no este completo
            AutoCompleteStringCollection lDocs = new AutoCompleteStringCollection();
            List<string> envios = interno ? Sistema.Instancia.Documentos.Where(x => x.UltimoEnvioInterno.Completado == false).Select(x => x.Numero).ToList() : Sistema.Instancia.Documentos.Where(x => x.UltimoEnvio.Completado == false).Select(x => x.Numero).ToList();
            listBox1.Items.AddRange(envios.ToArray());
            lDocs.AddRange(envios.ToArray());
            tboxNumeroDoc.AutoCompleteCustomSource = lDocs;
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            DateTime hora;
            Clases.Documento documento;

            if (Clases.Validacion.ExisteDocumento(tboxNumeroDoc, out documento)
                && Clases.Validacion.HoraValida(tboxHora, out hora))
            {
                // Validar si el documento fue enviado internamente
                if (documento.UltimoEnvio.ID == documento.UltimoEnvioInterno.ID)
                {
                    Sistema.Instancia.RegistrarRecepcionInterna(documento, Clases.Validacion.SumarTiempo(dateFecha.Value, hora), documento.UltimoEnvio);
                }
                // Si no es interno, verificar que el usuario sea una recepcionista y que le ultimo envio sea el ultimo envio externo
                else if (!interno && documento.UltimoEnvio.ID == documento.UltimoEnvioExterno.ID)
                {
                    Sistema.Instancia.RegistrarRecepcionExterna(documento, Clases.Validacion.SumarTiempo(dateFecha.Value, hora), documento.UltimoEnvio);
                    this.Close();
                }
                else
                { }
            }
        }
    }
}

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
    public partial class RegRecEntranteCompletado : Form
    {
        public RegRecEntranteCompletado()
        {
            InitializeComponent();
        }

        private void RegRecEntranteCompletado_Load(object sender, EventArgs e)
        {
            // Seleccionar solo los documentos (el numero) cuyo ultimo envio no este completo
            AutoCompleteStringCollection lDocs = new AutoCompleteStringCollection();
            lDocs.AddRange(Sistema.Instancia.Documentos.Where(x => x.UltimoEnvio.Completado == false).Select(x => x.Numero).ToArray());
            tboxNumeroDoc.AutoCompleteCustomSource = lDocs;
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            DateTime hora;
            Clases.Documento documento;

            if (Clases.Validacion.ExisteDocumento(tboxNumeroDoc, out documento)
                && Clases.Validacion.HoraValida(tboxHora, out hora))
            {
                Sistema.Instancia.RegistrarRecepcionExterna(documento, Clases.Validacion.SumarTiempo(dateFecha.Value, hora), documento.UltimoEnvio);
                this.Close();
            }
        }
    }
}

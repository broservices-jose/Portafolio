using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSender.Clases
{
    public class EnvioInterno: Envio
    {
        public EnvioInterno(Documento documento, Empleado remitente, Empleado destinatario, Empleado mensajero, DateTime? enviado, string asunto)
        {
            this.Documento = documento;
            this.Remitente = remitente;
            this.Destinatario = destinatario;
            this.Mensajero = mensajero;
            this.Enviado = enviado;
            this.Asunto = asunto;
        }
    }
}

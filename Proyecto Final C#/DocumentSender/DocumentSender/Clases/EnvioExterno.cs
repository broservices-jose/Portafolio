using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSender.Clases
{
    public class EnvioExterno : Envio
    {
        public string Direccion;
        public string Telefono;
        public string Empresa;

        public EnvioExterno(Documento documento, Empleado remitente, Empleado destinatario, Empleado mensajero, DateTime? enviado, DateTime? recibido, string direccion, string telefono, string asunto, string empresa)
        {
            this.Documento = documento;
            this.Remitente = remitente == null ? Sistema.Instancia.Empleados.Where(x => x.Tipo == TipoEmpleado.Administrador).First() : remitente;
            this.Destinatario = destinatario == null? Sistema.Instancia.Empleados.Where(x => x.Tipo == TipoEmpleado.Administrador).First(): destinatario;
            this.Mensajero = mensajero;
            this.Enviado = enviado;
            this.Recibido = recibido;
            this.Asunto = asunto;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Empresa = empresa;
        }
    }
}

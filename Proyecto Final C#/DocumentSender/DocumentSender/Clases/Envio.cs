using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSender.Clases
{
    public class Envio
    {
        public int ID;
        public Documento Documento;
        public Empleado Remitente;
        public Empleado Destinatario;
        public Empleado Mensajero;
        public DateTime? Enviado;
        public DateTime? Recibido;
        public string Asunto;
        public bool Completado = false;

        /// <summary>
        /// Registra que el envio ya fue recibido.
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        public bool RegistrarRecepcion(DateTime recibido)
        {
            this.Recibido = recibido;
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSender.Clases
{
    public class Documento
    {
        public int ID;
        public string Numero;
        public List<Envio> Envios = new List<Envio>();

        public EnvioInterno UltimoEnvioInterno
        {
            get
            {
                //try { System.Windows.Forms.MessageBox.Show(Envios.OrderBy(x => x.Enviado).FirstOrDefault().ID.ToString()); }
                //catch { };
                List<EnvioInterno> lista = new List<EnvioInterno>();

                foreach (EnvioInterno envio in Sistema.Instancia.EnviosInternos)
                {
                    foreach (Envio local in Envios)
                    {
                        if (envio.ID == local.ID) lista.Add(envio);
                    }
                }
                return lista.OrderByDescending(x => x.Enviado).FirstOrDefault();
                //return Envios.Where(x => x.ID  in Instancia.EnviosInternos.Select(x => x.Documento).OrderByDescending(x => x.Enviado).FirstOrDefault();
            }
        }

        public EnvioExterno UltimoEnvioExterno
        {
            get
            {
                //try { System.Windows.Forms.MessageBox.Show(Envios.OrderBy(x => x.Enviado).FirstOrDefault().ID.ToString()); }
                //catch { };
                List<EnvioExterno> lista = new List<EnvioExterno>();

                foreach (EnvioExterno envio in Sistema.Instancia.EnviosExternos)
                {
                    foreach (Envio local in Envios)
                    {
                        if (envio.ID == local.ID) lista.Add(envio);
                    }
                }
                return lista.OrderByDescending(x => x.Enviado).FirstOrDefault();
                //return Envios.Where(x => x.ID  in Instancia.EnviosInternos.Select(x => x.Documento).OrderByDescending(x => x.Enviado).FirstOrDefault();
            }
        }

        public Envio UltimoEnvio
        {
            get
            {
                //try { System.Windows.Forms.MessageBox.Show(Envios.OrderBy(x => x.Enviado).FirstOrDefault().ID.ToString()); }
                //catch { };
                return Envios.OrderByDescending(x => x.Enviado).FirstOrDefault();
            }
        }

        public Documento(string numero)
        {
            this.Numero = numero;
        }
    }
}

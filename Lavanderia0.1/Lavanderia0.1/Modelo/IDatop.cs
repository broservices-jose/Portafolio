using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavanderia0._1.Vista;

namespace Lavanderia0._1.Modelo
{
    public interface IDatop
    {
        void cargardato(CPagodenomina datos);
    }

    public interface IDatou
    {
        void cargardato(CLUsuario datos);
    }

    public interface IDatoc
    {
        void cargardato(CLCliente datos);
    }

    public interface IDatoa
    {
        void cargardato(CLArticulo datos);
    }
}

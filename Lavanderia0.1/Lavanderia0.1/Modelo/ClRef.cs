using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavanderia0._1.Modelo
{
    class ClRef
    {
        // **************************************************************************** \\
        // Esta linea de codigo en adelante representa la declaracion y encapsulamiento
        // de las variables que nos van a permitir interactuar con la base de datos
        // **************************************************************************** \\

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSender.Clases
{
    public class Departamento
    {
        public int ID;
        public string Nombre;
        public List<Empleado> Empleados;

        public Departamento(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}

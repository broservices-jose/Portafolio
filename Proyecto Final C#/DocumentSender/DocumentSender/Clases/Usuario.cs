using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSender.Clases
{
    public class Usuario
    {
        public Empleado Empleado;
        public string Cuenta;
        public string Contraseña;

        public Usuario(Empleado empleado, string cuenta, string contraseña)
        {
            this.Empleado = empleado;
            this.Cuenta = cuenta;
            this.Contraseña = contraseña;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSender.Clases
{
    public class Empleado
    {
        public int ID; // El empleado con Tipo Administrador es el unico adminitrador, cuyo buzon es el general (envios externos)
        public string Nombre;
        public string Apellido;
        public string Cedula;
        public TipoEmpleado Tipo;
        public Departamento Departamento;
        public bool TieneUsuario
        {
            // Buscar si hay un usuario cuyo empleado sea este
            get { return (Sistema.Instancia.Usuarios.Where(x => x.Empleado == this).FirstOrDefault() != null); }
        }
        public Usuario Usuario // Primero verificar si TieneUsuario
        {
            get { return Sistema.Instancia.Usuarios.Where(x => x.Empleado == this).FirstOrDefault(); }
        }

        public List<Documento> Buzon = new List<Documento>(); // Al parecer hay que ordenar los Documentos por orden de llegada (o de salida)

        public Empleado(string nombre, string apellido, string cedula, TipoEmpleado tipo, Departamento departamento)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Tipo = tipo;
            this.Departamento = departamento;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentSender.Clases;
using DocumentSender.Formularios;
using System.Windows.Forms;

namespace DocumentSender
{
    public class Sistema
    {
        #region Metodos de agregacion --------------------------------------------------------------


        public bool AgregarDepartamento(string nombre)
        {
            Departamento departamento = new Departamento(nombre);
            Instancia.Departamentos.Add(departamento);

            int tmpId = DB.AgregarDepartamento(departamento);
            if (tmpId == -1) // Ocurrio un error
            {
                return false;
            }
            else
            {
                departamento.ID = tmpId;
                return true;
            }
        }

        public bool AgregarEmpleado(string nombre, string apellido, string cedula, TipoEmpleado tipo, string departamento)
        {
            Departamento tmpDepartamento = Instancia.Departamentos.Where(x => x.Nombre == departamento).FirstOrDefault();
            Empleado empleado = new Empleado(nombre, apellido, cedula, tipo, tmpDepartamento);
            Instancia.Empleados.Add(empleado);

            int tmpId = DB.AgregarEmpleado(empleado); // Agregar empleado a la base de datos
            if (tmpId == -1) // Ocurrio un error
            {
                return false;
            }
            else
            {
                empleado.ID = tmpId;
                return true;
            }
        }

        public bool AgregarUsuario(Empleado empleado, string cuenta, string contraseña)
        {
            Usuario usuario = new Usuario(empleado, cuenta, contraseña);
            Instancia.Usuarios.Add(usuario);

            int tmpId = DB.AgregarUsuario(usuario);
            if (tmpId == -1) // Ocurrio un error
            {
                return false;
            }
            else
            {
                empleado.ID = tmpId;
                return true;
            }
        }

        public bool AgregarDocumento(string numero)
        {
            Documento documento = new Documento(numero);
            Instancia.Documentos.Add(documento);

            int tmpId = DB.AgregarDocumento(documento);
            if (tmpId == -1) // Ocurrio un error
            {
                return false;
            }
            else
            {
                documento.ID = tmpId;
                return true;
            }
        }

        //externo
        public bool AgregarEnvioExterno(Documento documento, Empleado remitente, Empleado destinatario, Empleado mensajero, DateTime? enviado, DateTime? recibido, string asunto, string direccion, string telefono, string empresa)
        {
            EnvioExterno envio = new EnvioExterno(documento, remitente, destinatario, mensajero, enviado, recibido, direccion, telefono, asunto, empresa);
            Instancia.EnviosExternos.Add(envio);
            documento.Envios.Add(envio);

            int tmpId = DB.AgregarEnvioExterno(envio);
            if (tmpId == -1) // Ocurrio un error
            {
                return false;
            }
            else
            {
                documento.ID = tmpId;
                return true;
            }
        }

        //interno
        public bool AgregarEnvioInterno(Documento documento, Empleado remitente, Empleado destinatario, Empleado mensajero, DateTime enviado, string asunto)
        {
            EnvioInterno envio = new EnvioInterno(documento, remitente, destinatario, mensajero, enviado, asunto);
            Instancia.EnviosInternos.Add(envio);
            documento.Envios.Add(envio);

            int tmpId = DB.AgregarEnvioInterno(envio);
            if (tmpId == -1) // Ocurrio un error
            {
                return false;
            }
            else
            {
                documento.ID = tmpId;
                return true;
            }
        }

        #endregion Metodos de agregacion


        #region Metodos internos --------------------------------------------------------------

        public void CargarDatos()
        {
            Instancia.Departamentos = DB.GetDepartamentos();
            Instancia.Empleados = DB.GetEmpleados();
            Instancia.Usuarios = DB.GetUsuarios();
            Instancia.Documentos = DB.GetDocumentos();

            // Revisar si no habia empleado y usuario administrador creado
            if (Instancia.Usuarios.Where(x => x.Empleado.Tipo == Clases.TipoEmpleado.Administrador).FirstOrDefault() == null)
            {
                //Crear un empleado y usuario administrador
                Instancia.AgregarEmpleado("", "", "", TipoEmpleado.Administrador, null);
                Instancia.AgregarUsuario(Instancia.Empleados.Last(),"admin", "admin");
            }

            // El envio Externo se debe cargar despues de crear el documento
            Instancia.EnviosInternos = DB.GetEnviosInternos();
            Instancia.EnviosExternos = DB.GetEnviosExternos();

            foreach (Documento documento in Instancia.Documentos)
            {
                foreach (EnvioInterno envio in Instancia.EnviosInternos) documento.Envios.Add(envio);
                foreach (EnvioExterno envio in Instancia.EnviosExternos) documento.Envios.Add(envio);
            }

            //MessageBox.Show("Departamentos " + Instancia.Departamentos.Count.ToString());
            //MessageBox.Show("Empleados " + Instancia.Empleados.Count.ToString());
            //MessageBox.Show("Usuarios " + Instancia.Usuarios.Count.ToString());
            //MessageBox.Show("Documentos " + Instancia.Documentos.Count.ToString());
            //MessageBox.Show("EnviosInternos " + Instancia.EnviosInternos.Count.ToString());
            //MessageBox.Show("EnviosExternos " + Instancia.EnviosExternos.Count.ToString());
        }

        #endregion Metodos internos


        #region Metodos operativos --------------------------------------------------------------

        public void RegistrarEnvioInterno(string numeroDoc, Empleado remitente, Empleado destinatario, Empleado mensajero, DateTime enviado, string asunto)
        {
            Documento documento = Instancia.Documentos.Where(x => x.Numero == numeroDoc).FirstOrDefault();
            
            //MessageBox.Show(numeroDoc + documento == null ? ", y existe" : ", y NOOO existe");
            //MessageBox.Show(remitente.Nombre + " " + remitente.Apellido);
            //MessageBox.Show(destinatario.Nombre + " " + destinatario.Apellido);
            //MessageBox.Show(mensajero.Nombre + " " + mensajero.Apellido);
            //MessageBox.Show(enviado.ToShortDateString() + " - " + enviado.ToShortTimeString());

            if (documento == null) // No existe este documento; es un documento nuevo
            {
                if (!AgregarDocumento(numeroDoc))
                {
                    MessageBox.Show("Error al guardar documento");
                    return;
                }

                documento = Instancia.Documentos.Last();
            }

            bool hecho = Instancia.AgregarEnvioInterno(documento, remitente, destinatario, mensajero, enviado, asunto);

            if (!hecho) MessageBox.Show("Error al guardar el envio interno");
        }

        public void RegistrarEnvioExterno(string numeroDoc, Empleado remitente, Empleado destinatario, Empleado mensajero, DateTime? enviado, DateTime? recibido, string asunto, string direccion, string telefono, string empresa)
        {
            Documento documento = Instancia.Documentos.Where(x => x.Numero == numeroDoc).FirstOrDefault();

            //MessageBox.Show(numeroDoc + documento == null ? ", y existe" : ", y NOOO existe");
            //MessageBox.Show(remitente.Nombre + " " + remitente.Apellido);
            //MessageBox.Show(destinatario.Nombre + " " + destinatario.Apellido);
            //MessageBox.Show(mensajero.Nombre + " " + mensajero.Apellido);
            //MessageBox.Show(enviado.ToShortDateString() + " - " + enviado.ToShortTimeString());

            if (documento == null) // No existe este documento; es un documento nuevo
            {
                if (!AgregarDocumento(numeroDoc))
                {
                    MessageBox.Show("Error al guardar documento");
                    return;
                }

                documento = Instancia.Documentos.Last();
            }

            bool hecho = Instancia.AgregarEnvioExterno(documento, remitente, destinatario, mensajero, enviado, recibido, asunto, direccion, telefono, empresa);

            if (!hecho) MessageBox.Show("Error al guardar el envio interno");
        }

        public void RegistrarRecepcionInterna(Documento documento, DateTime recibido, Envio envio)
        {
            if (documento == null) // No existe este documento;
                return;

            envio.Completado = true;
            envio.Recibido = recibido; // Establecer la fecha de recpecion del envio
            envio.Destinatario.Buzon.Add(envio.Documento); // Agregar el documento al buzon del destinatario

            DB.RegistrarRecepcionInterna(envio, recibido);
            DB.RegistrarDocumentoEnBuzon(envio.Destinatario, envio.Documento);
        }

        public void RegistrarRecepcionExterna(Documento documento, DateTime recibido, Envio envio)
        {
            if (documento == null) // No existe este documento;
                return;

            envio.Completado = true;
            envio.Recibido = recibido; // Establecer la fecha de recpecion del envio
            envio.Destinatario.Buzon.Add(envio.Documento); // Agregar el documento al buzon del destinatario

            DB.RegistrarRecepcionExterna(envio, recibido);
            DB.RegistrarDocumentoEnBuzon(envio.Destinatario, envio.Documento);
        }

        /*public void RegistrarEnvioExterno(string numeroDoc, Empleado remitente, Empleado destinatario, Empleado mensajero, DateTime recibido, string asunto, string direccion, string telefono, string empresa)
        {
            Documento documento = Instancia.Documentos.Where(x => x.Numero == numeroDoc).FirstOrDefault();

            //MessageBox.Show(numeroDoc + documento == null ? ", y existe" : ", y NOOO existe");
            //MessageBox.Show(remitente.Nombre + " " + remitente.Apellido);
            //MessageBox.Show(destinatario.Nombre + " " + destinatario.Apellido);
            //MessageBox.Show(mensajero.Nombre + " " + mensajero.Apellido);
            //MessageBox.Show(enviado.ToShortDateString() + " - " + enviado.ToShortTimeString());

            if (documento == null) // No existe este documento; es un documento nuevo
            {
                if (!AgregarDocumento(numeroDoc))
                {
                    MessageBox.Show("Error al guardar documento");
                    return;
                }

                documento = Instancia.Documentos.Last();
            }

            bool hecho = Instancia.AgregarEnvioExterno(documento, remitente, destinatario, mensajero, null, asunto, direccion, telefono, empresa);

            if (!hecho) MessageBox.Show("Error al guardar el envio interno");
        }
        */
        #endregion Metodos operativos



        #region Atributos ----------------------------------------------------------------

        /// <summary>
        /// Empleado que tiene la sesion abierta actualmente.
        /// </summary>
        private Usuario _actual;
        public Usuario Actual
        {
            get
            {
                return _actual;
            }
            set
            {
                _actual = value;
            }
        }
        
        public List<Empleado> Empleados = new List<Empleado>();
        public List<Usuario> Usuarios = new List<Usuario>();
        public List<Departamento> Departamentos = new List<Departamento>();
        public List<Documento> Documentos = new List<Documento>();
        public List<EnvioExterno> EnviosExternos = new List<EnvioExterno>();
        public List<EnvioInterno> EnviosInternos = new List<EnvioInterno>();
        
        private static Sistema _instancia = new Sistema();
        public static Sistema Instancia
        {
            get { return _instancia; }
        }

        #endregion Atributos


        //Constructor protector para que no se creen instancias de esta base de datos
        private Sistema() { }

        public Usuario Loguear(string cuenta, string contraseña)
        {
            return Instancia.Usuarios.Where(x => x.Cuenta == cuenta && x.Contraseña == contraseña).FirstOrDefault();
        }
    }
}

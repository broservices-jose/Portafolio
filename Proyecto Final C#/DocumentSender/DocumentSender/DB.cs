using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DocumentSender
{
    public static class DB
    {
        private static SqlConnection _conexion = new SqlConnection("Data Source=PC-15\\SQLEXPRESS;Initial Catalog=DocumentosDB;Integrated Security=True");
        public static SqlConnection Conexion
        {
            get
            {
                //MessageBox.Show("usado");
                return _conexion;
            }
        }

        public static bool TestConexion()
        {
            try
            {
                Conexion.Open();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static int AgregarEmpleado(Clases.Empleado empleado)
        {
            //try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DB.Conexion;
                cmd.CommandText = "insert into Empleado(nombre, apellido, cedula, " + (empleado.Departamento == null ? "" : "departamento,") + " tipo)"
                    + " values (@nombre, @apellido, @cedula, " + (empleado.Departamento == null ? "" : "@departamento,") + " @tipo)";
                cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("@cedula", empleado.Cedula);
                if (empleado.Departamento != null) cmd.Parameters.AddWithValue("@departamento", empleado.Departamento.ID);
                cmd.Parameters.AddWithValue("@tipo", empleado.Tipo);

                DB.Conexion.Open();
                cmd.ExecuteNonQuery();
                DB.Conexion.Close();

                SqlDataAdapter da = new SqlDataAdapter("select top 1 id from Empleado order by id desc", DB.Conexion);
                DataTable dtab = new DataTable();
                da.Fill(dtab);
                return Convert.ToInt32(dtab.Rows[0][0]);
            }
            //catch { return -1; }
        }

        public static int AgregarDepartamento(Clases.Departamento departamento)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DB.Conexion;
                cmd.CommandText = "insert into Departamento(nombre) values (@nombre)";
                cmd.Parameters.AddWithValue("@nombre", departamento.Nombre);

                DB.Conexion.Open();
                cmd.ExecuteNonQuery();
                DB.Conexion.Close();

                SqlDataAdapter da = new SqlDataAdapter("select top 1 id from Departamento order by id desc", DB.Conexion);
                DataTable dtab = new DataTable();
                da.Fill(dtab);
                return Convert.ToInt32(dtab.Rows[0][0]);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return -1; }
        }

        public static int AgregarUsuario(Clases.Usuario usuario)
        {
            //try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DB.Conexion;
                cmd.CommandText = "insert into Usuario(empleado, cuenta, contraseña) values (@empleado, @cuenta, @contraseña)";
                cmd.Parameters.AddWithValue("@empleado", usuario.Empleado.ID);
                cmd.Parameters.AddWithValue("@cuenta", usuario.Cuenta);
                cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);

                DB.Conexion.Open();
                cmd.ExecuteNonQuery();
                DB.Conexion.Close();

                SqlDataAdapter da = new SqlDataAdapter("select top 1 e.id from Usuario u inner join Empleado e on e.id = u.empleado order by e.id desc", DB.Conexion);
                DataTable dtab = new DataTable();
                da.Fill(dtab);
                return Convert.ToInt32(dtab.Rows[0][0]);
            }
            //catch (Exception ex) { MessageBox.Show(ex.ToString()); return -1; }
        }

        public static int AgregarDocumento(Clases.Documento documento)
        {
            //try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DB.Conexion;
                cmd.CommandText = "insert into Documento(numero) values (@numero)";
                cmd.Parameters.AddWithValue("@numero", documento.Numero);

                DB.Conexion.Open();
                cmd.ExecuteNonQuery();
                DB.Conexion.Close();

                SqlDataAdapter da = new SqlDataAdapter("select top 1 id from Documento order by id desc", DB.Conexion);
                DataTable dtab = new DataTable();
                da.Fill(dtab);
                return Convert.ToInt32(dtab.Rows[0][0]);
            }
            //catch (Exception ex) { MessageBox.Show(ex.ToString()); return -1; }
        }

        public static int AgregarEnvioInterno(Clases.EnvioInterno envio)
        {
            //try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DB.Conexion;
                cmd.CommandText = "insert into EnvioInterno(documento, remitente, destinatario, mensajero, enviado, asunto) "
                + " values (@documento, @remitente, @destinatario, @mensajero, @enviado, @asunto)";
                cmd.Parameters.AddWithValue("@documento", envio.Documento.ID);
                cmd.Parameters.AddWithValue("@remitente", envio.Remitente.ID);
                cmd.Parameters.AddWithValue("@destinatario", envio.Destinatario.ID);
                cmd.Parameters.AddWithValue("@mensajero", envio.Mensajero.ID);
                cmd.Parameters.AddWithValue("@enviado", envio.Enviado);
                cmd.Parameters.AddWithValue("@asunto", envio.Asunto);

                DB.Conexion.Open();
                cmd.ExecuteNonQuery();
                DB.Conexion.Close();

                SqlDataAdapter da = new SqlDataAdapter("select top 1 id from EnvioInterno order by id desc", DB.Conexion);
                DataTable dtab = new DataTable();
                da.Fill(dtab);
                return Convert.ToInt32(dtab.Rows[0][0]);
            }
            //catch (Exception ex) { MessageBox.Show(ex.ToString()); return -1; }
        }

        public static int AgregarEnvioExterno(Clases.EnvioExterno envio)
        {
            string empleado;

            //try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DB.Conexion;
                cmd.CommandText = "insert into EnvioExterno(documento, remitente, destinatario, mensajero, enviado, recibido, asunto, direccion, telefono) "
                    + " values (@documento, @remitente, @destinatario, @mensajero, " + (envio.Enviado != null ? "@enviado," : "") + (envio.Recibido != null ? "@recibido," : "") + "@recibido, @asunto, @direccion, @telefono)";
                cmd.Parameters.AddWithValue("@documento", envio.Documento.ID);
                cmd.Parameters.AddWithValue("@remitente", envio.Remitente.ID);
                cmd.Parameters.AddWithValue("@destinatario", envio.Destinatario.ID);
                cmd.Parameters.AddWithValue("@mensajero", envio.Mensajero.ID);
                if (envio.Enviado != null) cmd.Parameters.AddWithValue("@enviado", envio.Enviado);
                if (envio.Recibido != null) cmd.Parameters.AddWithValue("@recibido", envio.Recibido);
                cmd.Parameters.AddWithValue("@asunto", envio.Asunto);
                cmd.Parameters.AddWithValue("@direccion", envio.Direccion);
                cmd.Parameters.AddWithValue("@telefono", envio.Telefono);

                DB.Conexion.Open();
                cmd.ExecuteNonQuery();
                DB.Conexion.Close();

                SqlDataAdapter da = new SqlDataAdapter("select top 1 id from EnvioExterno order by id desc", DB.Conexion);
                DataTable dtab = new DataTable();
                da.Fill(dtab);
                return Convert.ToInt32(dtab.Rows[0][0]);
            }
            //catch (Exception ex) { MessageBox.Show(ex.ToString()); return -1; }
        }



        public static bool ActualizarEmpleado(Clases.Empleado empleado)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DB.Conexion;
                cmd.CommandText = "update Empleado set nombre = @nombre, apellido = @apellido, cedula = @cedula,"
                + " departamento = @departamento, tipo = @tipo where id = @id";

                cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("@cedula", empleado.Cedula);
                cmd.Parameters.AddWithValue("@departamento", empleado.Departamento.ID);
                cmd.Parameters.AddWithValue("@tipo", empleado.Tipo);
                cmd.Parameters.AddWithValue("@id", empleado.ID);

                DB.Conexion.Open();
                cmd.ExecuteNonQuery();
                DB.Conexion.Close();

                return true;
            }
            catch { return false; }
        }

        public static bool ActualizarDepartamento(Clases.Departamento departamento)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DB.Conexion;
                cmd.CommandText = "update Departamento set nombre = @nombre where id = @id";
                cmd.Parameters.AddWithValue("@nombre", departamento.Nombre);
                cmd.Parameters.AddWithValue("@id", departamento.ID);

                DB.Conexion.Open();
                cmd.ExecuteNonQuery();
                DB.Conexion.Close();

                return true;
            }
            catch { return false; }
        }


        #region Geters

        public static List<Clases.Departamento> GetDepartamentos()
        {
            List<Clases.Departamento> departamentos = new List<Clases.Departamento>();

            SqlDataAdapter da = new SqlDataAdapter("select * from Departamento", DB.Conexion);
            DataTable dtab = new DataTable();
            da.Fill(dtab);

            foreach (DataRow row in dtab.Rows)
            {
                departamentos.Add(new Clases.Departamento(row[1].ToString()) { ID = (int)row["id"] });
            }

            return departamentos;
        }

        public static List<Clases.Empleado> GetEmpleados()
        {
            List<Clases.Empleado> empleados = new List<Clases.Empleado>();

            SqlDataAdapter da = new SqlDataAdapter("select * from Empleado", DB.Conexion);
            DataTable dtab = new DataTable();
            da.Fill(dtab);

            Clases.Departamento departamento = null; // variable departamento temp
            int id;

            foreach (DataRow row in dtab.Rows)
            {
                if (int.TryParse(row["departamento"].ToString(), out id)) { departamento = Sistema.Instancia.Departamentos.Where(x => x.ID == id).FirstOrDefault(); }

                empleados.Add(new Clases.Empleado(row["nombre"].ToString(), row["apellido"].ToString(), row["cedula"].ToString(), (Clases.TipoEmpleado)row["tipo"], departamento) { ID = (int)row["id"] });
            }

            return empleados;
        }

        public static List<Clases.Usuario> GetUsuarios()
        {
            List<Clases.Usuario> usuarios = new List<Clases.Usuario>();

            SqlDataAdapter da = new SqlDataAdapter("select * from Usuario", DB.Conexion);
            DataTable dtab = new DataTable();
            da.Fill(dtab);

            foreach (DataRow row in dtab.Rows)
            {
                usuarios.Add(new Clases.Usuario(Sistema.Instancia.Empleados.Where(x => x.ID == (int)row["empleado"]).First(), row["cuenta"].ToString(), row["contraseña"].ToString()));
            }

            return usuarios;
        }

        public static List<Clases.Documento> GetDocumentos()
        {
            List<Clases.Documento> documentos = new List<Clases.Documento>();

            SqlDataAdapter da = new SqlDataAdapter("select * from Documento", DB.Conexion);
            DataTable dtab = new DataTable();
            da.Fill(dtab);

            foreach (DataRow row in dtab.Rows)
            {
                documentos.Add(new Clases.Documento(row["numero"].ToString()) { ID = (int)row["id"] });
            }

            return documentos;
        }

        public static List<Clases.EnvioInterno> GetEnviosInternos()
        {
            List<Clases.EnvioInterno> envio = new List<Clases.EnvioInterno>();

            SqlDataAdapter da = new SqlDataAdapter("select * from EnvioInterno", DB.Conexion);
            DataTable dtab = new DataTable();
            da.Fill(dtab);

            DateTime recibido;

            foreach (DataRow row in dtab.Rows)
            {
                if (!DateTime.TryParse(row["enviado"].ToString(), out recibido)) { /*MessageBox.Show("Error en fecha");*/ }
                envio.Add(new Clases.EnvioInterno(
                    Sistema.Instancia.Documentos.Where(x => x.ID == (int)row["documento"]).FirstOrDefault(),
                    Sistema.Instancia.Empleados.Where(x => x.ID == (int)row["remitente"]).FirstOrDefault(),
                    Sistema.Instancia.Empleados.Where(x => x.ID == (int)row["destinatario"]).FirstOrDefault(),
                    Sistema.Instancia.Empleados.Where(x => x.ID == (int)row["mensajero"]).FirstOrDefault(),
                    DateTime.Parse(row["enviado"].ToString()),
                    row["asunto"].ToString())
                { ID = (int)row["id"], Recibido = recibido });
            }

            return envio;
        }

        public static List<Clases.EnvioExterno> GetEnviosExternos()
        {
            List<Clases.EnvioExterno> envio = new List<Clases.EnvioExterno>();

            SqlDataAdapter da = new SqlDataAdapter("select * from EnvioExterno", DB.Conexion);
            DataTable dtab = new DataTable();
            da.Fill(dtab);

            DateTime enviado;
            DateTime recibido;
            Clases.Empleado empleado;

            foreach (DataRow row in dtab.Rows)
            {
                bool esEnvioEntrante = false;
                if (row["destinatario"].ToString().Length > 0) esEnvioEntrante = true;

                if (!DateTime.TryParse(row["enviado"].ToString(), out enviado)) { /*MessageBox.Show("Error en fecha");*/  }
                if (!DateTime.TryParse(row["recibido"].ToString(), out recibido)) { /*MessageBox.Show("Error en fecha");*/ }

                envio.Add(new Clases.EnvioExterno(
                    Sistema.Instancia.Documentos.Where(x => x.ID == (int)row["documento"]).FirstOrDefault(),
                    esEnvioEntrante ? null : Sistema.Instancia.Empleados.Where(x => x.ID == (int)row["remitente"]).FirstOrDefault(),
                    esEnvioEntrante ? Sistema.Instancia.Empleados.Where(x => x.ID == (int)row["remitente"]).FirstOrDefault() : null,
                    Sistema.Instancia.Empleados.Where(x => x.ID == (int)row["mensajero"]).FirstOrDefault(),
                    enviado,
                    recibido,
                    row["direccion"].ToString(),
                    row["telefono"].ToString(),
                    row["asunto"].ToString(),
                    row["empresa"].ToString()) { ID = (int)row["id"] });
            }

            return envio;
        }

        #endregion Geters

        
        public static void RegistrarRecepcionInterna(Clases.Envio envio, DateTime recibido)
        {
            //try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DB.Conexion;
                cmd.CommandText = "update EnvioInterno set recibido = @recibido, completado = 1 where id = @id";

                cmd.Parameters.AddWithValue("@id", envio.ID);
                cmd.Parameters.AddWithValue("@recibido", recibido);

                DB.Conexion.Open();
                cmd.ExecuteNonQuery();
                DB.Conexion.Close();
            }
            //catch { return false; }
        }

        public static void RegistrarRecepcionExterna(Clases.Envio envio, DateTime recibido)
        {//try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DB.Conexion;
                cmd.CommandText = "update EnvioExterno set recibido = @recibido, completado = 1 where id = @id";

                cmd.Parameters.AddWithValue("@id", envio.ID);
                cmd.Parameters.AddWithValue("@recibido", recibido);

                DB.Conexion.Open();
                cmd.ExecuteNonQuery();
                DB.Conexion.Close();
            }
            //catch { return false; }
        }

        public static void RegistrarDocumentoEnBuzon(Clases.Empleado empleado, Clases.Documento documento)
        {
            //try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DB.Conexion;
                cmd.CommandText = "insert into Buzon(empleado, documento) values (@empleado, @documento)";
                cmd.Parameters.AddWithValue("@empleado", empleado.ID);
                cmd.Parameters.AddWithValue("@documento", documento.ID);

                DB.Conexion.Open();
                cmd.ExecuteNonQuery();
                DB.Conexion.Close();
            }
            //catch { return -1; }
        }
    }
}

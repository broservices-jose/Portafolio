using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace AppDiagramaClase
{
    class Mecanico : Persona
    {
        private int id_mecanico;

        public int Id_mecanico
        {
            get { return id_mecanico; }
            set { id_mecanico = value; }
        }
        private DateTime fecha_contratacion;

        public DateTime Fecha_contratacion
        {
            get { return fecha_contratacion; }
            set { fecha_contratacion = value; }
        }
        private string taller;

        public string Taller
        {
            get { return taller; }
            set { taller = value; }
        }
        private double sueldo_base = 0;

        public double Sueldo_base
        {
            get { return sueldo_base; }
            set { sueldo_base = value; }
        }
        private double precio_hora = 0;

        public double Precio_hora
        {
            get { return precio_hora; }
            set { precio_hora = value; }
        }

        private int id_imagen;

        public int Id_imagen
        {
            get { return id_imagen; }
            set { id_imagen = value; }
        }

        private MySqlConnection cn;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;

        public bool ingresar(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO mecanico (id_persona, fecha_contraracion, taller, sueldo_base, precio_hora, id_imagen) VALUES ('(select max(id_persona)+1 from Personas) " + "','" + dato[0] + "','" + dato[1] + "','" + dato[2] + "','" + dato[3] + "','" + "(select max(id_imagen)+1 from imagen) ')";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cn.Close();
                    return true;
                }
                
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        public DataTable consultar()
        {
            try
            {
                nombredecolumnas();
                string miquery = "SELECT am.id_mecanico, ab.nombre, ab.apellido, ab.sexo, ab.nacimiento, ab.telefono, ab.correo, ab.direccion, ab.nacionalidad, ab.trato, ab.tipo_documento, ab.num_documento, am.fecha_contraracion, am.taller, am.sueldo_base, am.precio_hora, i.imagen FROM Personas ab, mecanico am, imagen i WHERE am.id_persona = ab.id_persona and am.id_imagen = i.id_imagen";

                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer ["id_mecanico"], leer ["nombre"], leer ["apellido"], leer ["sexo"], leer ["nacimiento"], leer ["telefono"], leer ["correo"], leer["direccion"], leer ["nacionalidad"], leer ["trato"], leer ["tipo_documento"], leer ["num_documento"], leer["fecha_contraracion"], leer["taller"], leer["sueldo_base"], leer["precio_hora"], leer ["imagen"] });
                }
                leer.Close();
                cn.Close();
                return tabla;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return tabla;

        }
        private void nombredecolumnas()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Id_mecanico");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Sexo");
            tabla.Columns.Add("Nacimiento");
            tabla.Columns.Add("Telefono");
            tabla.Columns.Add("Correo");
            tabla.Columns.Add("Direccion");
            tabla.Columns.Add("Nacionalidad");
            tabla.Columns.Add("Trato");
            tabla.Columns.Add("Tipo_documento");
            tabla.Columns.Add("Num_documento");
            tabla.Columns.Add("fecha_contratacion");
            tabla.Columns.Add("taller");
            tabla.Columns.Add("sueldo_base");
            tabla.Columns.Add("precio_hora");
            tabla.Columns.Add("Imagen");

        }


     /*   public DataSet numeroregistro()
        {
            DataSet registros = new DataSet();

            try
            {
                string miquery = "SELECT imagen.a FROM imagen a, mecanico b, WHERE a.id_imagen = b.id_imagen";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                MySqlDataAdapter objeto = new MySqlDataAdapter(miquery, cn);
                objeto.Fill(registros);
                return registros;
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return registros;
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message);
                return registros;
            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
                return registros;
            }
            finally
            {
                cn.Close();
            }

        }*/

        public DataTable filtrar(string filtro)
        {
            try
            {
                nombredecolumnas();
                string miquery = "SELECT  am.id_mecanico, ab.nombre, ab.apellido, ab.sexo, ab.nacimiento, ab.telefono, ab.correo, ab.direccion, ab.nacionalidad, ab.trato, ab.tipo_documento, ab.num_documento, am.fecha_contraracion, am.taller, am.sueldo_base, am.precio_hora, i.imagen from Personas ab, mecanico am, imagen i WHERE ab.nombre LIKE '" + filtro + "%'";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_mecanico"], leer["nombre"], leer["apellido"], leer["sexo"], leer["nacimiento"], leer["telefono"], leer["correo"], leer["direccion"], leer["nacionalidad"], leer["trato"], leer["tipo_documento"], leer["num_documento"], leer["fecha_contraracion"], leer["taller"], leer["sueldo_base"], leer["precio_hora"], leer ["imagen"] });
                }

                leer.Close();
                cn.Close();
                return tabla;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return tabla;
        }
        public DataTable filtrar1(string filtro)
        {
            try
            {
                nombredecolumnas();
                string miquery = "SELECT  am.id_mecanico, ab.nombre, ab.apellido, ab.sexo, ab.nacimiento, ab.telefono, ab.correo, ab.direccion, ab.nacionalidad, ab.trato, ab.tipo_documento, ab.num_documento, am.fecha_contraracion, am.taller, am.sueldo_base, am.precio_hora, i.imagen from Personas ab, mecanico am, imagen i WHERE am.id_mecanico LIKE '" + filtro + "%'";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_mecanico"], leer["nombre"], leer["apellido"], leer["sexo"], leer["nacimiento"], leer["telefono"], leer["correo"], leer["direccion"], leer["nacionalidad"], leer["trato"], leer["tipo_documento"], leer["num_documento"], leer["fecha_contraracion"], leer["taller"], leer["sueldo_base"], leer["precio_hora"], leer ["imagen"] });
                }

                leer.Close();
                cn.Close();
                return tabla;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return tabla;
        }
        public DataTable filtrar2(string filtro)
        {
            try
            {
                nombredecolumnas();
                string miquery = "SELECT  am.id_mecanico, ab.nombre, ab.apellido, ab.sexo, ab.nacimiento, ab.telefono, ab.correo, ab.direccion, ab.nacionalidad, ab.trato, ab.tipo_documento, ab.num_documento, am.fecha_contraracion, am.taller, am.sueldo_base, am.precio_hora, i.imagen from Personas ab, mecanico am, imagen i WHERE ab.apellido LIKE '" + filtro + "%'";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_mecanico"], leer["nombre"], leer["apellido"], leer["sexo"], leer["nacimiento"], leer["telefono"], leer["correo"], leer["direccion"], leer["nacionalidad"], leer["trato"], leer["tipo_documento"], leer["num_documento"], leer["fecha_contraracion"], leer["taller"], leer["sueldo_base"], leer["precio_hora"], leer ["imagen"] });
                }

                leer.Close();
                cn.Close();
                return tabla;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return tabla;
        }

          public bool eliminar(int id)
        {
            try
            {
                string elimina = " DELETE mecanico FROM mecanico INNER JOIN Personas ON Personas.id_persona = mecanico.id_persona INNER JOIN imagen ON imagen.id_imagen = mecanico.id_imagen WHERE id_mecanico ='" + id + "'";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(elimina, cn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cn.Close();
                    return true;
                }
            }

            catch (MySqlException mx)
            {
                MessageBox.Show(mx.Message);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return false;
        }

          public bool modificar(object[] dato)
          {
              try
              {
                  string miactualiza = "UPDATE mecanico m INNER JOIN Personas p ON p.id_persona = m.id_persona INNER JOIN imagen i ON i.id_imagen = m.id_imagen SET p.nombre = '" + dato[1] + "', p.apellido = '" + dato[2] + "', p.sexo = '" + dato[3] + "', p.nacimiento = '" + dato[4] + "', p.telefono = '" + dato[5] + "', p.correo = '" + dato[6] + "', p.direccion = '" + dato[7] + "', p.nacionalidad = '" + dato[8] + "', p.trato = '" + dato[9] + "', p.tipo_documento = '" + dato[10] + "', p.num_documento = '" + dato[11] + "', m.fecha_contraracion = '" + dato[12] + "', m.taller = '" + dato[13] + "', m.sueldo_base = '" + dato[14] + "', m.precio_hora = '" + dato[15] + "', i.imagen = '" + dato[16] + "' WHERE id_mecanico ='" + dato[0] + "'";
                  System.Windows.Forms.MessageBox.Show(miactualiza);
                  cn = conexion.conectar();
                  cn.Open();
                  cmd = new MySqlCommand(miactualiza, cn);
                  if (cmd.ExecuteNonQuery() > 0)
                  {
                      cn.Close();
                      return true;
                  }
              }

              catch (MySqlException mx)
              {
                  MessageBox.Show(mx.Message);
              }

              catch (NullReferenceException n)
              {
                  MessageBox.Show(n.Message);
              }

              catch (Exception e)
              {
                  MessageBox.Show(e.Message);
              }
              return false;
          }
    }
}

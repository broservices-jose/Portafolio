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
    class Usuario
    {
        private int id_usuario;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        private string nombre_usuario;

        public string Nombre_usuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }
        private string permiso;

        public string Permiso
        {
            get { return permiso; }
            set { permiso = value; }
        }
        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        private string departamento;

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        private string fecha_ingreso;

        public string Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }


        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;

        public bool ingresar(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO usuario( id_usuario, nombre_usuario, permiso, clave, departamento, fecha_ingreso)VALUES ('" + dato[0] + "','" + dato[1] + "','" + dato[2] + "','" + dato[3] + "','" + dato[4] + "','" + dato[5] + "')'";
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
                string miomio = "SELECT * FROM usuario";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miomio, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_usuario"], leer["id_persona"], leer["nombre_usuario"], leer["permiso"], leer["clave"], leer["departamento"], leer["fecha_ingreso"], leer["id_imgane"] });
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
    }
}

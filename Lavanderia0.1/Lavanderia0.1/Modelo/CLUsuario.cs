using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Lavanderia0._1.Modelo
{
    public class CLUsuario : CLEmpleado
    {

        // =========================================================================\\
        // Esta linea de codigo en adelante representa la declaracion y encapsulamiento
        // de las variables que nos van a permitir interactuar con la base de datos
        // =========================================================================\\

        private int id_usuario;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        private string cuenta;

        public string Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        private string empleado;

        public string Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }


        // =========================================\\
        // Esta linea de codigo representa la creacion
        // o instanciacion de los objetos que nos van
        // a permitir interactuar con la base de datos
        // =========================================\\

        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;

        // ================================================================================//
        // Esta linea de codigo representa el metodo consulta() el cual nos va a permitir
        // traer todas las informaciones almacenadas en la base de datos DBLavanderia 
        // =================================================================================//

        public DataTable consultar()
        {
            try
            {
                nombrecolumna();
                string query = "select u.id_usuario, u.cuenta, u.clave, e.nombre, e.apellido from "+
                               "usuario u inner join empleado e on u.id_empleado = e.id_empleado inner"+
                               " join imagen i on i.id_imagen = e.id_imagen";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(leer["id_usuario"],leer["cuenta"],leer["clave"],leer["nombre"],leer["apellido"]);
                }
                return tabla;
            }
            catch(MySqlException mx)
            {
              MessageBox.Show(mx.Message+mx.StackTrace);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message+n.StackTrace);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+ex.StackTrace);
            }
            return tabla;
        }

        // ========================================================================================================\\
        // Esta linea de codigo representa el metodo nombrecolumna() el cual nos va a permitir ponerle el nombre a la
        // columna del datagridview
        // =========================================================================================================\\

        private void nombrecolumna()
        {
            tabla = new DataTable();
            tabla.Columns.Add("ID");
            tabla.Columns.Add("Cuenta");
            tabla.Columns.Add("Clave");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");

        }

        // ********************************************************************************************************** ||
        // Esta linea de codigo representa el metodo validar() el cual nos va permitir verificar si el usuario y su
        // contrasenia existe en la tabla usuario de la base de datos dblavanderia
        // ********************************************************************************************************** ||

        public int validar( string usuario, string clave)
        {
            int c= 0;
            try
            {
                string query = "select cuenta, clave from usuario where cuenta ='" + usuario + "' and clave ='" + clave + "'";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    c += 1;
                }
                return c;
            }
            catch (MySqlException mx)
            {
                MessageBox.Show(mx.Message + mx.StackTrace);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message + n.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            return c;
        }

    }
}

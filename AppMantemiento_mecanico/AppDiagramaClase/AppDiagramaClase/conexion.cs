using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AppDiagramaClase
{
    class conexion
    {
        public static MySqlConnection conectar()
        {
            string server = "127.0.0.1";
            string database = "Mantenimiento";
            string user = "root";
            string pass = "";

            MySqlConnection cn = new MySqlConnection("Server="+server+";Database="+database+";User="+user+";Pwd="+pass);
            return cn;
        }

    }
}

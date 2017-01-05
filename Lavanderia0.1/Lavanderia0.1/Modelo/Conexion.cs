using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Lavanderia0._1.Modelo
{
    class Conexion
    {
        // ===============================================================================\\
        // Esta linea de codigo representa el metodo conectar() el cual nos va  a permitir 
        // Abrir una conexion al servidor de mysql localhost y a la base de datos BDLavanderia
        // ===============================================================================\\

        public static MySqlConnection conectar()
        {
            string servidor = "127.0.0.1";
            string bd = "dblavanderia";
            string usuario = "root";
            string clave = "";

            MySqlConnection cn = new MySqlConnection("Server=" + servidor + ";Database=" + bd + ";User=" + usuario + ";Pwd=" + clave);
            return cn;
        }
    }
}

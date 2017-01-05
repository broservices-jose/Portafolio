using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Lavanderia0._1.Modelo
{
    public class CLImagen
    {
        // =========================================================================\\
        // Esta linea de codigo en adelante representa la declaracion y encapsulamiento
        // de las variables que nos van a permitir interactuar con la base de datos
        // =========================================================================\\


        private string ruta;

        public string Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }

        private int id_imagen;

        public int Id_imagen
        {
            get { return id_imagen; }
            set { id_imagen = value; }
        }


        // ***************************************** \\
        // Esta linea de codigo representa la creacion
        // o instanciacion de los objetos que nos van
        // a permitir interactuar con la base de datos
        // ****************************************** \\

        private MySqlConnection cn;
        private MySqlCommand cmd;
        private MySqlDataReader leer;


        // *********************************************************************************** ||
        // Esta linea de codigo representa el metodo insertarimg() el cual nos va a permitir 
        // insertar la ruta de la imagen sin importar el tipo de caracter que tenga
        // *********************************************************************************** ||

        public bool insertarimg( string ruta )
        {
            try
            {
                string query = "insert into imagen (ruta) values (@param1)";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@param1", ruta);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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
            return false;
        }

        public bool modificar(string ruta, string tabla, int id)
        {
            try
            {
                string query = "update imagen i inner join "+tabla +"  e on i.id_imagen = e.id_imagen set i.ruta = @param1 where i.id_imagen = " + id;
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@param1", ruta);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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
            return false;
        }

    }
}

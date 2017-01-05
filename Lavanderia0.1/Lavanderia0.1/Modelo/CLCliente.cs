using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Lavanderia0._1.Modelo
{
    public class CLCliente : CLPersona
  {
        
        
        //======================================================================//
        // Estos son las instancias de las clases o objecto     que me permitirar i
        // cola la base de datos                                                   //
        //==========================================================================//

        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;
        
        
        // =========================================================================\\
        // Esta linea de codigo en adelante representa la declaracion y encapsulamiento
        // de las variables que nos van a permitir interactuar con la base de datos
        // =========================================================================\\


        private int id_cliente;

        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }

        private string comentario;

        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        private string tipo_clietne;

        public string Tipo_clietne
        {
            get { return tipo_clietne; }
            set { tipo_clietne = value; }
        }



        //======================================================//
        //    Metodo para nombrar las columnas de datagriwview  //
        private void NombreColumnas() {
            tabla = new DataTable();
            tabla.Columns.Add("ID");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Sexo");
            tabla.Columns.Add("Cedula");
            tabla.Columns.Add("Telefono");
            tabla.Columns.Add("Correo");
            tabla.Columns.Add("Direccion");
            tabla.Columns.Add("Comentario");
            tabla.Columns.Add("Imagen");
        
        
        
        }


        ///=======================================================================//
        ///
        public DataTable Consultar()
        {

            try
            {
                NombreColumnas();
                string query = "select c.id_cliente , c.nombre, c.apellido, c.sexo, "+
                               "c.cedula, c.telefono, c.correo, c.direccion, c.comentario,"+
                               " i.ruta, i.id_imagen from cliente c , imagen i "+
                               " where c.id_imagen = i.id_imagen";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read()) 
                {
                    tabla.Rows.Add( leer["id_cliente"],leer["nombre"], leer["apellido"], leer["sexo"],
                                    leer["cedula"], leer["telefono"],leer["correo"], leer["direccion"], 
                                    leer["comentario"], leer["ruta"]);

                }
                return tabla;
            }

            catch (MySqlException e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message + "hola"+ e.StackTrace);
            }
            catch (NullReferenceException n)
            {
               System.Windows.Forms.MessageBox.Show(n.Message + " en n : " + n.StackTrace);
            }
            catch (Exception ex)
            {
              System.Windows.Forms.MessageBox.Show(ex.Message + "en ex : " + ex.StackTrace);
            }
            return tabla;


        }


        // **************************************************************************************************  ||
        // Esta linea de codigo representa el metodo necesito() el cual nos va a permitir obtener el id_imagen
        // de la tabla empleado el cual lo vamos a utilizar para poder modificar la ruta de la tabla imagen
        // ************************************************************************************************** ||

        public int necesito(int id)
        {
            try
            {
                string query = "select id_imagen from cliente where id_cliente =" + id;
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    return Convert.ToInt32(leer["id_imagen"]);
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
            return 0;
        }
       

        // ****************************************************************************************************************************** ||
        // Esta linea de codigo representa el metodo generarproc()el cual recibe por parametro los datos que se van a insertar en la tabla
        // cliente . Este metodo se va utilizar para llamar el procedimiento insert_cliente el cual nos va permitir insertar en la tabla 
        // cliente y imagen al ejecutarse este
        // ****************************************************************************************************************************** ||

        public bool generarproc(string nombre, string apellido, string telefono)
        {
            try
            {
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand("insert_cliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter p = new MySqlParameter("@nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar);
                MySqlParameter p1 = new MySqlParameter("@apellido", MySql.Data.MySqlClient.MySqlDbType.VarChar);
                MySqlParameter p2 = new MySqlParameter("@telefono", MySql.Data.MySqlClient.MySqlDbType.VarChar);
                p.Value = nombre;
                p1.Value = apellido;
                p2.Value = telefono;
                  
                p.Direction = ParameterDirection.Input;
                p1.Direction = ParameterDirection.Input;
                p2.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("nos registro");
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

        // ******************************************************************************************************************* ||
        // Esta linea de codigo represena el metodo ultimoid() de tipo int el cual nos va a retorna el ultimo id_cliente el cual
        // vamos a utilizar para llamarlo en el prcediemiento almacenado insert_cliente
        // ******************************************************************************************************************* ||

        public int ultimoid()
        {
            try
            {
                string query = "select max(id_cliente) as maxim from cliente";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    return Convert.ToInt32(leer["maxim"]);
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
            return 0;
        }
    }
}

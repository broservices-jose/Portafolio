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
    public class CLArticulo
    {
        // =========================================================================\\
        // Esta linea de codigo en adelante representa la declaracion y encapsulamiento
        // de las variables que nos van a permitir interactuar con la base de datos
        // =========================================================================\\

        private int id_articulo;

        public int Id_articulo
        {
            get { return id_articulo; }
            set { id_articulo = value; }
        }
        
        private string articulo;

        public string Articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }

        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string otro;

        public string Otro
        {
            get { return otro; }
            set { otro = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
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
                string query = "select id_articulo, articulo, categoria, descripcion from articulo";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(leer["id_articulo"], leer["articulo"], leer["categoria"], 
                     leer["descripcion"]);
                }
                return tabla;

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
            tabla.Columns.Add("Articulo");
            tabla.Columns.Add("Categoria");
            tabla.Columns.Add("Descripcion");
        }
    }


}

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
    class CLServicio
    {
        // =========================================================================\\
        // Esta linea de codigo en adelante representa la declaracion y encapsulamiento
        // de las variables que nos van a permitir interactuar con la base de datos
        // =========================================================================\\


        private int id_servcio;

        public int Id_servicio
        {
            get { return id_servcio; }
            set { id_servcio = value; }
        }

        private string tipo;

        public string Tipo
        {
          get { return tipo; }
          set { tipo = value; }
        }

        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        // *********************************************** ||
        // Esta linea de codigo representa la declaracion
        // de la variables que se van utilizar para llenar
        // el combobox cbservicio en Factura 
        // *********************************************** ||

        private double preciod;

        public double getprecio()
        {
             return preciod;
        }

        public void setprecio(double precio)
        {
            this.preciod = precio;
        }

        private string id;

        public string getid()
        {
            return id;
        }

        public void setid(string id)
        {
            this.id = id;
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
        private MySqlDataAdapter data = null;

        // ================================================================================//
        // Esta linea de codigo representa el metodo consulta() el cual nos va a permitir
        // traer todas las informaciones almacenadas en la base de datos DBLavanderia 
        // =================================================================================//

        public DataTable consulta()
        {
            try
            {
                nombrecolumna();
                string query = "select id_servicio, servicio, precio, descripcion from servicio";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                while(leer.Read())
                {
                    tabla.Rows.Add(leer["id_servicio"], leer["servicio"], leer["precio"],
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
            tabla.Columns.Add("Servicio");
            tabla.Columns.Add("Precio");
            tabla.Columns.Add("Descripcion");
        }

        // ************************************************************************************************************* ||
        // Esta linea de codigo representa el metodo llenarcombo() el cual nos va a permitir llenar el combobox cbservicio
        // del formulario Factura con los servicios y ids registrados en la tabla servicio de la base de datos dblavanderia
        // ************************************************************************************************************* ||

        public void llenarcombo(ComboBox cb)
        {
            try
            {
                string query = "select id_servicio, servicio, precio from servicio";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                data = new MySqlDataAdapter(cmd);
                tabla = new DataTable();
                data.Fill(tabla);
                cb.ValueMember = "id_servicio";
                cb.DisplayMember = "servicio";
                cb.DataSource = tabla;

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
        }

        // ************************************************************************** ||
        // Esta linea de codigo representa el metodo obtenerp() el cual nos va a 
        // retornar el precio del servicio de acuerdo al servicio seleccionado del 
        // combobox cbservicio del formulario factura
        // ************************************************************************** ||

        public string obtenerp(int id)
        {
            try
            {
                string query = "select precio from servicio where id_servicio =" + id;
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    return leer["precio"].ToString();
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
            return "";
        }
    }
}

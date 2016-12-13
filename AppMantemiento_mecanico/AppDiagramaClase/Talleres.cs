using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using EJEMPLOLIBRERIA;

namespace AppDiagramaClase
{
    class Talleres
    {
        private int id_taller;

      //  Ejemplo1.valor;
        public int Id_taller
        {
            get { return id_taller; }
            set { id_taller = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string encargado;

        public string Encargado
        {
            get { return encargado; }
            set { encargado = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;
        public bool insert(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO talleres VALUES Id_taller, nombre, encargado, ubicacion, descripcion";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
             //  if (cmd.ExecuteNonQuery > 0)

                return true;
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
    }
}

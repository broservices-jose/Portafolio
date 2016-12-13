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
    class Imagen
    {
        private int id_imagen;

        public int Id_imagen
        {
            get { return id_imagen; }
            set { id_imagen = value; }
        }
        private string imagen;

        public string Imagen1
        {
            get { return imagen; }
            set { imagen = value; }
        }
        private string tipo_imagen;

        public string Tipo_imagen
        {
            get { return tipo_imagen; }
            set { tipo_imagen = value; }
        }


        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;

        public bool registrar(string ruta, string valor)
        {
            try
            {
                string miquery = "INSERT INTO imagen (imagen, tipo_imagen) VALUES (@param1, @param2)";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                cmd.Parameters.AddWithValue("@param1", ruta);
                cmd.Parameters.AddWithValue("@param2", valor);
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
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            return false;
        }

        public DataSet numeroregistro()
        {
            DataSet registros = new DataSet();

            try
            {
                string miquery = "SELECT imagen FROM imagen";
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

        }


     /*   private void nombredecolumnas()
        {
            tabla = new DataTable();
            tabla.Columns.Add("imagen");
            tabla.Columns.Add("tipo_imagen");
        }*/
    }
}

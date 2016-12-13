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
    class factura
    {
        private int id_factura;

        public int Id_factura
        {
            get { return id_factura; }
            set { id_factura = value; }
        }
        private string servicio_realizado;

        public string Servicio_realizado
        {
            get { return servicio_realizado; }
            set { servicio_realizado = value; }
        }

        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;

        public bool ingresar(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO factura (id_factura, id_servicio, id_orden, servicio_realizado, id_cliente VALUES ('" + dato[0] + "','" + dato[1] + "','" + dato[2] + "','" + dato[3] + "','" + dato[4] + "')";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cn.Close();
                    return true;
                }
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public DataTable consultar(string[] dato)
        {
            try
            {
                nombredecolumnas();
                string miomio = "SELECT * FROM  factura";
                cn = conexion.conectar();
                cmd = new MySqlCommand(miomio, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_factura"], leer["id_servicio"], leer["id_orden"], leer["servicio realizado"], leer["Id_cliente"] });
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

        private void nombredecolumnas()
        {
            tabla = new DataTable();
            tabla.Columns.Add("id_factura");
            tabla.Columns.Add("id_servicio");
            tabla.Columns.Add("id_orden");
            tabla.Columns.Add("servicio_realizado");
            tabla.Columns.Add("Id_cliente");


        }
    }
}

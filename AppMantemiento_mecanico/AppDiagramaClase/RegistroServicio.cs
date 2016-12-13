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
    class RegistroServicio
    {
        private int id_servicio;

        public int Id_servicio
        {
            get { return id_servicio; }
            set { id_servicio = value; }
        }
        private string tipo_servicio;

        public string Tipo_servicio
        {
            get { return tipo_servicio; }
            set { tipo_servicio = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private double costo;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        private int horas_servicio;

        public int Horas_servicio
        {
            get { return horas_servicio; }
            set { horas_servicio = value; }
        }
        private double porcentaje1;

        public double Porcentaje1
        {
            get { return porcentaje1; }
            set { porcentaje1 = value; }
        }
        private double porcentaje2;

        public double Porcentaje2
        {
            get { return porcentaje2; }
            set { porcentaje2 = value; }
        }
        private double porcentaje3;

        public double Porcentaje3
        {
            get { return porcentaje3; }
            set { porcentaje3 = value; }
        }

        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;

        public bool ingresar(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO serivcio (id_servicio, tipo_servicio, descripcion, horas_servicio, porcentaje1, porcentaje2, porcentaje3) VALUES ('" + dato[0] + "','" + dato[1] + "','" + dato[2] + "','" + dato[3] + "','" + dato[4] + "','" + dato[5] + "','" + dato[6] + "','" + dato[7] + "')";
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
                string miomio = "SELECT * FROM  servicio";
                cn = conexion.conectar();
                cmd = new MySqlCommand(miomio, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_servicio"], leer["tipo_servicio"], leer["costo"], leer["horas_servicio"], leer["porcentaje1"], leer["porcentaje2"], leer["porcentaje3"] });
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
            tabla.Columns.Add("id_servicio");
            tabla.Columns.Add("tipo servicio");
            tabla.Columns.Add("descripcion");
            tabla.Columns.Add("costo");
            tabla.Columns.Add("horas_servicio");
            tabla.Columns.Add("Porcentaje1");
            tabla.Columns.Add("Porentaje2");
            tabla.Columns.Add("POrcentaje3");

        }
    }
}

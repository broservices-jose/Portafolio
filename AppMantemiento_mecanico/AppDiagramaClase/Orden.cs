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
    class Orden
    {
        private int num_orden;

        public int Num_orden
        {
            get { return num_orden; }
            set { num_orden = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string situacion;

        public string Situacion
        {
            get { return situacion; }
            set { situacion = value; }
        }
        private string kilometraje;

        public string Kilometraje
        {
            get { return kilometraje; }
            set { kilometraje = value; }
        }
        private string combustible;

        public string Combustible
        {
            get { return combustible; }
            set { combustible = value; }
        }
        private bool llave;

        public bool Llave
        {
            get { return llave; }
            set { llave = value; }
        }
        private bool llave_rueda;

        public bool Llave_rueda
        {
            get { return llave_rueda; }
            set { llave_rueda = value; }
        }
        private bool gato;

        public bool Gato
        {
            get { return gato; }
            set { gato = value; }
        }
        private bool tapabocina;

        public bool Tapabocina
        {
            get { return tapabocina; }
            set { tapabocina = value; }
        }
        private bool radio;

        public bool Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        private bool triangulo;

        public bool Triangulo
        {
            get { return triangulo; }
            set { triangulo = value; }
        }
        private string evaluacion_previa;

        public string Evaluacion_previa
        {
            get { return evaluacion_previa; }
            set { evaluacion_previa = value; }
        }
        private bool repuesta;

        public bool Repuesta
        {
            get { return repuesta; }
            set { repuesta = value; }
        }
        private string estado_ingreso; // Como vino el vehiculoo

        public string Estado_ingreso
        {
            get { return estado_ingreso; }
            set { estado_ingreso = value; }
        }

        private bool encededor;

        public bool Encededor
        {
            get { return encededor; }
            set { encededor = value; }
        }
        private string fecha_salida;

        public string Fecha_salida
        {
            get { return fecha_salida; }
            set { fecha_salida = value; }
        }


        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;

        public bool ingresar(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO orden (num_orden, fecha, situacion, id_usuario, id_vehiculo, kilometraje, combustible, llave, llave_rueda, gato, tapabocina, radio, triangulo, evaluacio_previa, repuesta, estado_ingreso, fecha_salida) VALUES ('" + dato[0] + "','" + dato[1] + "','" + dato[2] + "','" + dato[3] + "','" + dato[4] + "','" + dato[5] + "','" + dato[6] + "','" + dato[7] + "','" + dato[8] + "','" + dato[9] + "','" + dato[10] + "','" + dato[11] + "','" + dato[12] + "','" + dato[13] + "','" + dato[14] + "','" + dato[15] +"','"+dato[16] + "')";
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

        public DataTable consultar()
        {
            try
            {
                nombredecolumnas();
                string miomio = "SELECT * FROM  factura";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miomio, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["num_orden"], leer["fecha"], leer["situacion"], leer["id_usuario"], leer["id_vehiculo"], leer["kilometraje"], leer["combustible"], leer["llave"], leer["gato"], leer["tapabocina"], leer["radio"], leer["triangulo"], leer["evaluacio_previa"], leer["repuesta"], leer["estado_ingreso"], leer ["fecha_salida"] });
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
            tabla.Columns.Add("num_orden");
            tabla.Columns.Add("fecha");
            tabla.Columns.Add("situacion");
            tabla.Columns.Add("id_usuario");
            tabla.Columns.Add("id_vehiculo");
            tabla.Columns.Add("kilometraje");
            tabla.Columns.Add("combustible");
            tabla.Columns.Add("llave");
            tabla.Columns.Add("llave_rueda");
            tabla.Columns.Add("gato");
            tabla.Columns.Add("tapabocina");
            tabla.Columns.Add("radio");
            tabla.Columns.Add("triangulo");
            tabla.Columns.Add("evaluacio_previa");
            tabla.Columns.Add("repuesta");
            tabla.Columns.Add("estado_ingreso");
        }
    }
}

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
    class Vehiculo
    {
        private string matricula;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        private string chasis;

        public string Chasis
        {
            get { return chasis; }
            set { chasis = value; }
        }
        private string placa;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        private string version;

        public string Version
        {
            get { return version; }
            set { version = value; }
        }
        private string anio;

        public string Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private string traccion;

        public string Traccion
        {
            get { return traccion; }
            set { traccion = value; }
        }
        private string transmision;

        public string Transmision
        {
            get { return transmision; }
            set { transmision = value; }
        }
        private string tipo_combustible;

        public string Tipo_combustible
        {
            get { return tipo_combustible; }
            set { tipo_combustible = value; }
        }
        private string fecha_registro;

        public string Fecha_registro
        {
            get { return fecha_registro; }
            set { fecha_registro = value; }
        }
        private string observaciones;

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        private int id_cliente;

        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }


        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;

        public bool insertar(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO vehiculo (id_cliente, matricula, chasis, placa, marca, modelo, version, anio, color, traccion, transimision, tipo_combustible, fecha_registro, observaciones, id_imagen) VALUES ('last_insert_id()" + "','" + dato[0] + "','" + dato[1] + "','" + dato[2] + "','" + dato[3] + "','" + dato[4] + "','" + dato[5] + "','" + dato[6] + "','" + dato[7] + "','" + dato[8] + "','" + dato[9] + "','" + dato[10] + "','" + dato[11] + "','" + dato[12] + "','" +dato[13]+"','"+ "last_insert_id()')";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        public DataTable consultar()
        {
            try
            {
                nombredecolumnas();
                string miomio = "SELECT ca.id_cliente, va.matricula, va.chasis, va.placa, va.marca, va.modelo, va.version, va.anio, va.color, va.traccion, va.transimision, va.tipo_combustible, va.fecha_registro, va.observaciones FROM cliente ca, vehiculo va WHERE va.id_cliente = ca.id_cliente";
                cn = conexion.conectar();
                cmd = new MySqlCommand(miomio, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer ["id_cliente"], leer["matricula"], leer["chasis"], leer["placa"], leer["marca"], leer["modelo"], leer["version"], leer["anio"], leer["color"], leer["traccion"], leer["transmision"], leer["tipo_combustible"], leer["fecha_ingreso"], leer["observaciones"] });
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
            tabla.Columns.Add("id_cliente");
            tabla.Columns.Add("Matricula");
            tabla.Columns.Add("Chasis");
            tabla.Columns.Add("Placa");
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("Modelo");
            tabla.Columns.Add("Version");
            tabla.Columns.Add("Anio");
            tabla.Columns.Add("Color");
            tabla.Columns.Add("Traccion");
            tabla.Columns.Add("Transimision");
            tabla.Columns.Add("Tipo_combustible");
            tabla.Columns.Add("Fecha_ingreso");
            tabla.Columns.Add("Observaciones");
        }
    }
}

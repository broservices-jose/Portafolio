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
    class Mecanico : Persona
    {
        private int id_mecanico;

        public int Id_mecanico
        {
            get { return id_mecanico; }
            set { id_mecanico = value; }
        }
        private string fecha_contratacion;

        public string Fecha_contratacion
        {
            get { return fecha_contratacion; }
            set { fecha_contratacion = value; }
        }
        private string taller;

        public string Taller
        {
            get { return taller; }
            set { taller = value; }
        }
        private double sueldo_base;

        public double Sueldo_base
        {
            get { return sueldo_base; }
            set { sueldo_base = value; }
        }
        private double precio_hora;

        public double Precio_hora
        {
            get { return precio_hora; }
            set { precio_hora = value; }
        }

        private int id_imagen;

        public int Id_imagen
        {
            get { return id_imagen; }
            set { id_imagen = value; }
        }

        private MySqlConnection cn;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;

        public bool ingresar(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO mecanico (id_persona, fecha_contraracion, taller, sueldo_base, precio_hora, id_imagen) VALUES ('last_insert_id()" +"','"+ dato[0] + "','" + dato[1] + "','" + dato[2] + "','" + dato[3] + "','" +"last_insert_id() ')";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);

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
        public DataTable consultar()
        {
            try
            {
                nombredecolumnas();
                string miquery = "select ab.nombre, ab.apellido, ab.sexo, ab.nacimiento, ab.telefono, ab.correo, ab.direccion, ab.nacionalidad, ab.trato, ab.tipo_documento, ab.num_documento, am.fecha_contraracion, am.taller, am.sueldo_base, am.precio_hora from Personas ab, mecanico am where am.id_persona = ab.id_persona";

                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer ["nombre"], leer ["apellido"], leer ["sexo"], leer ["nacimiento"], leer ["telefono"], leer ["correo"], leer["direccion"], leer ["nacionalidad"], leer ["trato"], leer ["tipo_documento"], leer ["num_documento"], leer["fecha_contraracion"], leer["taller"], leer["sueldo_base"], leer["precio_hora"] });
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
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Sexo");
            tabla.Columns.Add("Nacimiento");
            tabla.Columns.Add("Telefono");
            tabla.Columns.Add("Correo");
            tabla.Columns.Add("Direccion");
            tabla.Columns.Add("Nacionalidad");
            tabla.Columns.Add("Trato");
            tabla.Columns.Add("Tipo_documento");
            tabla.Columns.Add("Num_documento");
            tabla.Columns.Add("fecha_contratacion");
            tabla.Columns.Add("taller");
            tabla.Columns.Add("sueldo_base");
            tabla.Columns.Add("precio_hora");  

        }
    }
}

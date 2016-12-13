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
    class DetalleLabMecanica
    {
        private int id_detallelabmecanica;

        public int Id_detallelabmecanica
        {
            get { return id_detallelabmecanica; }
            set { id_detallelabmecanica = value; }
        }
        private double importe;

        public double Importe
        {
            get { return importe; }
            set { importe = value; }
        }
        private double pago;

        public double Pago
        {
            get { return pago; }
            set { pago = value; }
        }
        private int fecha_pago;

        public int Fecha_pago
        {
            get { return fecha_pago; }
            set { fecha_pago = value; }
        }


        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;


        public bool ingresar(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO detalle_laborMecanica (id_detalle_labmecanica, id_mecanico, id_orden, id_servicio, importe, pago, fecha_pago) VALUES ('" + dato[0] + "','" + dato[1] + "','" + dato[2] + "','" + dato[3] + "','" + dato[4] + "','" + dato[5] + "','" + dato[6] + "')";
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
                string miomio = "SELECT * FROM  detalle_laborMecanica";
                cn = conexion.conectar();
                cmd = new MySqlCommand(miomio, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_detalle_labmecanica"], leer["id_mecanico"], leer["id_orden"], leer["id_servicio"], leer["importe"], leer["pago"], leer["fecha_pago"] });
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
            tabla.Columns.Add("id_detalle_labmecanica");
            tabla.Columns.Add("id_mecanico");
            tabla.Columns.Add("id_orden");
            tabla.Columns.Add("id_servicio");
            tabla.Columns.Add("importe");
            tabla.Columns.Add("pago");
            tabla.Columns.Add("fecha_pago");
        }

    }
}

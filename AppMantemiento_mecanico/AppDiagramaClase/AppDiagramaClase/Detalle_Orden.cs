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
    class Detalle_Orden : Orden
    {
        private int id_detalle_orden;

        public int Id_detalle_orden
        {
            get { return id_detalle_orden; }
            set { id_detalle_orden = value; }
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private double costo;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private double importe;

        public double Importe
        {
            get { return importe; }
            set { importe = value; }
        }
        private double itbis;

        public double Itbis
        {
            get { return itbis; }
            set { itbis = value; }
        }
        private double neto;

        public double Neto
        {
            get { return neto; }
            set { neto = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private double descuentos;

        public double Descuentos
        {
            get { return descuentos; }
            set { descuentos = value; }
        }
        private double totales;

        public double Totales
        {
            get { return totales;}
            set { totales = value;}
        }


        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;

        public bool insertar(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO detalle_orden (id_detalle_orden, id_servicio, tipo, cantidad, costo, precio, imorte, itbis, neto, estado, descuentos, id_mecanico, totales) VALUES ('" + dato[0] + "','" + dato[1] + "','" + dato[2] + "','" + dato[3] + "','" + dato[4] + "','" + dato[5] + "','" + dato[6] + "','" + dato[7] + "','" + dato[8] + "','" + dato[9] + "','" + dato[10] + "','" + dato[11] + "','" + dato[12] + "')";
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
                string miomio = "SELECT * FROM  detalle_orden";
                cn = conexion.conectar();
                cmd = new MySqlCommand(miomio, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_detalle_orden"], leer["id_servicio"], leer["tipo"], leer["cantidad"], leer["costo"], leer["precio"], leer["importe"], leer["itbis"], leer["neto"], leer["estado"], leer["descuentos"], leer["id_mecanico"], leer["totales"] });
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
            tabla.Columns.Add("id_detalle_orden");
            tabla.Columns.Add("id_servicio");
            tabla.Columns.Add("tipo");
            tabla.Columns.Add("cantidad");
            tabla.Columns.Add("costo");
            tabla.Columns.Add("precio");
            tabla.Columns.Add("importe");
            tabla.Columns.Add("itbis");
            tabla.Columns.Add("neto");
            tabla.Columns.Add("estado");
            tabla.Columns.Add("descuentos");
            tabla.Columns.Add("id_meacanico");
            tabla.Columns.Add("totales");

        }
    }
}

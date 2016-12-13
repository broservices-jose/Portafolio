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
    class Recibo
    {
        private int fecha;

        public int Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int documento;

        public int Documento
        {
            get { return documento; }
            set { documento = value; }
        }
        private int documento_fuente;

        public int Documento_fuente
        {
            get { return documento_fuente; }
            set { documento_fuente = value; }
        }
        private int detalle;

        public int Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        private string detlle;

        public string Detlle
        {
            get { return detlle; }
            set { detlle = value; }
        }
        private double debito;

        public double Debito
        {
            get { return debito; }
            set { debito = value; }
        }
        private double credito;

        public double Credito
        {
            get { return credito; }
            set { credito = value; }
        }


        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;

        public bool ingresar(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO recibo (fecha, documento, documento_fuente, detalle, debito, credito) VALUES ('" + dato[0] + "','" + dato[1] + "','" + dato[2] + "','" + dato[3] + "','" + dato[4] + "','" + dato[5] + "')";
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Lavanderia0._1.Modelo
{
   public class CPagodenomina : CLEmpleado
    {

        // ******************************************************************* ||
        // Esta linea de codigo representa la declaracion de las variables que
        // nos va a permitir interactuar con la tabla pago_nomina de la base de 
        // datos dblavanderia
        // ******************************************************************* ||

        private int id_pago_nomina;

        public int Id_pago_nomina
        {
            get { return id_pago_nomina; }
            set { id_pago_nomina = value; }
        }

        private double deuda;

        public double Deuda
        {
            get { return deuda; }
            set { deuda = value; }
        }
        private string motivo;

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string pago;

        public string Pago
        {
            get { return pago; }
            set { pago = value; }
        }

        private string empleado;

        public string Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }


        //===============================================//
        // EStos son los objectos que me permitirar 
        // interatuar con la base de datos///

        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;


        //==============================================//
        // Metodo para nombrar las columnas=============//
        //==============================================//

        private void NombrerColumnas()
        {
            tabla = new DataTable();
            tabla.Columns.Add("ID");
            tabla.Columns.Add("Empleado");// ESte viene siendo el id del empleado o el nombre
            tabla.Columns.Add("Cedula");
            tabla.Columns.Add("Sueldo");
            tabla.Columns.Add("Cargo");
            tabla.Columns.Add("Deuda");
            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Motivo");
            tabla.Columns.Add("Pago");  


        }

        // ************************************************************************************************************** ||
        // Esta linea de codigo representa el metodo Consultar() el cual nos va a permitir traer los datos de la 
        // tabla pago_nomina para llenar el datagridview del formulario pago de nomina
        // ************************************************************************************************************** ||

        public DataTable Consultar()
        {

            try
            {
                NombrerColumnas();
                cn = new MySqlConnection();
                cn = Conexion.conectar();
                cn.Open();
                string query = "select pa.id_pago_nomina, concat(e.nombre,' ', e.apellido) as empleado,  e.cedula,"+
                               " e.sueldo, e.cargo, pa.deuda, pa.fecha, pa.motivo, pa.pago from  empleado e, pago_nomina pa "+
                               " where pa.id_pago_nomina = e.id_empleado";

                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {


                    tabla.Rows.Add(leer["id_pago_nomina"], leer["empleado"], leer["cedula"], leer["sueldo"], leer["cargo"],
                                   leer ["deuda"], leer["fecha"], leer["motivo"], leer["pago"]);

                }

                return tabla;


            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "1" + e.StackTrace);

            }
            catch (NullReferenceException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "2" + e.StackTrace);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "3" + e.StackTrace);
            }
            return tabla;


        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace Lavanderia0._1.Modelo
{
    public class CLEmpleado : CLPersona
    {
        // =========================================================================\\
        // Esta linea de codigo en adelante representa la declaracion y encapsulamiento
        // de las variables que nos van a permitir interactuar con la base de datos
        // =========================================================================\\


        private int id_empleado;

        public int Id_empleado
        {
            get { return id_empleado; }
            set { id_empleado = value; }
        }

        private double sueldo;

        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        private string fecha_contrato;

        public string Fecha_contrato
        {
            get { return fecha_contrato; }
            set { fecha_contrato = value; }
        }

        private string cargo;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }



        // =========================================\\
        // Esta linea de codigo representa la creacion
        // o instanciacion de los objetos que nos van
        // a permitir interactuar con la base de datos
        // =========================================\\

        private MySqlConnection cn = null;
        private MySqlCommand cmd =null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;    
    
        // ================================================================================//
        // Esta linea de codigo representa el metodo consulta() el cual nos va a permitir
        // traer todas las informaciones almacenadas en la base de datos DBLavanderia 
        // =================================================================================//

        public DataTable consulta()
        {
            try
            {
                nombrecolumna();
                string query = "select e.id_empleado, e.nombre, e.apellido, e.Sexo, e.cedula, e.fecha_nac,"+
                "e.telefono, e.correo, e.direccion, e.sueldo, e.fecha_contrato, e.cargo, r.rnombre, r.rapellido," +
                " r.rtelefono, i.ruta  from empleado e inner join referencia r on e.id_referencia = " +
                "r.id_referencia inner join imagen i on i.id_imagen = e.id_imagen";

                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(leer["id_empleado"], leer["nombre"], leer["apellido"], leer["Sexo"], leer["cedula"],
                                   leer["fecha_nac"], leer["telefono"], leer["correo"], leer["direccion"],
                                   leer["sueldo"],    leer["fecha_contrato"], leer["cargo"], leer["rnombre"], 
                                   leer["rapellido"] , leer["rtelefono"], leer["ruta"]);
                }
                return tabla;
            }                
            catch (MySqlException mx)
            {
                MessageBox.Show(mx.Message + " en mx : " + mx.StackTrace);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message + " en n : " + n.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "en ex : " + ex.StackTrace);
            }
            return tabla;

        }

        // ========================================================================================================\\
        // Esta linea de codigo representa el metodo nombrecolumna() el cual nos va a permitir ponerle el nombre a la
        // columna del datagridview
        // =========================================================================================================\\
        private void nombrecolumna()
        //id_empleado, nombre, apellido, Sexo, fecha_nac, telefono, correo, direccion, 
        {                // sueldo, fecha_contrato, cargo, nombre, apellido, ruta
            tabla = new DataTable();
            tabla.Columns.Add("ID");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Sexo");
            tabla.Columns.Add("Cedula");
            tabla.Columns.Add("Fecha Nacimiento");
            tabla.Columns.Add("Telefono");
            tabla.Columns.Add("Correo");
            tabla.Columns.Add("Direccion");
            tabla.Columns.Add("Sueldo");
            tabla.Columns.Add("Fecha Contrato");
            tabla.Columns.Add("Cargo");
            tabla.Columns.Add("Nombre Ref");
            tabla.Columns.Add("Apellido Ref");
            tabla.Columns.Add("Telefono Ref");
            tabla.Columns.Add("Imagen");
        }


        // ================================================================================//
        // Esta linea de codigo representa el metodo consulta2() el cual nos va a permitir
        // traer todas las informaciones almacenadas en la base de datos DBLavanderia 
        // y llenar el datagridview del formulario empleados registrado
        // =================================================================================//

        public DataTable consultar2()
        {
            try
            {
                nombrecolumnaemp();
                string query = "select e.id_empleado, concat(e.nombre, ' ', e.apellido) as empleado,"+
                    " e.Sexo, e.cedula, e.telefono, i.ruta from empleado e inner join referencia r on "+
                    "e.id_referencia = r.id_referencia inner join imagen i on i.id_imagen = e.id_imagen";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(leer["id_empleado"], leer["empleado"], leer["Sexo"], leer["cedula"],
                                   leer["telefono"], leer["ruta"]);
                }
                return tabla;
            }
            catch (MySqlException mx)
            {
                MessageBox.Show(mx.Message + mx.StackTrace);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message + n.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            return tabla;
        }



        // ========================================================================================================\\
        // Esta linea de codigo representa el metodo nombrecolumna() el cual nos va a permitir ponerle el nombre a la
        // columna del datagridview dgvempleados el cual vamos a utilizar para cargar los empleados seleccionados de 
        // otros formularios como pago de nomina y usuario
        // =========================================================================================================\\

        private void nombrecolumnaemp()
        {
            tabla = new DataTable();
            tabla.Columns.Add("ID");
            tabla.Columns.Add("Empleado");
            tabla.Columns.Add("Sexo");
            tabla.Columns.Add("Cedula");
            tabla.Columns.Add("Telefono");
            tabla.Columns.Add("Imagen");
        }


        // **************************************************************************************************  ||
        // Esta linea de codigo representa el metodo necesito() el cual nos va a permitir obtener el id_imagen
        // de la tabla empleado el cual lo vamos a utilizar para poder modificar la ruta de la tabla imagen
        // ************************************************************************************************** ||

        public int necesito(int id)
        {
            try
            {
                string query = "select id_imagen from empleado where id_empleado =" + id;
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    return Convert.ToInt32(leer["id_imagen"]);
                }
            }
            catch (MySqlException mx)
            {
                MessageBox.Show(mx.Message + mx.StackTrace);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message + n.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            return 0;
        }
    
    }

}

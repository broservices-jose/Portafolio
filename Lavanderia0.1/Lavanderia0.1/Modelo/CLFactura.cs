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
    class CLFactura
    {

        // =================================================== ||
        // Esta linea de codigo representa el las variable  que
        // se encuentran encapsuladas las cuales nos van a 
        // permitir interactuar con la tabla factura de la
        // base de datos
        // =================================================== ||

        private int id_factura;

        public int Id_factura
        {
            get { return id_factura; }
            set { id_factura = value; }
            }

        private double total_desc;

        public double Total_desc
        {
            get { return total_desc; }
            set { total_desc = value; }
        }

        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        private string hora_entrega;

        public string Hora_entrega
        {
            get { return hora_entrega; }
            set { hora_entrega = value; }
        }

        private string fecha_recibido;

        public string Fecha_recibido
        {
            get { return fecha_recibido; }
            set { fecha_recibido = value; }
        }

        private string fecha_entrega;

        public string Fecha_entrega
        {
            get { return fecha_entrega; }
            set { fecha_entrega = value; }
        }

        private bool entregado;

        public bool Entregado
        {
            get { return entregado; }
            set { entregado = value; }
        }

        private bool pagado;

        public bool Pagado
        {
            get { return pagado; }
            set { pagado = value; }
        }

        // ***************************************************************** ||
        // Esta linea de codigo representa las varables que se encuentran 
        // encapsuladas las cuales nos van permitir interactuar con la tabla
        // detalle_factura  de la base de dato
        // ***************************************************************** ||

        private int id_detalle_orden;

        public int Id_detalle_orden
        {
            get { return id_detalle_orden; }
            set { id_detalle_orden = value; }
        }

        private int cantidad_articulo;

        public int Cantidad_articulo
        {
            get { return cantidad_articulo; }
            set { cantidad_articulo = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        

        private double subtotal;

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        private double descuento;

        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        private double totaldesc;

        public double Totaldesc
        {
            get { return total_desc; }
            set { total_desc = value; }
        }

        private int id_servicio;

        public int Id_servicio
        {
            get { return id_servicio; }
            set { id_servicio = value; }
        }

        private int id_articulo;

        public int Id_articulo{
            get { return id_articulo; }
            set { id_articulo = value; }
        }

        private int id_cliente;

        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }

        private int id_factura_d;

        public int Id_factura_d
        {
            get { return id_factura_d; }
            set { id_factura_d = value; }
        }

        // =========================================\\
        // Esta linea de codigo representa la creacion
        // o instanciacion de los objetos que nos van
        // a permitir interactuar con la base de datos
        // =========================================\\

        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;

        // ================================================================================//
        // Esta linea de codigo representa el metodo mostrardetalle() el cual nos va a permitir
        // traer todas las informaciones almacenadas en la base de datos DBLavanderia 
        // =================================================================================//

        public DataTable mostrardetalle(int id)
        {
            try
            {
                columnadetalle();
                string query = "select d.id_detalle_orden, s.servicio, a.articulo, a.categoria, d.color, d.cantida_articulo, " +
                               " s.precio, d.descuento, d.subtotal from detalle_orden d inner join articulo a on a.id_articulo = d.id_articulo " +
                               " inner join servicio s on s.id_servicio = d.id_servicio where d.id_factura ="+id;
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(leer["id_detalle_orden"], leer["servicio"], leer["articulo"], leer["categoria"],
                                   leer["color"], leer["cantida_articulo"], leer["precio"], leer["descuento"],
                                   leer["subtotal"]);
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

        // ******************************************************************** ||
        // Esta linea de codigo representa el metodo nombrecolumnad() el cual 
        // nos va a permitir darle nombre a las columnas del datagridview 
        // dgvdetalle del formuario factura 
        // ******************************************************************** ||


        private void columnadetalle()
        { 
            tabla = new DataTable();
            tabla.Columns.Add("ID");
            tabla.Columns.Add("Servicio");
            tabla.Columns.Add("Articulo");
            tabla.Columns.Add("Categoria");
            tabla.Columns.Add("Color");
            tabla.Columns.Add("Cantidad de Artic");
            tabla.Columns.Add("Precio");
            tabla.Columns.Add("Descuento");
            tabla.Columns.Add("Sub-Total");
        }

        // ******************************************************************************* ||
        // Esta linea de codigo representa el metodo llenarfac() el cual nos va a permitir 
        // llenar los cuadros de textos del formulario factura con los totales de los detalles
        // de servicio que pertenezcan a esa factura
        // ******************************************************************************* ||

        public void llenarfac(TextBox txtdesc, TextBox txttatol)
        {
            try
            {
                string query = "select sum(totaldesc) as descuento, sum(subtotal) as total "+
                               " from detalle_orden where id_factura = (select max(id_factura)"+
                               " from detalle_orden)";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    txtdesc.Text = leer["descuento"].ToString();
                    txttatol.Text = leer["total"].ToString();
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
        }
    

        // ******************************************************************************************************************** ||
        // Esta linea de codigo representa el metodo dameid1() el cual nos va retornar el ultimo id_factura de la tabla factura
        // el cual vamos a utilizar para compararlo con el id_factura de la tabla detalle_orden
        // ******************************************************************************************************************** ||

        public int dameid1()
        {
            try
            {
                string query = "select max(id_factura) as maximo from factura where estado = 'habilitado'";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    return Convert.ToInt32(leer["maximo"]);
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

        // ************************************************************************************************************** ||
        // Esta linea de codigo representa el metodo dameid2() el cual nos va retornar el ultimo id_factura de la tabla 
        // detalle_orden el cual vamos a utilizar para compararlo con el id_factura de la tabla factura
        // ************************************************************************************************************** ||

        public int dameid2()
        {
            try
            {
                string query = "select max(id_factura)as maximu from detalle_orden";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    return Convert.ToInt32(leer["maximu"]);
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

        // ******************************************************************************************************** ||
        // Esta linea de codigo representa el metodo mostrarfactur() el cual nos va permitir traer todos los datos
        // de las facturas registrada en la tabla factura para posteriormente mostrarlo en un datagridview del 
        // formulario orden
        // ******************************************************************************************************** ||

        public DataTable mostrarfactura()
        {
            try
            {
                columnafactura();
                string query = "select f.id_factura, concat(c.nombre, ' ',c.apellido) as empleado, f.fecha_recibido, "+
                    " f.fecha_entrega, f.hora_entrega, f.total_desc, f.total , f.entregado, f.pagado from factura f " +
                    " inner join cliente c on  c.id_cliente = f.id_cliente inner join detalle_orden d on "+
                    " d.id_factura = f.id_factura where f.estado = 'habilitado'";
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(leer["id_factura"], leer["empleado"], leer["fecha_recibido"], leer["fecha_entrega"],
                                   leer["hora_entrega"], leer["total_desc"], leer["total"], leer["entregado"], 
                                   leer["pagado"]);
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

        // ******************************************************************** ||
        // Esta linea de codigo representa el metodo columnafactura() el cual 
        // nos va a permitir darle nombre a las columnas del datagridview 
        // dgvorden del formuario orden 
        // ******************************************************************** ||

        private void columnafactura()
        {
            tabla = new DataTable();
            tabla.Columns.Add("ID");
            tabla.Columns.Add("Empleado");
            tabla.Columns.Add("F/Recibido");
            tabla.Columns.Add("F/Entrega");
            tabla.Columns.Add("H/Entrega");
            tabla.Columns.Add("Total Desc");
            tabla.Columns.Add("Total");
            tabla.Columns.Add("Entregado");
            tabla.Columns.Add("Pagado");
        }
    }
}

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
                cn.Open();
                cmd = new MySqlCommand(miomio, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer ["id_cliente"], leer["matricula"], leer["chasis"], leer["placa"], leer["marca"], leer["modelo"], leer["version"], leer["anio"], leer["color"], leer["traccion"], leer["transimision"], leer["tipo_combustible"], leer["fecha_registro"], leer["observaciones"] });
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
            tabla.Columns.Add("Fecha_registro");
            tabla.Columns.Add("Observaciones");
            tabla.Columns.Add("Imagen");
        }

        public DataTable filtrar(string filtro)
        {
            try
            {
                nombredecolumnas();
                string miquery = "SELECT ca.id_cliente, va.matricula, va.chasis, va.placa, va.marca, va.modelo, va.version, va.anio, va.color, va.traccion, va.transimision, va.tipo_combustible, va.fecha_registro, va.observaciones, i.imagen FROM cliente ca inner JOIN vehiculo va ON va.id_cliente = ca.id_cliente inner JOIN imagen i ON va.id_imagen = i.id_imagen WHERE va.matricula LIKE '" + filtro + "%'";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] {  leer["id_cliente"], leer["matricula"], leer["chasis"], leer["placa"], leer["marca"], leer["modelo"], leer["version"], leer["anio"], leer["color"], leer["traccion"], leer["transimision"], leer["tipo_combustible"], leer["fecha_registro"], leer["observaciones"], leer ["imagen"] });
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


        public DataTable filtrar1(string filtro)
        {
            try
            {
                nombredecolumnas();
                string miquery = "SELECT ca.id_cliente, va.matricula, va.chasis, va.placa, va.marca, va.modelo, va.version, va.anio, va.color, va.traccion, va.transimision, va.tipo_combustible, va.fecha_registro, va.observaciones, i.imagen FROM cliente ca inner JOIN vehiculo va ON va.id_cliente = ca.id_cliente inner JOIN imagen i ON va.id_imagen = i.id_imagen WHERE va.placa LIKE '" + filtro + "%'";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_cliente"], leer["matricula"], leer["chasis"], leer["placa"], leer["marca"], leer["modelo"], leer["version"], leer["anio"], leer["color"], leer["traccion"], leer["transimision"], leer["tipo_combustible"], leer["fecha_registro"], leer["observaciones"] });
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



        public DataTable filtrar2(string filtro)
        {
            try
            {
                nombredecolumnas();
                string miquery = "SELECT ca.id_cliente, va.matricula, va.chasis, va.placa, va.marca, va.modelo, va.version, va.anio, va.color, va.traccion, va.transimision, va.tipo_combustible, va.fecha_registro, va.observaciones, i.imagen FROM cliente ca inner JOIN vehiculo va ON va.id_cliente = ca.id_cliente inner JOIN imagen i ON va.id_imagen = i.id_imagen WHERE va.marca LIKE '" + filtro + "%'";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_cliente"], leer["matricula"], leer["chasis"], leer["placa"], leer["marca"], leer["modelo"], leer["version"], leer["anio"], leer["color"], leer["traccion"], leer["transimision"], leer["tipo_combustible"], leer["fecha_registro"], leer["observaciones"] });
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

        public DataTable filtrar3(string filtro)
        {
            try
            {
                nombredecolumnas();
                string miquery = "SELECT ca.id_cliente, va.matricula, va.chasis, va.placa, va.marca, va.modelo, va.version, va.anio, va.color, va.traccion, va.transimision, va.tipo_combustible, va.fecha_registro, va.observaciones, i.imagen FROM cliente ca inner JOIN vehiculo va ON va.id_cliente = ca.id_cliente inner JOIN imagen i ON va.id_imagen = i.id_imagen WHERE va.anio LIKE '" + filtro + "%'";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_cliente"], leer["matricula"], leer["chasis"], leer["placa"], leer["marca"], leer["modelo"], leer["version"], leer["anio"], leer["color"], leer["traccion"], leer["transimision"], leer["tipo_combustible"], leer["fecha_registro"], leer["observaciones"], leer["imagen"] });
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

        public DataTable paraconsultar(string dato)
        {
            try
            {
                nombredecolumnas();
                string miomio = "SELECT ca.id_cliente, va.matricula, va.chasis, va.placa, va.marca, va.modelo, va.version, va.anio, va.color, va.traccion, va.transimision, va.tipo_combustible, va.fecha_registro, va.observaciones, i.imagen FROM cliente ca inner JOIN vehiculo va ON va.id_cliente = ca.id_cliente inner JOIN imagen i ON va.id_imagen = i.id_imagen WHERE va.matricula ='"+dato[0]+"'";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miomio, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_cliente"], leer["matricula"], leer["chasis"], leer["placa"], leer["marca"], leer["modelo"], leer["version"], leer["anio"], leer["color"], leer["traccion"], leer["transimision"], leer["tipo_combustible"], leer["fecha_registro"], leer["observaciones"], leer ["imagen"] });
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

        public bool eliminar(string mat)
        {
            try
            {
                string elimina = "DELETE vehiculo from vehiculo INNER JOIN cliente ON cliente.id_cliente = vehiculo.id_cliente inner join imagen on imagen.id_imagen = vehiculo.id_imagen WHERE matricula  ='" +  mat+ "'";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(elimina, cn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cn.Close();
                    return true;
                }
            }

            catch (MySqlException mx)
            {
                MessageBox.Show(mx.Message);
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


        public bool modificar(object[] dato)
        {
            try
            {
                string miactualiza = "UPDATE vehiculo v INNER JOIN cliente c ON c.id_cliente = v.id_cliente INNER JOIN imagen i ON i.id_imagen = v.id_imagen SET v.chasis = '" + dato[1] + "', v.placa = '" + dato[2] + "', v.marca = '" + dato[3] + "', v.modelo = '" + dato[4] + "', v.version = '" + dato[5] + "', v.anio = '" + dato[6] + "', v.color = '" + dato[7] + "', v.traccion = '" + dato[8] + "', v.transimision = '" + dato[9] + "', v.tipo_combustible = '" + dato[10] + "', v.fecha_registro = '" + dato[11] + "', v.observaciones = '" + dato[12] + "', i.imagen = '" + dato[13] +  "' WHERE id_cliente ='" + dato[0] + "'";
                System.Windows.Forms.MessageBox.Show(miactualiza);
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miactualiza, cn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cn.Close();
                    return true;
                }
            }

            catch (MySqlException mx)
            {
                MessageBox.Show(mx.Message);
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
        // Este metodo es para que los botones de next y back funcione
        public DataSet numeroregistro()
        {
            DataSet registros = new DataSet();

            try
            {
                string miquery = "SELECT imagen.a FROM imagen a, vehiculo v, WHERE a.id_imagen = v.id_imagen";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                MySqlDataAdapter objeto = new MySqlDataAdapter(miquery, cn);
                objeto.Fill(registros);
                return registros;
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return registros;
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message);
                return registros;
            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
                return registros;
            }
            finally
            {
                cn.Close();
            }

        }
    }
}

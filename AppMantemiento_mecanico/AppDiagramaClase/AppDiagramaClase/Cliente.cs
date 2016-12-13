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
    class Cliente : Persona
    {
        private int id_cliente;

        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        private string comentarios;

        public string Comentarios
        {
            get { return comentarios; }
            set { comentarios = value; }
        }
        private string rnc;

        public string Rnc
        {
            get { return rnc; }
            set { rnc = value; }
        }
        private string nfc;

        public string Nfc
        {
            get { return nfc; }
            set { nfc = value; }
        }
        private string tipo_cliente;

        public string Tipo_cliente
        {
            get { return tipo_cliente; }
            set { tipo_cliente = value; }
        }

        private MySqlConnection cn;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;
        private DataTable tabla1 = null;

        public bool ingresar(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO cliente (id_persona, comentarios, rnc, nfc, tipo_cliente, id_imagen) VALUES ('last_insert_id()" + "','" + dato[0] + "','" + dato[1] + "','" + dato[2] + "','" + dato[3] + "','" + "last_insert_id() ')";
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
                nombredecolumnasc();
                string miquery = "SELECT  ab.nombre ,ab.apellido, ab.sexo, ab.nacimiento, ab.telefono, ab.correo, ab.direccion, ab.nacionalidad, ab.trato, ab.tipo_documento, ab.num_documento, ac.comentarios, ac.rnc, ac.nfc, ac.tipo_cliente  FROM Personas ab, cliente ac WHERE ac.id_persona = ab.id_persona";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["Nombre"], leer["Apellido"], leer["Sexo"], leer["Nacimiento"], leer["Telefono"], leer["Correo"], leer["Direccion"], leer["Nacionalidad"], leer["trato"], leer["tipo_documento"], leer["Num_documento"], leer["Comentarios"], leer["Rnc"], leer["Nfc"], leer["Tipo_cliente"] });
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
        private void nombredecolumnasc()
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
            tabla.Columns.Add("Comentarios");
            tabla.Columns.Add("RNC");
            tabla.Columns.Add("NFC");
            tabla.Columns.Add("Tipo_cliente");

        }

        public DataTable nada()
        {
            try
            {
                string query = "SELECT cliente.id_cliente, imagen.imagen, Personas.nombre FROM cliente INNER JOING imagen ON imagen.id_imagen = cliente.id_imagen INNER JOIN Personas ON Personas.id_persona = cliente.id_persona";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_cliente"], leer["imagen"], leer["nombre"] });
                }

                leer.Close();
                cn.Close();
                return tabla1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message);
            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
            }
            return tabla1;
        }

        public DataSet numeroregistro()
        {
            DataSet registros = new DataSet();

            try
            {
                string miquery = "SELECT imagen.a FROM imagen a, cliente b, WHERE a.id_imagen = b.id_imagen";
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

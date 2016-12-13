using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace AppDiagramaClase
{
    public class Persona
    {
        private int id_persona;

        public int Id_persona
        {
            get { return id_persona; }
            set { id_persona = value; }
        }
        private string trato;

        public string Trato
        {
            get { return trato; }
            set { trato = value; }
        }
        private string tipo_documento;

        public string Tipo_documento
        {
            get { return tipo_documento; }
            set { tipo_documento = value; }
        }
        private string num_documento;

        public string Num_documento
        {
            get { return num_documento; }
            set { num_documento = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        private string nacimiento;

        public string Nacimiento
        {
            get { return nacimiento; }
            set { nacimiento = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }



        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer;
        private DataTable tabla;
    

          public bool insertar(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO Personas ( trato, tipo_documento, num_documento, nombre, apellido, sexo, naciminto, telefono, correo, direccion, nacionalidad) VALUES ('" + dato[0] + "','" + dato[1] + "','" + dato[2] + "','" + dato[3] + "','" + dato[4] + "','" + dato[5] + "','" + dato[6] + "','" + dato[7] + "','" + dato[8] + "','" + dato[9] + "','" + dato[10] + ")'";
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
    }
}

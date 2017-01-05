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
    class ControlDB
    {
        // ***************************************** \\
        // Esta linea de codigo representa la creacion
        // o instanciacion de los objetos que nos van
        // a permitir interactuar con la base de datos
        // ****************************************** \\

        private MySqlConnection cn;
        private MySqlCommand cmd;
        private MySqlDataReader leer;


        // ******************************************************************************************* \\
        // Esta linea de codigo representa el metodo generarinsert() el cual nos va a permitir
        // insetar los datos desde cualquier formulario del sistema para su posterior inserccion
        // en la base de datos DBLavanderia
        // ******************************************************************************************** \\

        public bool generarInsert(string[] campo, string[] valor, string tabla)
        {
            string valores = "";
            string campos = "";

            try
            {
                for (int i = 0; i < campo.Length; i++)
                {
                    if (i == 0){
                        campos += campo[i];
                        if (valor[i].Equals("now()"))
                        {
                            valores += "" + valor[i] + "";
                        }
                        else
                        {
                            valores += "'" + valor[i] + "'";
                        }
                    }
                    else
                    {
                        campos += " , " + campo[i];
                        if (valor[i].Equals("now()"))
                        {
                            valores += "," + valor[i] + "";
                        }
                        else
                        {
                            valores += ",'" + valor[i] + "'";
                        }
                        
                    }
                }
                string query = "INSERT INTO " + tabla + " " + " (" + campos + ")" +
                               "values (" + valores + ")";
                MessageBox.Show("este es el query " + query);
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                    cn.Close();
                }
 
                
            }
                
              catch(MySqlException mx){
                    MessageBox.Show(mx.Message+mx.StackTrace);
                }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message + n.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            return false;
        }

        // ***************************************************************************************** \\
        // Esta linea de codigo representa el metodo eliminar() el cual nos va a permitir eliminar los
        // datos solicitados del cualquier formulario del sistema 
        // ***************************************************************************************** \\ 

        public bool eliminar(string tabla, string union, string campo, string id)
        {
            try
            {
                string query = "delete " + tabla +" "+union+ " where " + campo + " = " + id;
                MessageBox.Show("Este es el delete" + query);
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                    cn.Close();
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
            return false;
        }

        // ***************************************************************************************** \\
        // Esta linea de codigo representa el metodo modificar() el cual nos va a permitir modifiar los
        // datos solicitados de cualquier formulario del sistema 
        // ***************************************************************************************** \\ 

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Revisar consultas SQL para comprobar si tienen vulnerabilidades de seguridad")]
        public bool modificar(string tabla, string union, string id, string compara, string[] campo, string[] valor)
        {
            string datos = "";


            try
            {
                for (int i = 0; i < valor.Length; i++)
                {
                    if (i == 0)
                    {
                        datos += campo[i] + " = '" + valor[i] + "' ";
                    }
                    else
                    {
                        datos += ", " + campo[i] + " = '" + valor[i] + "' ";
                    }
                }
                string query = "update " + tabla +" "+union+ " set " + datos + " where " + compara + " = " + id;
                MessageBox.Show("esTE ES EL QUERY" + query);
                cn = Conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(query, cn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                    cn.Close();
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
            return false;
        }

    }
}

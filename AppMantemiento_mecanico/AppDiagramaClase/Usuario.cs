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
    class Usuario
    {
        private int id_usuario;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        private string nombre_usuario;

        public string Nombre_usuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }
        private string permiso;

        public string Permiso
        {
            get { return permiso; }
            set { permiso = value; }
        }
        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        private string departamento;

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        private DateTime fecha_ingreso;

        public DateTime Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }


        private MySqlConnection cn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader leer = null;
        private DataTable tabla = null;

        public bool ingresar(string[] dato)
        {
            try
            {
                string miquery = "INSERT INTO usuario(nombre_usuario, permiso, clave, departamento, fecha_ingreso, id_imagen) VALUES ('" + dato[0] + "','" + dato[1] + "','" + dato[2] + "','" + dato[3] + "','" + dato[4] + "','" + "(select max(id_imagen)+1 from imagen) ')";
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

        private void nombredecolumnasc()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Id_usuario");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Permiso");
            tabla.Columns.Add("Clave");
            tabla.Columns.Add("Departamento");
            tabla.Columns.Add("Fecha_ingreso");
            tabla.Columns.Add("Imagen");
        }


        public DataTable consultar()
        {
            try
            {
                nombredecolumnasc();
                string miomio = "select iu.id_usuario, iu.nombre_usuario, iu.permiso, iu.clave, iu.departamento, iu.fecha_ingreso, ia.imagen from  imagen ia, usuario iu where ia.id_imagen = iu.id_imagen";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miomio, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_usuario"], leer["nombre_usuario"], leer["permiso"], leer["clave"], leer["departamento"], leer["fecha_ingreso"], leer["imagen"] });
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

        public DataTable filtrar(string filtro)
        {
            try
            {
                nombredecolumnasc();
                string miquery = "SELECT iu.id_usuario, iu.nombre_usuario, iu.permiso, iu.clave, iu.departamento, iu.fecha_ingreso, ia.imagen FROM  imagen ia, usuario iu WHERE iu.nombre_usuario LIKE '" + filtro + "%'";
                cn = conexion.conectar();
                cn.Open();
                cmd = new MySqlCommand(miquery, cn);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    tabla.Rows.Add(new object[] { leer["id_usuario"], leer["nombre_usuario"], leer["permiso"], leer["clave"], leer["departamento"], leer["fecha_ingreso"], leer["imagen"] });
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

        
                public bool eliminar(int id)
        {
            try
            {
                string elimina = "DELETE usuario from usuario INNER JOIN imagen ON imagen.id_imagen = usuario.id_imagen WHERE id_usuario ='" + id + "'";
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
                        string miactualiza = "UPDATE  usuario u INNER JOIN imagen i on i.id_imagen = u.id_imagen SET u.nombre_usuario = '" + dato[1] + "', u.permiso =  '" + dato[2] + "', u.clave = '" + dato[3] + "', u.departamento = '" + dato[4] + "', u.fecha_ingreso = '" + dato[5] +"', u.i.imagen = '" + dato[6] + "' WHERE id_usuario ='" + dato[0] + "'";
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
    }
}

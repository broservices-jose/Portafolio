using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentSender.Clases
{
    public enum TipoEmpleado
    {
        Administrador = 0,
        Normal = 1,
        Mensajero = 2,
        Secretaria = 3,
        Recepcionista = 4
    }

    public static class Validacion
    {
        public static bool EsValido(TextBox tbox)
        {
            if (tbox.TextLength > 0) return true;

            MessageBox.Show("El campo " + tbox.Name.Substring(4) + " es requerido.");
            return false;
        }

        public static bool EsValido(ComboBox combo)
        {
            if (combo.SelectedItem != null) return true;

            MessageBox.Show("El campo " + combo.Name.Substring(5) + " es requerido.");
            return false;
        }


        public static bool ExisteDocumento(TextBox tbox, out Documento documento)
        {
            documento = Sistema.Instancia.Documentos.Where(x => x.Numero == tbox.Text).FirstOrDefault();
            if (documento == null)
            {
                MessageBox.Show("El campo " + tbox.Name.Substring(4) + " es requerido. -> " + tbox.Text); return false;
            }
            return true;
        }

        public static bool ExisteEmpleado(TextBox tbox, out Empleado empleado)
        {
            empleado = Sistema.Instancia.Empleados.Where(x => (x.Nombre + " " + x.Apellido) == tbox.Text).FirstOrDefault();

            if (empleado == null)
            {
                MessageBox.Show("El campo " + tbox.Name.Substring(4) + " contiene un valor incorrecto. -> " + tbox.Text); return false;
            }
            return true;
        }

        public static bool ExisteMensajero(TextBox tbox, out Empleado mensajero)
        {
            mensajero = Sistema.Instancia.Empleados.Where(x => ((x.Nombre + " " + x.Apellido) == tbox.Text) && x.Tipo == TipoEmpleado.Mensajero).FirstOrDefault();

            if (mensajero == null)
            {
                MessageBox.Show("El campo " + tbox.Name.Substring(4) + " contiene un valor incorrecto. -> " + tbox.Text); return false;
            }
            return true;
        }

        public static bool HoraValida(MaskedTextBox tbox, out DateTime hora)
        {
            if (DateTime.TryParse(tbox.Text, out hora))
            {
                return true;
            }

            MessageBox.Show("El campo hora tiene un valor incorrecto");
            return false;
        }

        public static DateTime SumarTiempo(DateTime fecha, DateTime hora)
        {
            return fecha.Date.AddHours(hora.Hour).AddMinutes(hora.Minute);
        }


        public static string GenerarNumeroDocumento()
        {
            string s;
            
            do
            {
                s = new Random().Next(1, 10000000).ToString();
                
                for (int i = s.Length; i < 8; i++)
                {
                    s = "0" + s;
                }
            }
            while (Sistema.Instancia.Documentos.Where(x => x.Numero == s).FirstOrDefault() != null);

            return s;
        }
    }
}
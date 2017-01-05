using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavanderia0._1.Vista;
using Lavanderia0._1.Modelo;

namespace Lavanderia0._1.Modelo
{
   public static class CLAcceder
    {
        public static Empleados_reg emp = new Empleados_reg();

        public static Servicio se = new Servicio();

        public static Usuario us = new Usuario();

        public static Menu m = new Menu();

        public static Pago_Nomina pn = new Pago_Nomina();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiagramaClase
{
   public  class consulta
    {

        public string  iddetalle {get;set;}

        public string idservicio { get; set; }
        public string tipo { get; set; }
        public int cantidad { get; set; }
        public double costo {get; set;}
        public double precio { get; set; }
        public double importe { get; set; }
        public double itbis { get; set; }
        public double neto { get; set; }
        public string mecanico { get; set; }
        public double totales { get; set; }



        public List<consulta> Detail = new List<consulta>();
    
    
    
    }
}

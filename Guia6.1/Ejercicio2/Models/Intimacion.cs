using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Intimacion
    { 
        public DateTime FechaEmision { get; set; }
        public string LugarEmision { get; set; }
        public string PersonaDemandada { get; set; }

        public override string ToString()
        {
            return $@"Fecha Emision: {FechaEmision:dd/MM/yyyy}
";
        }
    }
}

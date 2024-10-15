using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Intimacion
    { 
        public DateTime FechaEmision { get; set; }
        public string LugarEmision { get; set; }
        public string PersonaDemandada { get; set; }
        public string EstudioJuridicoDemandante { get; set; }
        public string PersonaDemandante { get; set; }
        public DateTime FechaHoraEjecucion { get; set; }
        public double MontoAdeudado { get; set; }


        public override string ToString()
        {
            return $@"
Lugar: {LugarEmision}
Fecha Emision: {FechaEmision:dd/MM/yyyy}
Persona demandada: {PersonaDemandada}
Estudio Juridico: {EstudioJuridicoDemandante}
";
        }
    }
}

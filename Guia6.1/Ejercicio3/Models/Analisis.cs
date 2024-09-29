using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Analisis
    { 
        public int CantidadSecuencias { get { return secuenicas.Count; } }

        private List<Secuencia> secuenicas = new List<Secuencia>();
    }
}

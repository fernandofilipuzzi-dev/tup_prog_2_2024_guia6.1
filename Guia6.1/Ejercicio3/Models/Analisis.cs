using System.Collections.Generic;

namespace Ejercicio3.Models
{
    public class Analisis
    { 
        public int CantidadSecuencias { get { return secuenicas.Count; } }

        private List<Secuencia> secuenicas = new List<Secuencia>();
    }
}

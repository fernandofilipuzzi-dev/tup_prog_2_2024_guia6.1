using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Proteina
    {
        public string Secuencia { get; private set; }

        public Proteina(string secuencia)
        {
            Secuencia = secuencia;
        }
    }
}

using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class RegexProcesableImpl : IProcesable
    {
        public Intimacion Procesar(string contenido)
        {
            Intimacion intimacionPago= new Intimacion();

            Match m=Regex.Match(contenido, @"^\s+\w*");
            if (m.Success)
            {
                intimacionPago.LugarEmision = m.Value.Trim();
            }

            m = Regex.Match(contenido, @"(Sr\(a\))([ a-zA-Záéíóú]+)");
            if (m.Groups.Count>1)
            {
                intimacionPago.PersonaDemandada = m.Groups[2].Value;
            }

            return intimacionPago;
        }
    }
}

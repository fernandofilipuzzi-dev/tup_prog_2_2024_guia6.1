using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class StringProcesarImpl:IProcesar
    {
        public string Procesar(string patente, out string formateada)
        {
            formateada = patente.Replace(" ", "").Replace("-", "").ToUpper();

            bool isHasta2016 = formateada.Length >=6;
            for (int n = 0; n < formateada.Length && isHasta2016==true; n++)
            {
                char d=formateada[n];
                isHasta2016 &= (char.IsLetter(d) && n < 3) || (char.IsDigit(d) && n < 6 &&n >= 3);
            }
            
            if (isHasta2016==true)
            {
                return "Automóviles y camionetas hasta 2016";
            }

            bool isDesde2016 = formateada.Length >= 7;
            for (int n = 0; n < formateada.Length && isDesde2016 == true; n++)
            {
                char d = formateada[n];
                isDesde2016 &= (char.IsLetter(d) && n < 2) || (char.IsDigit(d) && n < 5 && n >= 2) || (char.IsLetter(d) && n < 7 && n >= 5);
            }

            if (isDesde2016 == true)
            {
                return "Automóviles y camionetas desde 2016";
            }

            //Procesar los otros casos

            formateada = "";
            return "NN";
        }
    }
}

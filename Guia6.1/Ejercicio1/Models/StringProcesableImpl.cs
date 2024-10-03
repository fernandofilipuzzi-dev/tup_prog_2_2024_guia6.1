using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class StringProcesableImpl:IProcesable
    {
        public string Procesar(string patente, out string formateada)
        {
            string patenteNormalizada = patente.Replace(" ", "").Replace("-", "").ToUpper();

            #region caso patente hasta 2016

            bool isHasta2016 = patenteNormalizada.Length == 6;
            for (int n = 0; n < patenteNormalizada.Length && isHasta2016==true; n++)
            {
                char d= patenteNormalizada[n];
                isHasta2016 &= (char.IsLetter(d) && n < 3) || (char.IsNumber(d) && n < 6 &&n >= 3);
            }
            
            if (isHasta2016==true)
            {
                formateada = patenteNormalizada;
                return "Automóviles y camionetas hasta 2016";
            }
            #endregion

            #region caso patente desde 2016
            bool isDesde2016 = patenteNormalizada.Length == 7;
            for (int n = 0; n < patenteNormalizada.Length && isDesde2016 == true; n++)
            {
                char d = patenteNormalizada[n];
                isDesde2016 &= (char.IsLetter(d) && n < 2) || 
                        (char.IsNumber(d) && n < 5 && n >= 2) || 
                        (char.IsLetter(d) && n < 7 && n >= 5);
            }

            if (isDesde2016 == true)
            {
                formateada= patenteNormalizada;
                return "Automóviles y camionetas desde 2016";
            }
            #endregion

            //Procesar los otros casos

            formateada = "";
            return $"No identificada: {patente}";
        }
    }
}

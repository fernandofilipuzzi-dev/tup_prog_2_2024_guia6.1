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

            #region lugar emisión
            Match m =Regex.Match(contenido, @"^\s+\w*");
            if (m.Success)
            {
                intimacionPago.LugarEmision = m.Value.Trim();
            }
            #endregion

            #region fecha emision
            m = Regex.Match(contenido, @"([0-9]{1,2}) de ([a-zA-Z]+) de ([0-9]{4})");
            if (m.Success && m.Groups.Count==4)
            {
                int dia=Convert.ToInt32(m.Groups[1].Value.Trim());
                string mesString = m.Groups[2].Value.ToUpper().Trim();
                int anio= Convert.ToInt32(m.Groups[3].Value.Trim());

                int mes = 0;
                switch (mesString)
                {
                    case "ENERO": { mes = 1; }break;
                    case "FEBREO": { mes = 2; } break;
                    case "MARZO": { mes = 3; } break;
                    case "ABRIL": { mes = 4; } break;
                    case "MAYO": { mes = 5; } break;
                    case "JUNIO": { mes = 6; } break;
                    case "JULIO": { mes = 7; } break;
                    case "AGOSTO": { mes = 8; } break;
                    case "OCTUBRE": { mes = 9; } break;
                    case "SEPTIEMBRE":
                    case "SETIEMBRE": { mes = 10; } break;
                    case "NOVIEMBRE": { mes = 11; } break;
                    case "DICIEMBRE": { mes = 12; } break;
                }
                intimacionPago.FechaEmision = new DateTime(anio, mes, dia);
            }
            #endregion

            #region persona demandada
            m = Regex.Match(contenido, @"(Sr\(a\))([ a-zA-Záéíóú]+)");
            if (m.Groups.Count>1)
            {
                intimacionPago.PersonaDemandada = m.Groups[2].Value;
            }
            #endregion

            return intimacionPago;
        }
    }
}

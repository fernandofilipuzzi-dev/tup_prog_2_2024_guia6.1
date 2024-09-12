using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class RegexImpl : IProcesar
    {
        public string Procesar(string patente, out string formateada)
        {
            formateada = "";
            Match match=Regex.Match(patente, @"^[A-Z]{3}\s*\d{3}$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                formateada = match.Value;
                return "Automóviles y camionetas hasta 2016";
            }

            return "NN";
        }
    }
}

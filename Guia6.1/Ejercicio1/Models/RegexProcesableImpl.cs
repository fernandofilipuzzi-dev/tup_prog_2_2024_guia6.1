﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class RegexProcesableImpl : IProcesable
    {
        public string Procesar(string patente, out string formateada)
        {
            Match match = null;

            formateada = match.Value.Replace(" ", "").Replace("-", "").ToUpper();

            #region caso patente hasta 2016
            match = Regex.Match(patente, @"^[A-Z]{3}[\s-]*\d{3}$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return "Automóviles y camionetas hasta 2016";
            }
            #endregion

            #region caso patente desde 2016
            match = Regex.Match(patente, @"^[A-Z]{2}\s*\d{3}\s*[A-Z]{2}$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return "Automóviles y camionetas desde 2016";
            }
            #endregion

            #region motocicleta
            match = Regex.Match(patente, @"^\d{2}\s*[A-Z]{3}\s*\d{3}$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return "Motocicleta";
            }
            #endregion

            #region acoplado
            match = Regex.Match(patente, @"^\d{2}\s*[A-Z]{4}\s*$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return "Acoplado";
            }
            #endregion

            return $"No identificada: {patente}";
        }
    }
}

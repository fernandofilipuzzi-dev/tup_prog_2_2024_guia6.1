using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public interface Secuencia
    {
        Intimacion Procesar(string contenido);
    }
}

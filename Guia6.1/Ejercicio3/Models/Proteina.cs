namespace Ejercicio3.Models
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

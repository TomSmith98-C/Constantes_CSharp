using System;

namespace Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;

            //Por lo regular las constantes se ponen en mayusculas para identificarlas mejor.
            //El volumen de un cilindro se da con la formula Volumen = PI * radio^2 * h;

            int h = 23;//Altura del cilindro
            double r = 32.33222;

            Console.WriteLine($"El volumen del cilindro es igual a: {PI * r * r * h}");
        }
    }
}

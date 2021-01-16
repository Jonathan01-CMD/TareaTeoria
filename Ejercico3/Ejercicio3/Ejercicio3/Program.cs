using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Dijite numero:");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("Numero es positivo");
            }
            else
            {
                Console.WriteLine("Numero ees Negativo");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNumeroDos
{
    class EjercicioNumeroDos
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Digite un Número: ");
            N = int.Parse(Console.ReadLine());

            if (N >= 1000)
                Console.Write("El Último digito de la cifra digitada es: " + ((N % 1000) % 100) % 10);

            else if (N >= 100)
                Console.Write("El Último digito de la cifra digitada es: " + (N % 100) % 10);

            else if (N >= 10)
                Console.Write("El Último digito de la cifra digitada es: " + N % 10);

            else
                Console.Write("El Número digitado es de una cifra " + N);

            Console.ReadKey();
        }
    }
}

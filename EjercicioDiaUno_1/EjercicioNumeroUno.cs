using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDiaUno
{
    class EjercicioNumeroUno
    {
        int Resultado = 0;

        static void Main(string[] args)
        {
            EjercicioNumeroUno calculo = new EjercicioNumeroUno();

            System.Console.WriteLine("La Suma es: " + calculo.CalcularResultado(24,40));

            Convert.ToString(calculo, null);

            System.Console.WriteLine("La Multiplicación es: " + calculo.CalcularResultado(24, 40, 2));

            Console.ReadKey();

        }

        public int CalcularResultado(int number1, int number2)
        {
            Resultado = (number1 + number2);
            return Resultado;
        }

        public int CalcularResultado(int number1, int number2, int number3)
        {
            Resultado = (number1 + number2) * number3;
            return Resultado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDiaUno_3
{
    class EjercicioNumeroTres
    {
        static void Main(string[] args)
        {
            double pulgadas;
            double centimetros;

            Console.Write("Ingrese el Valor en centimetros (cm) que desea convertir: ");
            centimetros = Convert.ToDouble(Console.ReadLine());

            pulgadas = centimetros * 0.39370;

            Console.WriteLine("{0} centimetros: {1} pulgadas", centimetros, pulgadas);
            Console.ReadKey();
        }
    }
}

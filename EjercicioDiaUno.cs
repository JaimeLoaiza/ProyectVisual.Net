using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProyect_Visual.Net
{
    class EjercicioDiaUno
    {
        EjercicioDiaUno ejercicioDia;
        public static void Main(string[] args)
        {
            EjercicioDiaUno ejercicioDia = new EjercicioDiaUno();

            ejercicioDia.llamarEjercicioUno();
            ejercicioDia.llamarEjercicioDos();
            ejercicioDia.llamarEjercicioTres();
        }

        public void llamarEjercicioUno()
        {
            string resultado;

            Console.WriteLine("Digite el Primer Número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el Segundo Número: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el Tercer Número: ");
            int numero3 = int.Parse(Console.ReadLine());

            resultado = ejercicioDia.CalcularResultado(numero1, numero2);
            Console.WriteLine("La Suma es: " + resultado);

            resultado = ejercicioDia.CalcularResultado(numero1, numero2, numero3);
            Console.WriteLine("La Multiplicación es: " + resultado);

            Console.ReadKey();
        }

        public void llamarEjercicioDos()
        {
            Console.WriteLine("Digite un Número: ");
            int cifra = int.Parse(Console.ReadLine());

            cifra = ejercicioDia.CalcularUltimoDigito(cifra);

            Console.WriteLine("Su ültimo digito es: " + cifra);

            Console.ReadKey();
        }

        public void llamarEjercicioTres()
        {
            int centimetros;
            double pulgadas;

            Console.WriteLine("Ingrese el Valor en centimetros (cm) que desea convertir: ");
            centimetros = int.Parse(Console.ReadLine());

            pulgadas = ejercicioDia.ConvertirCentimetrosAPulgadas(centimetros);

            Console.WriteLine("{0} centimetros: {1} pulgadas", centimetros, pulgadas);
            Console.ReadKey();
        }

        public string CalcularResultado(int numero1, int numero2)
        {
            int resultado;

            resultado = (numero1 + numero2);

            return resultado.ToString();
        }

        public string CalcularResultado(int numero1, int numero2, int numero3)
        {
            int resultado;

            resultado = (numero1 + numero2) * numero3;

            return resultado.ToString();
        }

        public int CalcularUltimoDigito(int cifra)
        {
            int ultimoDigito;

            ultimoDigito = (cifra % 10);

            return ultimoDigito;
        }

        public double ConvertirCentimetrosAPulgadas(int centimetros)
        {
            double pulgadas = centimetros * 0.39370;
            return pulgadas;
        }
    }
}

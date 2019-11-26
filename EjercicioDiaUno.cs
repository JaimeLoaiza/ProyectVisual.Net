using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProyectVisual.Net
{
    class EjercicioDiaUno
    {
        static void Main(string[] args)
        {
            EjercicioDiaUno clase = new EjercicioDiaUno();
            clase.llamarEjercicioUno();
            clase.llamarEjercicioDos();
            clase.llamarEjercicioTres();
        }

        public void llamarEjercicioUno()
        {
            int resultado;
            int numero1 = 24;
            int numero2 = 40;
            int numero3 = 2;

            resultado = numero1 + numero2;

            Convert.ToString(resultado, null);
            System.Console.WriteLine("La Suma es: " + resultado.ToString());

            resultado = (numero1 + numero2) * numero3;

            if (resultado > 0)
                System.Console.WriteLine("La Multiplicación es: " + resultado.ToString());

            Convert.ToString(resultado, null);
            Console.ReadKey();
        }

        public void llamarEjercicioDos()
        {

            Console.WriteLine("Digite un Número: ");
            int cifra = int.Parse(Console.ReadLine());

            if (cifra < 0)
                Console.WriteLine("El Número digitado es Negativo" + "; " + "Su ültimo digito es: " + (cifra % 10));

            else if (cifra >= 0)
                System.Console.WriteLine("La última cifra del Número digitado es: " + cifra % 10);

            Console.ReadKey();
        }

        public void llamarEjercicioTres()
        {
            double centimetros;
            double pulgadas;

            Console.WriteLine("Ingrese el Valor en centimetros (cm) que desea convertir: ");
            centimetros = Convert.ToDouble(Console.ReadLine());

            pulgadas = centimetros * 0.39370;

            System.Console.WriteLine("{0} centimetros: {1} pulgadas", centimetros, pulgadas);
            Console.ReadKey();
        }

        public string CalcularResultado(int numero1, int numero2)
        {
            int resultado = 0;
            return resultado.ToString();
        }

        public int CalcularResultado(int numero3)
        {
            int resultado = 0;
            return resultado;
        }

        public int CalcularUltimoDigito(int cifra)
        {
            if (cifra < 0)
                Console.Write(cifra % 10);

            else if (cifra >= 1000)
                Console.Write(cifra % 10);

            else if (cifra >= 100)
                Console.Write(cifra % 10);

            else if (cifra >= 10)
                Console.Write(cifra % 10);

            else
                cifra = cifra;

            return cifra;
        }

        public double ConvertirCentimetrosAPulgadas(int centimetros)
        {
            double pulgadas = 0;
            return pulgadas;
        }

    }
}
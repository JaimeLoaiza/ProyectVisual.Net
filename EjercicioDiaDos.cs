using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProyect_Visual.Net
{
    class EjercicioDiaDos
    {
        EjercicioDiaDos ejercicioDia;
        public static void Main(string[] args)
        {
            EjercicioDiaDos ejercicioDia = new EjercicioDiaDos();

            ejercicioDia.llamarEjercicioUno();
            ejercicioDia.llamarEjercicioDos();
            ejercicioDia.llamarEjercicioTres();
        }

        public void llamarEjercicioUno()
        {
            int ladodelcuadrado;
            int areacuadrado;

            Console.WriteLine("Digite un Número para hallar el Área: ");
            ladodelcuadrado = int.Parse(Console.ReadLine());

            EjercicioDiaDos ejercicioDia = new EjercicioDiaDos();

            areacuadrado = ejercicioDia.CalcularAreaCuadrado(ladodelcuadrado);

            Console.WriteLine("El Área del Cuadrado es: " + areacuadrado);
            Console.ReadKey();
        }

        public void llamarEjercicioDos()
        {
            Console.WriteLine("Digite un Número: ");
            int numero = int.Parse(Console.ReadLine());

            EjercicioDiaDos ejercicioDia = new EjercicioDiaDos();

            numero = ejercicioDia.DeterminarNumero(numero);

                Console.WriteLine("Número es Negativo" + (numero < 0));
                Console.WriteLine("Número es Positivo" + (numero >= 0));

            Console.ReadKey();
        }

        public void llamarEjercicioTres()
        {
            Console.WriteLine("Entre un Número");
            int numero = Int32.Parse(Console.ReadLine());

            EjercicioDiaDos ejercicioDia = new EjercicioDiaDos();

            numero = Int32.Parse(ejercicioDia.CalculoDeMultiplos(numero));

            Boolean numeroEsDivisible = false;
            if (numero % 2 == 0)
            {
                Console.WriteLine("Número Divisible por 2");
                numeroEsDivisible = true;
            }
            else if (numero % 3 == 0)
            {
                Console.WriteLine("Número Divisible por 3");
                numeroEsDivisible = true;
            }
            if (numero % 2 == 0 && numero % 3 == 0)
            {
                Console.WriteLine("Número Divisible por ambos");
                numeroEsDivisible = true;
            }
            else if (numero % 1 == 0 || numero % 2 == 0 || numero % 3 == 0)
            {
                Console.WriteLine("Número No Divisible por 2 ó 3");
                numeroEsDivisible = true;
            }
            Console.WriteLine("Enter para Cerrar");
            Console.ReadKey();
        }

        public int CalcularAreaCuadrado(int ladodelcuadrado)
        {
            int areacuadrado;

            areacuadrado = ladodelcuadrado * ladodelcuadrado;
            return areacuadrado;
        }

        public int DeterminarNumero(int numero)
        {
            int determinenumero;

            if (numero < 0);
                determinenumero = numero;

            if (numero >= 0);
                determinenumero = numero;

            return determinenumero;
        }

        public string CalculoDeMultiplos(Int32 numero)
        {
            Boolean numeroEsDivisible = false;
            if (numero % 2 == 0)
            {
                numeroEsDivisible = true;
            }
            else if (numero % 3 == 0)
            {
                numeroEsDivisible = true;
            }
            if (numero % 2 == 0 && numero % 3 == 0)
            {
                numeroEsDivisible = true;
            }
            else if (numero % 1 == 0 || numero % 2 == 0 || numero % 3 == 0)
            {
                numeroEsDivisible = true;
            }
            return numero.ToString();
        }
    }
}

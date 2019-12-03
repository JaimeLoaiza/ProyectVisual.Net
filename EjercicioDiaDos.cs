using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProyect_Visual.Net
{
    class EjercicioDiaDos
    {
        static EjercicioDiaDos ejercicioDia;
        public static void Main(string[] args)
        {
            ejercicioDia = new EjercicioDiaDos();
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
            areacuadrado = ejercicioDia.CalcularAreaCuadrado(ladodelcuadrado);
            Console.WriteLine("El Área del Cuadrado es: " + areacuadrado);
            Console.ReadKey();
        }
        public void llamarEjercicioDos()
        {
            int numero;
            string determinenumero;
            Console.WriteLine("Digite un Número para hallar su Estado: ");
            numero = int.Parse(Console.ReadLine());
            determinenumero = ejercicioDia.DeterminarNumero(numero);
            Console.WriteLine("El Número Digitado es: " + determinenumero);
            Console.WriteLine("El Número Digitado es: " + determinenumero);
            Console.ReadKey();
        }
        public void llamarEjercicioTres()
        {
            string numerodivisible;
            Console.WriteLine("Entre un Número");
            int multiplo = int.Parse(Console.ReadLine());
            numerodivisible = ejercicioDia.CalculoDeMultiplos(multiplo);
                Console.WriteLine(numerodivisible);
                Console.WriteLine(numerodivisible);
                Console.WriteLine(numerodivisible);
                Console.WriteLine(numerodivisible);
            Console.WriteLine("Enter para Cerrar");
            Console.ReadKey();
        }
        public int CalcularAreaCuadrado(int ladodelcuadrado)
        {
            int areacuadrado;
            areacuadrado = ladodelcuadrado * ladodelcuadrado;
            return areacuadrado;
        }
        public string DeterminarNumero(int numero) 
        {
            int determinenumero;
            if (numero >= 0)
            {
                determinenumero = numero;
            }
            else
            {
                determinenumero = numero;
            }
            return numero.ToString();
        }
        public string CalculoDeMultiplos(int multiplo)
        {
            int numerodivisible;
            if (multiplo % 2 == 0 && multiplo % 3 == 0)
            {
                multiplo = 2 & 3;
            }
            if (multiplo % 3 == 0)
            {
                multiplo = 3;
            }
            if (multiplo % 2 == 0)
            {
                multiplo = 2;
            }
            else if (multiplo % 1 == 0 || multiplo % 2 == 0 || multiplo % 3 == 0)
            {
                multiplo = 1 | 2 | 3;
            }
            return multiplo.ToString();
        }
    }
}

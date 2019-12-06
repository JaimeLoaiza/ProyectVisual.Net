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
            string determinenumero;
            Console.WriteLine("Digite un Número para hallar su Estado: ");
            int numero = int.Parse(Console.ReadLine());
            determinenumero = ejercicioDia.DeterminarNumero(numero);
            Console.WriteLine("El Número Digitado es: " + determinenumero);
            Console.ReadKey();
        }
        public void llamarEjercicioTres()
        {
            string numerodivisible;
            Console.WriteLine("Entre el Número: ");
            int multiplo = Int32.Parse(Console.ReadLine());
            numerodivisible = ejercicioDia.CalculoDeMultiplos(multiplo);
            Console.WriteLine("El Número " + multiplo + numerodivisible);
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
            if (numero > 0)
            {
                return "positivo";
            }
            else
            {
                return "negativo";
            }
            return numero.ToString();
        }
        public string CalculoDeMultiplos(int multiplo)
        {
            string numerodivisible;
            if (multiplo % 2 == 0 && multiplo % 3 == 0)
            {
                return " es divisible por ambos";
            }
            else if (multiplo % 3 == 0)
            {
                return " es divisible por 3";
            }
            else if (multiplo % 2 == 0)
            {
                return " es divisible por 2";
            }
            else
            {
                return " No es divisible por 2 o 3";
            }
            return multiplo.ToString();
        }
    }
}

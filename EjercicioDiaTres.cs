using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProyect_Visual.Net
{
    public class EjercicioDiaTres
    {
        public static EjercicioDiaTres ejercicioDia;
        public static void Main(string[] args)
        {
            ejercicioDia = new EjercicioDiaTres();
            ejercicioDia.llamarEjercicioUno();
            ejercicioDia.llamarEjercicioDos();
            ejercicioDia.llamarEjercicioTres();
        }
        public void llamarEjercicioUno()
        {
            int resultado;
            Console.WriteLine("Ingresa el Primer número: ");
            int numeroUno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el Segundo número: ");
            int numeroDos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el Tercer número: ");
            int numeroTres = int.Parse(Console.ReadLine());
            resultado = ejercicioDia.CalcularNumeroMayor(numeroUno, numeroDos, numeroTres);
            Console.WriteLine("El Número Mayor de ellos es: " + resultado);
            Console.ReadKey();
        }
        public void llamarEjercicioDos()
        {
            string nombreDelMes;
            Console.WriteLine("Digita un número del 1 al 12: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            nombreDelMes = ejercicioDia.DeterminarElMes(numero);
            Console.WriteLine("El Número Digitado " + numero + " corresponde al Mes de: " + nombreDelMes);
            Console.ReadKey();
        }
        public void llamarEjercicioTres()
        {
            string numerosImpares;
            Console.WriteLine("Ingrese un Número Positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            numerosImpares = ejercicioDia.MostrarNumerosImpares(numero);
            Console.WriteLine("El Orden descendente al número " + numero + " es: " + numerosImpares);
            Console.ReadKey();
        }
        public int CalcularNumeroMayor(int numeroUno, int numeroDos, int numeroTres)
        {
            int resultado;
            if (numeroUno >= numeroDos && numeroUno > numeroTres)
            {
                resultado = numeroUno;
            }
            else if (numeroDos >= numeroUno && numeroDos > numeroTres)
            {
                resultado = numeroDos;
            }
            else
            {
                resultado = numeroTres;
            }
            return resultado;
        }
        public string DeterminarElMes(int numero)
        {
            switch(numero)
            {
                case 1:
                    return ("Enero");
                case 2:
                    return ("Febrero");
                case 3:
                    return ("Marzo");
                case 4:
                    return ("Abril");
                case 5:
                    return ("Mayo");
                case 6:
                    return ("Junio");
                case 7:
                    return ("Julio");
                case 8:
                    return ("Agosto");
                case 9:
                    return ("Septiembre");
                case 10:
                    return ("Octubre");
                case 11:
                    return ("Noviembre");
                case 12:
                    return ("Diciembre");
                default:
                    return ("Número No perteneciente al Calendario");
            }
        }
        public string MostrarNumerosImpares(int numero)
        {
            string numerosImpares = "";
            for (int i = numero; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    numerosImpares += (i.ToString() + ", ");
                }
            }
            return numerosImpares;
        }
    }
}

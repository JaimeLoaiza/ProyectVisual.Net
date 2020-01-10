using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EjerciciosProyecto_Visual.Net
{
    public class EjercicioDiaCuatro
    {
        public static EjercicioDiaCuatro ejercicioDia;

        public static void Main(string[] args)
        {
            ejercicioDia = new EjercicioDiaCuatro();
            ejercicioDia.llamarEjercicioUno();
            ejercicioDia.llamarEjercicioDos();
            ejercicioDia.llamarEjercicioTres();
            ejercicioDia.llamarEjercicioCuatro();
        }
        public void llamarEjercicioUno()
        {
            string i = null;
            Console.WriteLine("Digite Nota:" + i);
            double nota = Convert.ToDouble(Console.ReadLine());
            double PromedioDefinitivo = ejercicioDia.PromedioAcademico(nota);
            Console.WriteLine("El Promedio Definitivo es: " + PromedioDefinitivo);
            Console.ReadKey();
        }
        public void llamarEjercicioDos()
        {
            int sumaTotal;
            Console.WriteLine("Ingrese un Número Positivo: ");
            int numero = int.Parse(Console.ReadLine());
            sumaTotal = ejercicioDia.SumaTotalDeImpares(numero);
            Console.WriteLine("La Suma Total de los Números impares del número " + numero + ", " + " desde 0 es: " + sumaTotal);
            Console.ReadKey();
        }
        public void llamarEjercicioTres()
        {
            string fecha;
            Console.WriteLine("Digite un Número de 0 a 365: ");
            int numero = Int32.Parse(Console.ReadLine());
            fecha = ejercicioDia.CalculoDeFecha(numero);
            Console.WriteLine("El Número Ingresado, corresponde al: " + fecha);
            Console.ReadKey();
        }
        public void llamarEjercicioCuatro()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("¿Desea Ingresar un nuevo número o no?");
            int numero = Int32.Parse(Console.ReadLine());
            numeros = ejercicioDia.ListaDeEnteros(numero);
            Console.WriteLine("La Colección de Números es: " + numeros);
        }
        public double PromedioAcademico(double nota)
        {
            double suma = 0;
            for (int i = 1; i <= 3; i++)
            {
                suma = suma + nota;
                if (nota < 5.0)
                {
                    MessageBox.Show("el numero ingresado es inválido, intente nuevamente");
                }
            }
            double PromedioDefinitivo;
            PromedioDefinitivo = suma / 3;
            return PromedioDefinitivo;
        }
        public int SumaTotalDeImpares(int numero)
        {
            int sumaTotal;
            int suma = 0;
            int impares = 0;
            for (int i = 0; i <= numero; i++)
            {
                if (numero > 0 && i % 2 != 0)
                {
                    suma = (i);
                }
            }
            return numero;
        }
        public string CalculoDeFecha(int numero)
        {
            DateTime fecha = DateTime.Now;
            string mes = numero.ToString("MMMM");
            string dia = numero.ToString("dddd");
            return fecha.ToString();
        }
        public List<int> ListaDeEnteros(int numero)
        {
            List<int> numeros = new List<int>();
            while (numero != 0)
            {
                numero = Int32.Parse(Console.ReadLine());
                numeros.Add(numero);
            }
            Console.WriteLine("¿Desea Ingresar un nuevo número o no? (0 para mostrar la lista?");
            foreach(int digitonumerico in numeros)
            {
                Console.WriteLine(digitonumerico);
            }
            return numeros;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProyect_Visual.Net
{
    class EjercicioDiaTres
    {
        static EjercicioDiaTres ejercicioDia;
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
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el Segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el Tercer número: ");
            int numero3 = int.Parse(Console.ReadLine());
            resultado = ejercicioDia.CalcularNumeroMayor(numero1, numero2, numero3);
            Console.WriteLine("El Número Mayor de ellos es: " + resultado);
            Console.ReadKey();
        }
        public void llamarEjercicioDos()
        {
            string nombredelmes;
            Console.WriteLine("Digita un número del 1 al 12: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            nombredelmes = ejercicioDia.DeterminarElMes(numero);
            Console.WriteLine("El Número Digitado " + numero + " corresponde al Mes de: " + nombredelmes);
            Console.ReadKey();
        }
        public void llamarEjercicioTres()
        {
            string numerosimpares;
            Console.WriteLine("Ingrese un Número Positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            numerosimpares = ejercicioDia.MostrarNumerosImpares(numero);
            Console.WriteLine("El Orden descendente al número " + numero + " es: " + numerosimpares);
            Console.ReadKey();
        }
        public int CalcularNumeroMayor(int numero1, int numero2, int numero3)
        {
            int resultado;
            if (numero1 >= numero2 && numero1 > numero3)
            {
                resultado = numero1;
            }
            else if (numero2 >= numero1 && numero2 > numero3)
            {
                resultado = numero2;
            }
            else
            {
                resultado = numero3;
            }
            return resultado;
        }
        public string DeterminarElMes(int numero)
        {
            if (numero == 1)
            {
                return "Enero";
            }
            else
            {
                if (numero == 2)
                {
                    return "Febrero";
                }
                else
                {
                    if (numero == 3)
                    {
                        return "Marzo";
                    }
                    else
                    {
                        if (numero == 4)
                        {
                            return "Abril";
                        }
                        else
                        {
                            if (numero == 5)
                            {
                                return "Mayo";
                            }
                            else
                            {
                                if (numero == 6)
                                {
                                    return "Junio";
                                }
                                else
                                {
                                    if (numero == 7)
                                    {
                                        return "Julio";
                                    }
                                    else
                                    {
                                        if (numero == 8)
                                        {
                                            return "Agosto";
                                        }
                                        else
                                        {
                                            if (numero == 9)
                                            {
                                                return "Septiembre";
                                            }
                                            else
                                            {
                                                if (numero == 10)
                                                {
                                                    return "Octubre";
                                                }
                                                else
                                                {
                                                    if (numero == 11)
                                                    {
                                                        return "Noviembre";
                                                    }
                                                    else
                                                    {
                                                        if (numero == 12)
                                                        {
                                                            return "Diciembre";
                                                        }
                                                        else
                                                        {
                                                            return "Número No perteneciente al Calendario";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public string MostrarNumerosImpares(int numero)
        {
            string numerosimpares = "";
            for (int i = numero; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                   numerosimpares += (i.ToString() + ", ");
                }
            }
            return numerosimpares;
        }
    }
}

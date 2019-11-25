using System;

public class Class1
{
	public Class1()
	{
        int Resultado = 0;

        static void Main(string[] args)
        {
            EjercicioNumeroUno calculo = new EjercicioNumeroUno();

            System.Console.WriteLine("La Suma es: " + calculo.CalcularResultado(24, 40));

            Convert.ToString(calculo, null);

            System.Console.WriteLine("La Multiplicación es: " + calculo.CalcularResultado(24, 40, 2));

            Console.ReadKey();
        }

        int CalcularResultado(int number1, int number2)
        {
            Resultado = (number1 + number2);
            return Resultado;
        }

        int CalcularResultado(int number1, int number2, int number3)
        {
            Resultado = (number1 + number2) * number3;
            return Resultado;
        }
    }

    public Class2()
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Digite un Número: ");
            N = int.Parse(Console.ReadLine());

            if (N >= 1000)
                Console.Write("El Último digito de la cifra digitada es: " + ((N % 1000) % 100) % 10);

            else if (N >= 100)
                Console.Write("El Último digito de la cifra digitada es: " + (N % 100) % 10);

            else if (N >= 10)
                Console.Write("El Último digito de la cifra digitada es: " + N % 10);

            else
                Console.Write("El Número digitado es de una cifra " + N);

            Console.ReadKey();
        }
    }

    public Class3()
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

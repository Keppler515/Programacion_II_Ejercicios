using System;
using LogicaDeCalculo;

namespace Vista
{
    internal class Program
    {
        public static string numeroString;
        public static int numero;
        public static int maximo;
        public static int minimo;
        public static int contador = 0;
        public static int acumulador = 0;
        public static float promedio;
        public static int flagMinimo = 0;
        public static int flagMaximo = 0;
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un número");
                    numeroString = Console.ReadLine();

                } while (!int.TryParse(numeroString, out numero));

                if(Validador.Validar(numero, -100, 100))
                {
                    contador++;
                    acumulador = acumulador + numero;

                    if(flagMaximo == 0 && flagMinimo == 0)
                    {
                        flagMinimo = 1;
                        flagMaximo = 1;
                        minimo = numero;
                        maximo = numero;
                    } else
                    {
                        if (numero < minimo) { minimo = numero; }
                        if (numero > maximo) { maximo = numero; }
                    }
                }
            }

            promedio = acumulador / contador;

            Console.WriteLine($"El total sumado es: {acumulador}");
            Console.WriteLine($"El promedio es: {promedio}");
            Console.WriteLine($"El minimo es: {minimo}");
            Console.WriteLine($"El maximo es: {maximo}");
        }
    }
}

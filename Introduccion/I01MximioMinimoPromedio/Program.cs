using System;

namespace I01MaximioMinimoPromedio
{
    internal class Program
    {
        public static string stringNumero;
        public static int numero;
        public static int maximo;
        public static int minimo;
        public static int acumulador = 0;
        public static float promedio;

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}-Ingrese un número: ");
                stringNumero = Console.ReadLine();
                int.TryParse(stringNumero, out numero);

                if (i == 0)
                {
                    minimo = numero;
                    maximo = numero;
                }
                else if (numero > maximo)
                {
                    maximo = numero;
                }
                else if (numero < minimo)
                {
                    minimo = numero;
                }

                acumulador += numero;
                promedio = acumulador / 5;
            }

            Console.WriteLine($"El máximo es: {maximo}");
            Console.WriteLine($"El mínimo es: {minimo}");
            Console.WriteLine($"El total es: {acumulador}");
            Console.WriteLine($"El promedio es: {promedio}");


        }
    }
}

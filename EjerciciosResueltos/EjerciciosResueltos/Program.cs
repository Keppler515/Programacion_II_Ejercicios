using System;

namespace Ejercicio01

{
    internal class Program
    {
        static void Main(string[] args)
        {

            int acumulador = 0;
            int numero;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            float promedio = 0f;
            string numeroIngresado;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Numero {i + 1}:");
                numeroIngresado = Console.ReadLine();
                int.TryParse(numeroIngresado, out numero);

                if (i == 0)
                {
                    numeroMaximo = numero;
                    numeroMinimo = numero;
                }

                if (numero < numeroMinimo)
                {
                    numeroMinimo = numero;
                }

                if (numero > numeroMaximo)
                {
                    numeroMaximo = numero;
                }

                acumulador += numero;
            }

            promedio = acumulador / 5;

            Console.WriteLine($"El minimo es: {numeroMinimo}");
            Console.WriteLine($"El maximo es: {numeroMaximo}");
            Console.WriteLine($"El promedio es: {promedio}");

        }
    }
}

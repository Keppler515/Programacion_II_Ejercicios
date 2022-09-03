using System;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string stringNumeroIngresado;
            int numeroIngresado;
            int acumuladorJ = 0;
            int acumuladorK = 0;
            bool flag = true;

            Console.WriteLine("Ingresa un número");
            stringNumeroIngresado = Console.ReadLine();

            int.TryParse(stringNumeroIngresado, out numeroIngresado);

            for (int i = 1; i < numeroIngresado; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    acumuladorJ += j;
                }

                for (int k = numeroIngresado; k > i; k--)
                {
                    acumuladorK += k;
                }

                if (acumuladorJ == acumuladorK)
                {
                    Console.WriteLine($"El centro es {i}");
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
                acumuladorJ = 0;
                acumuladorK = 0;
                
            }

            if (flag == false)
            {
                Console.WriteLine($"{numeroIngresado} no tiene centro numérico");
            }
        }
    }
}

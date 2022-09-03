using System;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroIngrersado;
            int contador = 0;

            Console.Write("Numero: ");

            numeroIngrersado = Console.ReadLine();
            int.TryParse(numeroIngrersado, out numero);

            for (int i = 1; i < numero; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        contador += i;
                    }
                }

                if (contador == i)
                {
                    Console.WriteLine(i);
                }
                contador = 0;
            }
        }
    }
}

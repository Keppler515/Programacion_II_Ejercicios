using System;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 10000;
            int acumuladorJ = 0;

            for (int i = 1; i < numero; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i%j == 0)
                    {
                        acumuladorJ+=j;
                    }

                }
                
                if (acumuladorJ==i)
                {
                    Console.WriteLine(i);
                }

                acumuladorJ = 0;
            }
        }
    }
}

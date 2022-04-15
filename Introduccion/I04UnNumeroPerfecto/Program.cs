using System;

namespace I04UnNumeroPerfecto
{
    internal class Program
    {
        public static int acumulador = 0;

        static void Main(string[] args)
        {

            for (int i = 2; i < 10000; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        acumulador += j;

                    }

                }
                
                if (acumulador == i)
                {
                    Console.WriteLine(acumulador);
                }
                    acumulador = 0;
            }


        }
    }
}

using System;
using LogicaDePrimos;

namespace VistaPrimos
{
    internal class Program
    {
        public static string numeroString;
        public static int numero;

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número");
            numeroString = Console.ReadLine();
            int.TryParse(numeroString, out numero);

            if (CalculadorDePrimos.EsPrimo(numero))
            {
                Console.WriteLine($"{numero} es primo");
            }
            else
            {
                Console.WriteLine($"{numero} NO es primo");
            }
        }
        /*
                static void Main(string[] args)
                {
                    for (int i = 1; i < numero; i++)
                    {
                        if (CalculadorDePrimos.EsPrimo(i))
                        {
                            Console.WriteLine($"{i} es primo");
                        }
                        else
                        {
                            Console.WriteLine($"{i} NO es primo");
                        }
                    }
                }
        */

        /*        static void Main(string[] args)
                {
                    while (numero < 100)
                    {
                        if (CalculadorDePrimos.EsPrimo(numero))
                        {
                            Console.WriteLine($"{numero} es primo");
                        }
                        else
                        {
                            Console.WriteLine($"{numero} NO es primo");
                        }
                        numero++;
                    }

                }
        */
    }
}

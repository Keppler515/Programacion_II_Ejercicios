using System;
using LogicaBisiestos;

namespace VistaBisiestos
{
    internal class Program
    {
        public static string stringInicio;
        public static int inicio;
        public static string stringFinal;
        public static int final;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año de inicio");
            stringInicio = Console.ReadLine();
            int.TryParse(stringInicio, out inicio);

            Console.WriteLine("Ingrese un año de finalización");
            stringFinal = Console.ReadLine();
            int.TryParse(stringFinal, out final);

            if (inicio < final)
            {
                Console.WriteLine("Los siguientes años son bisiestos:");
                
                for (int i = inicio; i < final; i++)
                {
                    if (CalcularBisiestos.EsBisiesto(i))
                    {
                        Console.WriteLine($"{i}");
                    }
                }
            }
        }
    }
}

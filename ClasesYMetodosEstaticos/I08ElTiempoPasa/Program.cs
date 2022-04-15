using System;
using I08Biblioteca;

namespace I08ElTiempoPasa
{
    internal class Program
    {
        public static string day;
        public static string month;
        public static string year;
        public static double resultado;
        static void Main(string[] args)
        {
            Console.Write("Ingrese un día: ");
            day = Console.ReadLine();
            Console.Write("Ingrese un mes: ");
            month = Console.ReadLine();
            Console.Write("Ingrese un año: ");
            year = Console.ReadLine();

            resultado = CalculadorDeDias.CalcularDias(day, month, year);

            Console.WriteLine($"Pasaron {resultado} días desde el {day}/{month}/{year}");
        }
    }
}

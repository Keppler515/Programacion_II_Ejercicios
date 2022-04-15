using System;
using LogicaDias;

namespace ConsolaFechas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day;
            string month;
            string year;
            
            Console.Write("Ingrese dia: ");
            day = Console.ReadLine();
            Console.Write("Ingrese mes: ");
            month = Console.ReadLine();
            Console.Write("Ingrese año: ");
            year = Console.ReadLine();

            Console.WriteLine($"Pasaron {CantidadDeDias.CalcularDias(day, month, year)} dias desde el {day} de {month} de {year}");

        }
    }
}

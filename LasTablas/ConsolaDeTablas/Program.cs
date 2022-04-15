using System;
using LogicaDeTablas;

namespace ConsolaDeTablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringNumero;
            int numero;

            Console.Write("Ingrese un número: ");
            stringNumero = Console.ReadLine();
            int.TryParse(stringNumero, out numero);

            Tablas.CalcularTablas(numero);
        }
    }
}

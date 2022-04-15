using System;
using LogicaFactorial;

namespace ConsolaFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringNumero;
            int numero;

            Console.Write("Ingrese un número positivo: ");
            stringNumero = Console.ReadLine();
            int.TryParse(stringNumero, out numero);

            Console.WriteLine($"El factorial de {numero} es: {Factorial.CalcularFactorial(numero)}");
        }
    }
}

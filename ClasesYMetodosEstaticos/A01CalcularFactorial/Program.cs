using System;
using A01Biblioteca;

namespace A01CalcularFactorial
{
    internal class Program
    {
        public static double resultado;
        public static string numero;

        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            numero = Console.ReadLine();
            resultado = CalculadorFactorial.CalcularFactorial(numero);
            Console.WriteLine($"El factorial de {numero} es {resultado}");

        }
    }
}

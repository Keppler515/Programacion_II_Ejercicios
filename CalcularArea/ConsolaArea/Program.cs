using System;
using LogicaArea;

namespace ConsolaArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringNumero;
            string stringNumero2;
            double numero;
            double numero2;

            Console.WriteLine("Ingrese longitud del lado del cuadrado");
            stringNumero = Console.ReadLine();
            double.TryParse(stringNumero, out numero);

            Console.WriteLine($"El área del cuadrado es: {CalculadoraDeArea.CalcularAreaCuadrado(numero)}");


            Console.WriteLine("Ingrese la base del triángulo");
            stringNumero = Console.ReadLine();
            double.TryParse(stringNumero, out numero);

            Console.WriteLine("Ingrese la altura del triángulo");
            stringNumero2 = Console.ReadLine();
            double.TryParse(stringNumero2, out numero2);

            Console.WriteLine($"El área del triángulo es: {CalculadoraDeArea.CalcularAreaTriangulo(numero, numero2)}");


            Console.WriteLine("Ingrese el radio del círculo");
            stringNumero = Console.ReadLine();
            double.TryParse(stringNumero, out numero);
            Console.WriteLine($"El área del círculo es: {CalculadoraDeArea.CalcularAreaCirculo(8)}");

        }
    }
}

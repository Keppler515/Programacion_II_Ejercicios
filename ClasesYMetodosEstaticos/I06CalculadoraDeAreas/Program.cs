using System;
using I06Biblioteca;

namespace I06CalculadoraDeAreas
{
    internal class Program
    {

        public static string stringLado;
        public static string stringBase;
        public static string stringAltura;
        public static string stringRadio;

        public static double lado;
        public static double bBase;
        public static double altura;
        public static double radio;


        static void Main(string[] args)
        {
            Console.Write("Ingrese lado del cuadrado: ");
            stringLado = Console.ReadLine();
            double.TryParse(stringLado, out lado);
            Console.WriteLine($"El area del cuadrado es {CalculadoraDeArea.CalcularAreaCuadrado(lado)}");

            Console.Write("Ingrese base del triangulo: ");
            stringBase = Console.ReadLine();
            double.TryParse(stringBase, out bBase);
            Console.Write("Ingrese altura del triangulo: ");
            stringAltura = Console.ReadLine();
            double.TryParse(stringAltura, out altura);
            Console.WriteLine($"El area del triángulo es {CalculadoraDeArea.CalcularAreaTriangulo(bBase, altura)}");

            Console.Write("Ingrese radio del circulo: ");
            stringRadio = Console.ReadLine();
            double.TryParse(stringRadio, out radio);
            Console.WriteLine($"El area del círculo es {CalculadoraDeArea.CalcularAreaCirculo(radio)}");

        }
    }
}

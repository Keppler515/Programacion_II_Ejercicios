using System;
using LogicaDePotencia;

namespace Vista
{
    internal class VistaDePotencia
    {
        public static string numeroString;
        public static double numero;
        public static double cuadrado;
        public static double cubo;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingrese un número mayor que 0");
                numeroString = Console.ReadLine();
                numero = double.Parse(numeroString);

                if(numero <= 0) Console.WriteLine("Error!");

            } while (numero <= 0);

            if (numero > 0)
            {
                cuadrado = CalculadorDePotencia.CalcularPotencia(numero, 2);
                cubo = CalculadorDePotencia.CalcularPotencia(numero, 3);

                Console.WriteLine($"El cuadrado de {numero} es {cuadrado}");
                Console.WriteLine($"El cubo de {numero} es {cubo}");
            }
        }
    }
}

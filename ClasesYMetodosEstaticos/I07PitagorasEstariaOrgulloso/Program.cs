using System;
using I07Biblioteca;

namespace I07PitagorasEstariaOrgulloso
{
    internal class Program
    {
        public static string stringBase;
        public static string stringAltura;
        public static double bBase;
        public static double altura;

        static void Main(string[] args)
        {
            Console.Write("Ingrese base: ");
            stringBase = Console.ReadLine();
            Console.Write("Ingrese altura: ");
            stringAltura = Console.ReadLine();
            double.TryParse(stringAltura, out altura);
            double.TryParse(stringBase, out bBase);

            Console.WriteLine($"El valor de la hipotenusa es {CalculadorHipotenusa.CalcularHipotenusa(bBase,altura)}");

        }
    }
}

using System;

namespace I08TrianguloRectangulo
{
    internal class Program
    {

        public static string stringNumero;
        public static int numero;
        public static string asterisco = "*";

        static void Main(string[] args)
        {

            Console.Write("Ingrese altura: ");
            stringNumero = Console.ReadLine();
            int.TryParse(stringNumero, out numero);

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(asterisco);
                asterisco = asterisco + "**";
                
            }

        }
    }
}

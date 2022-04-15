using System;

namespace I09TrianguloEquilatero
{
    internal class Program
    {

        public static string stringNumero;
        public static int numero;
        public static string asterisco = "*";
        public static string espacio = " ";

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


//NO PUEDE RESOLVER LO DE LA TABULACION
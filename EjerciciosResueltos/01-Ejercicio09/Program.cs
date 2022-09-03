using System;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringAltura;
            int altura;

            Console.Write("Ingrese la altura: ");
            stringAltura = Console.ReadLine();
            int.TryParse(stringAltura, out altura);

            for (int i = 0; i <= altura; i++)
            {
                for (int j = altura - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("**");
                }
                Console.WriteLine("*");
            }
        }
    }
}

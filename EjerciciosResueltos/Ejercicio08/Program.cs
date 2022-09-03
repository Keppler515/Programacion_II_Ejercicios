using System;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringNumero;
            int numero;

            string dot = "*";

            Console.Write("Ingrese la altura: ");
            stringNumero = Console.ReadLine();
            int.TryParse(stringNumero, out numero);

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(dot);
                dot = dot + "*";
            }
        }
    }
}

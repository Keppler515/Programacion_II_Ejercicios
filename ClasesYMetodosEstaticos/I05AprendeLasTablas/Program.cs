using System;
using I05Biblioteca;

namespace I05AprendeLasTablas
{
    internal class Program
    {

        public static string stringNumero;
        public static int numero;


        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            stringNumero = Console.ReadLine();
            int.TryParse(stringNumero, out numero);

            Console.WriteLine(CreadorDeTablas.CrearTablas(numero));
        }
    }
}

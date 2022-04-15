using System;
using I03Biblioteca;
namespace I03ConversorBinario
{
    internal class Program
    {
        public static string stringNumero;
        public static int numero;

        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero: ");
            stringNumero = Console.ReadLine();
            int.TryParse(stringNumero, out numero);

            Console.Write(Conversor.ConvertirDecimalABinario(numero));
            //Console.Write(Conversor.ConvertirBinarioADecimal(numero));

           

        }
    }
}



using System;
using Entidades;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operando test = new Operando(40);

            Console.WriteLine(test.BinarioDecimal("11010010"));

            Console.WriteLine(test.DecimalBinario("515"));
            Console.WriteLine(test.DecimalBinario(515));


        }
    }
}

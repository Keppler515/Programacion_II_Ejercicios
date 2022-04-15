using System;
using Biblioteca;

namespace Consola
{
     internal class Class1
    {
        static void Main(string [] args)
        {
            Tiempo tiempo1 = new Tiempo(21, 35, 40);
            Tiempo tiempo2 = new Tiempo(19, 44);
            Tiempo tiempo3 = new Tiempo(20);

            Console.WriteLine(tiempo1);

        }
    }
}

using System;
using Biblioteca;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringOperando1;
            string stringOperando2;
            int operando1;
            int operando2;
            string operacion;
            string opcion;

            do
            { 
                Console.Write("Ingrese el primer operando: ");
                stringOperando1 = Console.ReadLine();
                int.TryParse(stringOperando1, out operando1);

                Console.Write("Ingrese el segundo operando: ");
                stringOperando2 = Console.ReadLine();
                int.TryParse(stringOperando2 , out operando2);

                Console.Write("Ingrese la operación (+, -, *, /): ");
                operacion = Console.ReadLine();

                Console.WriteLine(Calculadora.Calcular(operando1,operando2,operacion));

                Console.Write("Desea continuar? s/n: ");
                opcion = Console.ReadLine();

            } while (opcion == "s");
        }
    }
}

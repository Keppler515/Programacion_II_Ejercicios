using System;
using I04Biblioteca;

namespace I04LaCalculadora
{
    internal class Program
    {
        public static string stringOperando1;
        public static string stringOperando2;
        public static string operacion;
        public static int operando1;
        public static int operando2;
        public static string continuar;


        static void Main(string[] args)
        {
            do
            {
                Console.Write("Ingrese el primer operando: ");
                stringOperando1 = Console.ReadLine();
                int.TryParse(stringOperando1, out operando1);

                Console.Write("Ingrese el segundo operando: ");
                stringOperando2 = Console.ReadLine();
                int.TryParse(stringOperando2, out operando2);

                Console.Write("Ingrese la operacion (+ - * /): ");
                operacion = Console.ReadLine();

                Console.WriteLine($"El resultado es {Calculadora.Calcular(operando1, operando2, operacion)}");

                Console.WriteLine("Desea continuar?\ns/n: ");
                continuar = Console.ReadLine();

            } while (continuar == "s");

        }
    }
}

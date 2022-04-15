using System;

namespace I02ErrorAlCubo
{
    internal class Program
    {

        public static int numero;
        public static string stringNumero;

        static void Main(string[] args)
        {
            do
            {
                Console.Write("Ingrese un número: ");
                stringNumero = Console.ReadLine();
                int.TryParse(stringNumero, out numero);

                if (numero > 0)
                {
                    Console.WriteLine($"El cuadrado de {numero} es {Math.Pow(numero, 2)}\nEl cubo de {numero} es {Math.Pow(numero, 3)}");
                }
                else
                {
                    Console.WriteLine("¡Error!\nIngrese un número válido");
                }
            } while (numero <= 0);

        }
    }
}

using System;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numero;
            double cuadrado;
            double cubo;

            Console.WriteLine("Numero:");
            numeroIngresado = Console.ReadLine();
            int.TryParse(numeroIngresado, out numero);
            if (numero > 0)
            {
                cuadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);

                Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");
                Console.WriteLine($"El cubo de {numero} es: {cubo}");
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

        }
    }
}

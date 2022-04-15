using System;
using I02Biblioteca;

namespace I02DeseaContinuar
{
    internal class Program
    {
        public static string stringNumero;
        public static int numero;
        public static int acumulador = 0;
        public static string respuesta;

        static void Main(string[] args)
        {

            do
            {
                Console.Write("Ingrese un número: ");
                stringNumero = Console.ReadLine();
                int.TryParse(stringNumero, out numero);

                acumulador = acumulador + numero;

                Console.WriteLine("Dsesea continuar?\n's/n'");
                respuesta = Console.ReadLine();

            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine($"El total sumado es {acumulador}");
        }
    }
}

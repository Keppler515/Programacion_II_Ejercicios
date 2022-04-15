using System;

namespace VistaDeseaContinuar
{
    internal class Program
    {
        public static string respuesta;
        public static string stringNumero;
        public static int numero;
        public static int acumulador = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingrese un número");
                stringNumero = Console.ReadLine();
              if(int.TryParse(stringNumero, out numero))
                {
                    acumulador = acumulador + numero;
                    Console.WriteLine(acumulador);
                }

                Console.WriteLine("Desea continuar? s/n");
                respuesta = Console.ReadLine();
            } while (respuesta == "s");
        }
    }
}

using System;
using BibliotecaDeClases;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringNumeroIngresado,
                    respuesta;
            int totalIngresado = 0;

            do
            {
                Console.Write("Ingrese un numero: ");
                if (int.TryParse(stringNumeroIngresado = Console.ReadLine(), out int numeroIngresado))
                    totalIngresado += numeroIngresado;
                else
                    Console.WriteLine("Incorrecto!");

                Console.WriteLine("Desea continuar? (S/N)");
                    respuesta = Console.ReadLine();
                    respuesta.ToLower();
            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine($"La suma total es: {totalIngresado}");
        }
    }
}

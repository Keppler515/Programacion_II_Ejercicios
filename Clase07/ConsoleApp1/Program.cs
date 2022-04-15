using System;
using Biblioteca;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Jugador jugador = new Jugador("Maxi", 123456, 10, 5);

            int dni = jugador.Dni;

            Console.WriteLine(dni);

            jugador.Dni = 827193;


            Console.WriteLine(jugador.Dni);





        }
    }
}

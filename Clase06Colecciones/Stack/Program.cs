using System;
using System.Collections.Generic;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<char> letras = new Stack<char>();

            letras.Push('H');
            letras.Push('o');
            letras.Push('l');
            letras.Push('a');

            foreach (char letra in letras)
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine("-------Devuelve el siguiente sin eliminar-------");

            Console.WriteLine(letras.Peek());

            Console.WriteLine("-------Elimina el siguiente-------");

            Console.WriteLine(letras.Pop());

            Console.WriteLine("--------------");


            foreach (char letra in letras)
            {
                Console.WriteLine(letra);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> colaDeAtencion = new Queue<string>();

            //Agrego un elemento
            colaDeAtencion.Enqueue("Maxi");
            colaDeAtencion.Enqueue("Yan");
            colaDeAtencion.Enqueue("Kali");
            colaDeAtencion.Enqueue("Tobias");


            foreach(string cliente in colaDeAtencion)
            {
                Console.WriteLine(cliente);
            }

            Console.WriteLine("-------------------");


            Console.WriteLine("Elimino a:");

            //Elimino el primer cliente
            Console.WriteLine(colaDeAtencion.Dequeue());

            Console.WriteLine("-------------------");

            foreach (string cliente in colaDeAtencion)
            {
                Console.WriteLine(cliente);
            }

            Console.WriteLine("-------------------");

            Console.WriteLine($"El siguiente en la fila es {colaDeAtencion.Peek()}");

            Console.WriteLine("-------------------");

            Console.WriteLine($"Cantidad de clientes en la fila {colaDeAtencion.Count}");
        }
    }
}

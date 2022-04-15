using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> listaNombres = new List<string>();

            listaNombres.Add("Max");
            listaNombres.Add("Yan");
            listaNombres.Add("Kali");

            foreach (string nombre in listaNombres)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("-------------------------");

            listaNombres.Add("Tobias");


            foreach (string nombre in listaNombres)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("-------------------------");

            listaNombres.Insert(1, "Clifford");

            listaNombres[4] = "Diana";

            foreach (string nombre in listaNombres)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("-------------------------");

            Console.WriteLine($"La cantidad de elementos de la lista es {listaNombres.Count}");

            Console.WriteLine("-------------------------");

            listaNombres.Remove("Clifford");
            listaNombres.RemoveAt(2);

            Console.WriteLine($"La cantidad de elementos de la lista es {listaNombres.Count}");

            listaNombres.Clear();

            Console.WriteLine("-------------------------");

            Console.WriteLine($"La cantidad de elementos de la lista es {listaNombres.Count}");

            Console.WriteLine("-------------------------");

            Console.WriteLine("Las COLECCIONES GENÉRICAS SON:\nList\nDictionary\nQueue\nSortedList");

        }
    }
}

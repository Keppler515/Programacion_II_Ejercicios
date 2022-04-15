using System;
using System.Collections.Generic;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedList<string,int> listaOrdenada = new SortedList<string,int>();

            listaOrdenada.Add("Max", 515);
            listaOrdenada.Add("Kali", 666);
            listaOrdenada.Add("Yan", 555);
            listaOrdenada.Add("Tobias", 888);

            foreach(KeyValuePair<string, int> item in listaOrdenada)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");


            List<int> numeros = new List<int>();

            numeros.Add(7);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(1);
            numeros.Add(9);
            numeros.Add(2);
            numeros.Add(6);
            numeros.Add(8);


            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("--------------------"); 
            
            numeros.Sort(Comparar);

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

        public static int Comparar(int a, int b)
        {
            return b - a;
        }
    }
}

using System;

namespace I03LosPrimos
{
    internal class Program
    {

        public static string stringNumero;
        public static int numero;
        public static int contador = 0;
        public static string opcion;


        static void Main(string[] args)
        {

            do
            {
                Console.Write("Ingrese un número: ");
                stringNumero = Console.ReadLine();

                if (int.TryParse(stringNumero, out numero))
                {
                    for (int i = 1; i < numero; i++)
                    {
                        for (int j = 1; j <= numero; j++)
                        {
                            if (i % j == 0)
                            {
                                contador++;
                            }

                        }

                        if (contador == 2)
                        {
                            Console.WriteLine(i);
                        }

                        contador = 0;

                    }

                    Console.WriteLine("Para salir indique 'salir'");
                    opcion = Console.ReadLine();
                }

            } while (opcion != "salir");


        }
    }
}

using System;

namespace I05TirameUnCentro
{
    internal class Program
    {
        public static string stringNumero;
        public static int numero;
        public static int centro;
        public static int sumaAntes = 0;
        public static int sumaDespues = 0;

        static void Main(string[] args)
        {
            
            Console.Write("Ingrese un número: ");
            stringNumero = Console.ReadLine();
            int.TryParse(stringNumero, out numero);

            centro = 2;

            for (int i = 1; i < centro; i++)
            {
                sumaAntes = sumaAntes + i;

                for (int j = centro+1; j <= numero; j++)
                {
                    sumaDespues = sumaDespues + j;
                }

                if (sumaDespues == sumaAntes)
                {
                    Console.WriteLine($"EL centro es: {centro}");
                    break;
                }
                else
                {
                    Console.WriteLine("No tiene centro");
                    break;
                }
                
                sumaDespues = 0;

                centro++;
            }

        }
    }
}

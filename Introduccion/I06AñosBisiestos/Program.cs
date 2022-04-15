using System;

namespace I06AñosBisiestos
{
    internal class Program
    {

        public static string stringInicio;
        public static string stringCierre;
        public static int inicio;
        public static int cierre;

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese año de inicio: ");
            stringInicio = Console.ReadLine();
            int.TryParse(stringInicio, out inicio);


            Console.WriteLine("Ingrese año de cierre: ");
            stringCierre = Console.ReadLine();
            int.TryParse(stringCierre, out cierre);

            Console.WriteLine("--------------------");

            for (int i = inicio; i <= cierre; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            Console.WriteLine(i);
                        }
                        continue;
                    }
                    Console.WriteLine(i);
                }
            }


        }
    }
}

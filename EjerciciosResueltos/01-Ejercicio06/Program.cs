using System;

namespace Ejercicio06
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int inicio;
            int final;
            string stringInicio;
            string stringFinal;

            Console.Write("Ingrese un año de inicio: ");
            stringInicio = Console.ReadLine();
            
            Console.Write("Ingrese un año de finalización: ");
            stringFinal = Console.ReadLine();

            int.TryParse(stringInicio, out inicio);
            int.TryParse(stringFinal, out final);

            if (inicio < final)
            {
                for (int i = inicio; i <= final; i++)
                {
                    if (i%4 == 0)
                    {
                        if (i%100 == 0)
                        {
                            if(i%400 == 0)
                            {
                                Console.WriteLine($"El año {i} es bisiesto");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"El año {i} es bisiesto");
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("Eel año de inicio no puede ser mayor al año de finalización");
            }
        }
    }
}

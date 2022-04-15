using System;

namespace LogicaDeCentros
{
    public static class CalculadorDeCentros
    {
        public static int resto;
        public static int sumaAntes = 0;
        public static int sumaDespues = 0;

        public static void CalcularCentros(int valor)
        {
            for (int centro = 2; centro < valor; centro++)
            {
                for (int i = 1; i < centro; i++)
                {
                    
                    for (int j = valor; j > centro; j--)
                    {
                        sumaDespues += j;

                        if (sumaAntes == sumaDespues)
                        {
                            Console.WriteLine(centro);
                        }
                    sumaAntes += i;
                    }

                    sumaDespues = 0;
                }
                
            }
        }

    }
}

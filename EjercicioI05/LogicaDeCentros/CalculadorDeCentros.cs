using System;

namespace LogicaDeCentros
{
    public static class CalculadorDeCentros
    {

        public static int[] numeros;
        public static int valor;
        public static int sumai = 0;
        public static int sumaj = 0;
        public static bool CalcularCentros(int numero)
        {
            numeros = new int[numero];
            valor = 1;

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = valor++;
                Console.WriteLine(numeros[i]);
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                sumai = sumai + numeros[i];
                Console.WriteLine($"I suma: {sumai}");

                for (int j = 2; j < numeros.Length ; j++)
                {
                    sumaj = sumaj + numeros[j];
                    Console.WriteLine($"J suma: {sumaj}");
                    
                    if (sumai == sumaj)
                    {
                        if (j + i == numeros.Length - 1 )
                        {
                            Console.WriteLine($"el numero es {sumaj}");
                            return true;
                        }
                    }
                }
                
                sumaj = 0;
            }
            return false;
        }

    }
}

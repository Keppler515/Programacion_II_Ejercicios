using System;

namespace ConversorBinario
{
    public static class Conversor
    {
        public static int acumulador;
        public static double numero;
        public static double resultado;
        public static int resto;
        public static double total;


        public static void ConvertirDecimalABinario(int numeroEntero) 
        {

            for (acumulador = numeroEntero; acumulador > 0; )
            {
                resto = acumulador % 2;
                acumulador = acumulador / 2;

                   Console.Write(resto);
            }
        }

        public static void ConvertirBinarioADecimal(string numeroBinario) 
        {

        }

    }
}

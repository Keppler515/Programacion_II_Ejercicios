using System;
using System.Text;

namespace I03Biblioteca
{
    public class Conversor
    {
        private static string resultado;
        private static string resultadoOrdenado;
        private static string numeroBinario;
        private static double resultadoInt;
        private static int bit;
        private static int calculo;
        private static int aux;

        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            calculo = numeroEntero;
            do
            {
                bit = calculo % 2;
                calculo = calculo / 2;
                resultado += bit.ToString();
            } while (calculo > 0);

            for (int i = resultado.Length - 1; i >= 0; i--)
            {
                resultadoOrdenado += resultado[i];
            }

            return resultadoOrdenado;

        }

        public static string ConvertirBinarioADecimal(int numeroEntero)
        {
            return resultado;
        }

    }
}

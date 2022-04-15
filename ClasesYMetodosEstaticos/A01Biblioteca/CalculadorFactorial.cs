using System;

namespace A01Biblioteca
{
    public class CalculadorFactorial
    {
        private static double resultado = 1;
        private static int numero;
        public static double CalcularFactorial(string sNumero)
        {
            int.TryParse(sNumero, out numero);

            for (int i = 2; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }

    }
}

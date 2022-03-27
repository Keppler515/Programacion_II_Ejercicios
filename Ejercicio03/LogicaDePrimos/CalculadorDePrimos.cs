using System;

namespace LogicaDePrimos
{
    public static class CalculadorDePrimos
    {
        public static int contador = 0;
        public static bool EsPrimo(int numero)
        {
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }
            
            if (numero != 1 && contador <= 2)
            {
                return true;
            }
            return false;
        }

    }
}

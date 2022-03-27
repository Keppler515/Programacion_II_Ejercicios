using System;

namespace LogicaBisiestos
{
    public static class CalcularBisiestos
    {
        public static bool EsBisiesto(int numero)
        {
            if (numero % 4 == 0)
            {
                if (numero % 100 == 0)
                {
                    if (numero % 400 == 0)
                    {
                        return true;
                    }
                  
                    return false;
                }

                return true;
            }

            return false;
        }
    }
}

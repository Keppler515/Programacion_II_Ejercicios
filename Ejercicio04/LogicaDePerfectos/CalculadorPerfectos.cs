using System;

namespace LogicaDePerfectos
{
    public static class CalculadorPerfectos
    {
        public static int acumulador = 0;
        public static bool CalcularPerfecto(int numero)
        {
            for (int i = 1; i < numero; i++)
            {
                if(numero % i == 0)
                {
                    acumulador = acumulador + i;
                }
            }
            if (acumulador == numero)
            {
                return true;
            }

            return false;
        }
    }
}


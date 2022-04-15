using System;

namespace I01Biblioteca
{
    public static class Validador
    {

        public static bool Validar(int valor, int min, int max)
        {
            if (min >= -100 && max <= 100)
            {
                return true;
            }

            else
                return false;
        }

    }
}

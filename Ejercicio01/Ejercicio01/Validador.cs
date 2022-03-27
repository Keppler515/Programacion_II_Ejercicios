using System;

namespace LogicaDeCalculo
{
    public static class Validador
    {
        public static bool Validar(int numero, int minimo, int maximo)
        {
            if (numero < minimo || numero > maximo)
                return false;   
            else return true;
        }

    }
}

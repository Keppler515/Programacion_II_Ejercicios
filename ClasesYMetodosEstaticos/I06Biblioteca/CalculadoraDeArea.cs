using System;

namespace I06Biblioteca
{
    public class CalculadoraDeArea
    {

        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }

        public static double CalcularAreaTriangulo(double bBase, double altura)
        {
            return (altura * bBase) / 2;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            return Math.Pow((Math.PI*radio),2);
        }

    }
}

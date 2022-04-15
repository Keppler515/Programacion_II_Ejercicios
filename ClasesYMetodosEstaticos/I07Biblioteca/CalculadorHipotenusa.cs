using System;

namespace I07Biblioteca
{
    public class CalculadorHipotenusa
    {
        private static double hipotenusa;

        public static double CalcularHipotenusa(double bBase, double altura)
        {

            hipotenusa = Math.Sqrt(Math.Pow(bBase, 2) + Math.Pow(altura, 2));

            return hipotenusa;
        }
    }
}

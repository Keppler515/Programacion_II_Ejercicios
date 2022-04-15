using System;

namespace I08Biblioteca
{
    public class CalculadorDeDias
    {
        private static double resultado;
        private static int ahora = DateTime.Today.Year;
        private static double contadorDias = 0;
        private static int dia;
        private static int mes;
        private static int anio;

        public static double CalcularDias(string day, string month, string year)
        {
            int.TryParse(day, out dia);
            int.TryParse(month, out mes);
            int.TryParse(year, out anio);


            for (int i = anio; i < ahora; i++)
            {
                for (int j = mes; j <= 12; j++)
                {
                    contadorDias = contadorDias + DateTime.DaysInMonth(i, j);
                }
                mes = 1;
            }

            if (anio < ahora)
            {
                resultado = contadorDias - dia + DateTime.Today.DayOfYear;
            }
            else
            {
                resultado = DateTime.Today.Day - dia;
            }

            return resultado;

        }

    }
}

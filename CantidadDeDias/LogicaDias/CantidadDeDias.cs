using System;
using LogicaBisiestos;

namespace LogicaDias
{
    public static class CantidadDeDias
    {
        public static int CalcularDias(string sDay, string sMonth, string sYear)
        {
            int day;
            int month;
            int year;
            int totalDias = 0;
            int totalMonth = 0;
            int totalYear = 0;
            int hoy = DateTime.Now.Year;

            int.TryParse(sDay, out day);
            int.TryParse(sMonth, out month);
            int.TryParse(sYear, out year);
            /*
            if (year == hoy)
            {
                for (int i = month; i <= DateTime.Now.Month; i++)
                {
                    for (int j = day; j < DateTime.DaysInMonth(year,i); j++)
                    {
                     totalDias++;
                    }
                    day = 1;
                }

                return totalDias;
            }
            */
            for (int i = year; i < hoy; i++)
            {
                for (int j = month; j <= 12; j++)
                {
                    for (int k = day; k <= DateTime.DaysInMonth(i,j); k++)
                    {
                        totalDias++;
                    }
                    day = 1;
                    month = 1;

                    totalMonth++;
                }
            }

            return totalDias + DateTime.Now.DayOfYear - 1;
        }
    }
}


/*
Consigna
Crear un método estático que reciba una fecha y calcule el número de días que pasaron 
desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el 
número de días vividos por esa persona hasta la fecha actual utilizando el método 
desarrollado anteriormente.

Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
*/
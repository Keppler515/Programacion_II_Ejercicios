using System;
using System.Text;

namespace I05Biblioteca
{
    public class CreadorDeTablas
    {
        public static int resultado;

        public static StringBuilder CrearTablas(int numero)
        {
            StringBuilder tabla = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                resultado = numero * i;

                tabla.AppendLine($"{numero} X {i} = {resultado}");
            }

            return tabla;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            int resultado,
                modulo,
                contador = 0;

            string binario = "";
            string binarioOrdenado = "";

            do
            {
                resultado = numeroEntero / 2;
                modulo = numeroEntero % 2;
                numeroEntero = resultado;
                binario += modulo.ToString();
                contador++;
            } while (contador < 8);
            for (int i = binario.Length - 1; i >= 0; i--)
            {
                binarioOrdenado += binario[i];
            }
            return binarioOrdenado;
        }

        public static int ConvertirBinarioADecimal(int numeroBinario)
        {
            int total = 0,
                valorPosicion = 1;

            for (int i = numeroBinario.ToString().Length - 1; i >= 0; i--)
            {
                if (numeroBinario.ToString()[i] == '1')
                {
                    total += valorPosicion;
                }
                valorPosicion *= 2;
            }
            return total;
        }
    }
}

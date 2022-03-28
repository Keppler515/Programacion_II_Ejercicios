using System;

namespace LogicaTrianguloEquilatero
{
    public class CalculaEquilatero
    {
        public static string asterisco = "*";
        public static string espacio = " ";
        public static string DibujarTrianguloEquilatero(int altura)
        {
            for (int i = 0; i < altura; i++)
            {
                for (int j = altura; j > i; j--)
                {
                    Console.Write($"{espacio}");
                    espacio = espacio + " ";
                }

                Console.WriteLine($"{asterisco}");
                asterisco = asterisco + "*";
            }

            return asterisco;
        }

    }
}

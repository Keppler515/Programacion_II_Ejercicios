using System;

namespace LogicaTriangulo
{
    public static class DibujaTriangulo
    {
        public static string asterisco = "*";
        public static string DibujarTriangulo(int altura)
        {
            for (int i = 0; i < altura; i++)
            {
                Console.WriteLine($"{asterisco}");
                asterisco = asterisco + "*";
            }

            return asterisco;
        }
    }
}

using System;
using LogicaTrianguloEquilatero;

namespace VistaTrianguloEquilatero
{
    internal class Program
    {
        public static string stringAltura;
        public static int altura;
        public static string asterisco = "*";

        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese una altura");
            stringAltura = Console.ReadLine();
            int.TryParse(stringAltura, out altura);

            CalculaEquilatero.DibujarTrianguloEquilatero(altura);

        }
    }

}

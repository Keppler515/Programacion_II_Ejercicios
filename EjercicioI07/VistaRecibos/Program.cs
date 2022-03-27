using System;
using LogicaRecibos;

namespace VistaRecibos
{
    internal class Program
    {
        public static float valorHora, horasTrabajadas;
        public static int antiguedad;
        public static string nombre;
        public static string stringValorHora, stringHorasTrabajadas, stringAntiguedad;
        public static string stringOpcion;
        public static int opcion = 0;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Valor hora: ");
                stringValorHora = Console.ReadLine();
                float.TryParse(stringValorHora, out valorHora);

                Console.WriteLine("Nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Antigüedad: ");
                stringAntiguedad = Console.ReadLine();
                int.TryParse(stringAntiguedad, out antiguedad);

                Console.WriteLine("Horas trabajadas: ");
                stringHorasTrabajadas = Console.ReadLine();
                float.TryParse(stringHorasTrabajadas, out horasTrabajadas);

                CalculadorRecibos.CalcularRecibos(valorHora, nombre, antiguedad, horasTrabajadas);

                Console.WriteLine($"Empleado: {nombre}");
                Console.WriteLine($"Antigüedad: {antiguedad}");
                Console.WriteLine($"Valor hora: {valorHora}");
                Console.WriteLine($"Total bruto: {CalculadorRecibos.totalBruto}");
                Console.WriteLine($"El valor final es: {CalculadorRecibos.final}");

                Console.WriteLine("Desea continuar?");
                Console.WriteLine("1: si");
                Console.WriteLine("0: no");
                stringOpcion = Console.ReadLine();
                int.TryParse(stringOpcion, out opcion);

            } while (opcion != 0);
        }
    }
}

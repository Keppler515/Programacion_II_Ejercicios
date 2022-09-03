using System;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringValorHora;
            float valorHora;

            string stringHorasTrabajadas;
            int horasTrabajadas;

            string stringAntiguedad;
            int antiguedad;
            
            string nombreEmpleado;

            float sueldoFinalBruto;
            float sueldoFinalNeto;

            float descuentos;

            bool continua;

            descuentos = 13f;

            do
            {
                Console.Write("Nombre: ");
                nombreEmpleado = Console.ReadLine();

                Console.Write("Valor hora: ");
                stringValorHora = Console.ReadLine();
                float.TryParse(stringValorHora, out valorHora);
            
                Console.Write("Horas trabajadas: ");
                stringHorasTrabajadas = Console.ReadLine();
                int.TryParse(stringHorasTrabajadas, out horasTrabajadas);

                Console.Write("Antigüedad: ");
                stringAntiguedad = Console.ReadLine();
                int.TryParse(stringAntiguedad, out antiguedad);

                sueldoFinalBruto = (valorHora * horasTrabajadas) + (antiguedad * 150);
                sueldoFinalNeto = sueldoFinalBruto - (sueldoFinalBruto * descuentos / 100);

                Console.WriteLine("-------------------------");
                Console.WriteLine($"Empleado: {nombreEmpleado}\n" +
                    $"Antigüedad: {antiguedad}\n" +
                    $"Valor hora: {valorHora}\n" +
                    $"Horas trabajadas: {horasTrabajadas}\n" +
                    $"Sueldo bruto: {sueldoFinalBruto}\n" +
                    $"Sueldo neto: {sueldoFinalNeto}");
                Console.WriteLine("-------------------------");

                Console.WriteLine("Desea agregar otro empleado? (s/n)");
                if(Console.ReadLine() == "s")
                {
                    continua = true;
                }
                else
                {
                    continua = false;
                }

            } while (continua);
            
        }
    }
}

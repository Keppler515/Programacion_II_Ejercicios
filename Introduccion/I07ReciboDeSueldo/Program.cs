using System;

namespace I07ReciboDeSueldo
{

    internal class Program
    {

        public static string stringValorHora;
        public static float valorHora;
        public static string nombre;
        public static string stringAntiguedad;
        public static int antiguedad;
        public static int plusAntiguedad = 0;
        public static string stringHorasTrabajadas;
        public static int horasTrabajadas;

        public static float total;
        public static float finalBruto;
        public static float finalNeto;


        static void Main(string[] args)
        {
            Console.Write("Ingrese Valor Hora: ");
            stringValorHora = Console.ReadLine();
            float.TryParse(stringValorHora, out valorHora);

            Console.Write("Ingrese Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese Antigüedad (años): ");
            stringAntiguedad = Console.ReadLine();
            int.TryParse(stringAntiguedad, out antiguedad);

            Console.Write("Ingrese Cantidad de Horas Trabajadas: ");
            stringHorasTrabajadas = Console.ReadLine();
            int.TryParse(stringHorasTrabajadas, out horasTrabajadas);


            for (int i = 0; i <= antiguedad; i++)
            {
                plusAntiguedad = plusAntiguedad + 150;
            }



            total = valorHora * horasTrabajadas;

            finalBruto = total + plusAntiguedad;
            finalNeto = finalBruto - (finalBruto *13 / 100);

            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Antigüedad: {antiguedad} años");
            Console.WriteLine($"Valor Hora: ${valorHora}");
            Console.WriteLine($"Final Bruto: {finalBruto}");
            Console.WriteLine($"Final Neto: {finalNeto}");

        }
    }
}



/*Consigna
Se debe pedir el ingreso por teclado del 
valor hora, 
el nombre, 
la antigüedad (en años) y 
la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.

IMPORTANTE
Utilizar sentencias de iteración y selectivas.

No es necesario ni se deben utilizar vectores/arrays.*/
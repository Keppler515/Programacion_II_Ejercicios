using System;
using Logica;
using System.Text; //Contiene la clase StringBuilder

namespace Consola
{
    internal class Program
    {
        static float temperaturaCelcius;
        static float temperaturaKelvin;
        static void Main(string[] args)
        {
            string nombre = "Maximiliano";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hola ");
            stringBuilder.Append("Mundo");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.AppendFormat($"Mi nombre es {nombre}");

            Console.WriteLine(stringBuilder.ToString());


            temperaturaCelcius = 30;
            temperaturaKelvin = ConversorDeTemperaturas.ConvertirCelciusAKelvin(temperaturaCelcius);

            MostrarTemperaturas();
        }

        static void MostrarTemperaturas()
        {
            Console.WriteLine($"La temperatura Celcius es {temperaturaCelcius}");
            Console.WriteLine($"La temperatura Kelvin es {temperaturaKelvin}");
        }

        /*-----------------------------*/

        /*
            No se recomienda concatenar texto. Ej:
            
            string texto = "Hola";
            texto += "Mundo";

            Las propiedades string son inmutables.
            No se modifica el primer string sino que se realiza una copia
            Por lo que ocupa un nuevo sector en la memoria.

            En tal caso se utiliza la clase StringBuilder y sus métodos.

        */

        
    }
}

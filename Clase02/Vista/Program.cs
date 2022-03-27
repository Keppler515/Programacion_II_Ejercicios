using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static float temperaturaCelcius;
        static float temperaturaKelvin;
        static void Main(string[] args)
        {
            temperaturaCelcius = 30;
            temperaturaKelvin = ConversorDeTemperatura.ConvertirCelciusAKelvin(temperaturaCelcius);
            MostrarTemperatura();
        }

        static void MostrarTemperatura()
        {
            Console.WriteLine($"La temperatura Celcius es {temperaturaCelcius}");
            Console.WriteLine($"La temperatura Kelvin es {temperaturaKelvin}");
        }
    }
}

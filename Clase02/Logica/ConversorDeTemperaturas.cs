using System;

namespace Logica
{
    public class ConversorDeTemperaturas // PascalCase
    {
       private const float ceroAbsoluto = 273.15f; //lowercase

        public static float ConvertirCelciusAKelvin(float temperaturaCelcius) // el nombre del método en PascalCase
        {
            return temperaturaCelcius + ceroAbsoluto;
        }

        public static double ConvertirKelvinACelcius(int temperaturaKelvin)
        {
            return temperaturaKelvin - ceroAbsoluto;
        }
    }
}

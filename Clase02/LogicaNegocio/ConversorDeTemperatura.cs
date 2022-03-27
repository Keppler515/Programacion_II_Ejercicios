using System;

namespace LogicaNegocio
{
    public static class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15f;
        
        public static float ConvertirCelciusAKelvin(float temperaturaCelcius)
        {
            return temperaturaCelcius + ceroAbsoluto;
        }

        public static float ConvertirKelvinACelcius(float temperaturaKelvin)
        {
            return temperaturaKelvin - ceroAbsoluto;
        }
    }
}

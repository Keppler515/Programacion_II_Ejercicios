using System;

namespace LogicaDeseaContinuar
{
    public static class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta == "s")
                return true;
           
            return false;
        }
    }
}

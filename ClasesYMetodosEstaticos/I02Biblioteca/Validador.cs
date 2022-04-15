using System;

namespace I02Biblioteca
{
    public class Validador
    {

        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta != null && respuesta == "s")
            return true;

            else
                return false;
        }

    }
}

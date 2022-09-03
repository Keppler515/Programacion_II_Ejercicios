using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public static class Validador
    {
        public static bool Validar(int valorIngresado, int valorMinimo, int valorMaximo)
        {
            return (valorIngresado >= valorMinimo && valorIngresado <= valorMaximo);
        }

        public static bool ValidarRespuesta(string respuesta)
        {
            return (respuesta == "s" ? true : false);
        }
    }
}

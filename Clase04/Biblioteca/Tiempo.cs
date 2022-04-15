using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Tiempo
    {
        private int hora;
        private int minutos;
        private int segundos;

        public Tiempo(int hora, int minutos, int segundos)
        {
            this.hora = hora;
            this.minutos = minutos;
            this.segundos = segundos;
        }

        public Tiempo(int hora, int minutos):this(hora, minutos, 1)
        {
            /*
            this.hora=hora;
            this.minutos=minutos;
            this.segundos = 1;
            */
        }

        public Tiempo(int hora) :this(hora,0,0)
        {

        }
    }
}

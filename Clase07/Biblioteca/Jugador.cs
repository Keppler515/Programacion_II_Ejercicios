using System;

namespace Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;


        public int Dni
        {
            get { return this.dni; }

            set { this.dni = value; }
        }

        public Jugador(string nombre, int dni, int partidosJugados, int totalGoles)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }
    }
}

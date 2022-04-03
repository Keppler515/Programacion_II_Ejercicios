using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaVehiculos
{
    public class Auto
    {
        //No se puede acceder a las propiedades private.
        //Para eso se hacen los métodos setter y getter mas abajo
        private string patente;
        private string marca;
        private string modelo;
        private static float precioHora;
        private int cantidadHoras;

        static Auto()
        {
            Auto.precioHora = 100f;
        }

        public Auto(string patente, string marca, string modelo)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
        }

        public int GetCantidadHoras()
        {
            return this.cantidadHoras;
        }

        public void SetCantidadHoras(int value)
        {
            if (value > 0)
            {
                this.cantidadHoras = value;
            }
        }

        public string GetPatente()
        {
            return this.patente;
        }

        public void SetPatente(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                this.patente = value;
            }
        }
        
        public string GetModelo()
        {
            return this.modelo;
        }

        public void SetModelo(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                this.modelo = value;
            }
        } 
        
        
        public string GetMarca()
        {
            return this.marca;
        }

        public void SetMarca(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                this.marca = value;
            }
        }

        public float CalcularCostoEstadia()
        {
            return this.cantidadHoras * Auto.precioHora;
        }

        public static void SetPrecioHora(float value)
        {
            Auto.precioHora = value;
        }

        public static float GetPrecioHora()
        {
            return Auto.precioHora;
        }
    }
}

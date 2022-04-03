using System;

namespace Logica
{
    public class Mascota
    {
        public string nombre;
        public string raza;
        public string especie;
        public int edad;
        public bool hambre;

        public Mascota(string nombre, string especie, int edad)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.edad = edad;
        }

        //Método del objeto o método de instancia.
        //Un método de instancia es utilizable por
        //cada objeto creado con sus propiedades unicas.
        //(no le asigno modificador de acceso)
        public string Saludar()
        {
            return $"Hola. Mi nombre es {this.nombre}. Soy un {this.especie} y tengo {this.edad} años";
        }

        //Método de la clase
        //Un método de clase tiene una funcionalidad
        //única para todas las instancias creadas.
        public static void Alimentar(Mascota mascota)
        {
            if (mascota.hambre)
            {
                mascota.hambre = false;
            }
        }
    }

}

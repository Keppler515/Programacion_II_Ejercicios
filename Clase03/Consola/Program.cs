using System;
using Logica;
using System.Text;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Mascota perro = new Mascota();//Esto es una instancia de la clase Mascota
            perro.raza = "Calle";
            perro.edad = 5;
            perro.nombre = "Tobias";
            perro.especie = "Perro";
            perro.hambre = true;

            Console.WriteLine(perro.Saludar());
        */
            Mascota gato = new Mascota("Kali", "gato", 1);



            Mascota.Alimentar(gato);
            Console.WriteLine(gato.Saludar());
            Console.WriteLine($"Kali tiene hambre? {gato.hambre}");
           // Console.WriteLine($"Tobias tiene hambre? {perro.hambre}");
        }
    }
}

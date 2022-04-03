using System;
using Logica;

namespace ConsolaVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("AAA001", "Chevrolet", "Camaro");
            Auto auto2 = new Auto("BBB001", "Ford", "Mustang");

            auto1.SetCantidadHoras(5);
            auto2.SetCantidadHoras(2);

            Console.WriteLine(auto1.GetModelo());
            Console.WriteLine(auto2.GetModelo());

            Auto.SetPrecioHora(250);

            Console.WriteLine($"Precio de la hora es: {Auto.GetPrecioHora()}");

            Console.WriteLine($"El importe total a pagar de {auto1.GetModelo()} es {auto1.CalcularCostoEstadia()}");
            Console.WriteLine($"El importe total a pagar de {auto2.GetModelo()} es {auto2.CalcularCostoEstadia()}");


            Camioneta camioneta1 = new Camioneta("JJJ666","Toyota","Hilux");
            Camioneta camioneta2 = new Camioneta("MAX515","Ford","Ranger");
        }
    }
}

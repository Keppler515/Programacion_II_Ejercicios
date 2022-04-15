using System;
using LogicaPrestamo;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta empleado = new Cuenta("Maximiliano", 153000f);

            Console.WriteLine(empleado.Mostrar());

            empleado.Ingresar(85000f);

            Console.WriteLine(empleado.Mostrar());

            empleado.Retirar(64000f);

            Console.WriteLine(empleado.Mostrar());

        }
    }
}

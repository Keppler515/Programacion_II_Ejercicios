using System;
using LogicaDePerfectos;

namespace VistaPerfectos
{
    internal class Program
    {
        public static int numero = 8128;
        //public static int contador = 0;
        static void Main(string[] args)
        {
            if (CalculadorPerfectos.CalcularPerfecto(numero))
            {
                Console.WriteLine($"{numero} es un número perfecto");
            }
            else
            {
                Console.WriteLine($"{numero} NO es un número perfecto");
            }
        }
    }
}


//SI PASO EL NUMERO COMO UN LITERAL FUNCIONA.
//SI LO PASO CON UN FOR O UN WHILE NO MUESTRA NADA O MUESTRA MAL EL RESULTADO

/*
static void Main(string[] args)
{
    for (int i = 1; i < 1000; i++)
    {
        if (CalculadorPerfectos.CalcularPerfecto(i))
        {
            Console.WriteLine($"{i} es un número perfecto");
        }
        else
        {
            Console.WriteLine($"{i} NO es un número perfecto");
        }
    }
}
 */


/*
    static void Main(string[] args)
    {
        while (contador < 4)
        {
            if (CalculadorPerfectos.CalcularPerfecto(numero))
            {
                Console.WriteLine($"{numero} es un número perfecto");
                contador++;
            }
            else
            {
                Console.WriteLine($"{numero} NO es un número perfecto");
            }
            numero++;
        }
    }
 */
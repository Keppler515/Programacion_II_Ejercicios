using System;
using I01Biblioteca;

namespace I01ValidadorDeRangos
{
    internal class Program
    {
        public static string stringValor;
        public static int valor;
        public static int minimo;
        public static int maximo;
        public static int acumulador = 0;
        public static int contador = 0;

        static void Main(string[] args)
        {


            do
            {

                Console.Write("Ingrese un número: ");
                stringValor = Console.ReadLine();
                int.TryParse(stringValor, out valor);

                if (Validador.Validar(valor, -100, 100))
                {
                    if (contador == 0)
                    {
                        minimo = valor;
                        maximo = valor;
                    }

                    if (valor < minimo)
                    {
                        minimo = valor;
                    }

                    if (valor > maximo)
                    {
                        maximo = valor;
                    }

                    acumulador = acumulador + valor;
                    contador++;
                }
            
            }while (contador < 10);

            Console.WriteLine($"El mínimo es {minimo}.\nEl máximo es {maximo}.\nEl total es {acumulador}.\nEl promedio es {acumulador/contador}.");
        }
    }
}

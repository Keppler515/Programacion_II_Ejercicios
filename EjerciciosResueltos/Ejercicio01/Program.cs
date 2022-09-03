using System;
using BibliotecaDeClases;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1,
                numeroIngresado,
                minimoIngresado = 0,
                maximoIngresado = 0,
                totalIngresado = 0; ;
            
            float promedio;

            string stringNumeroIngresado;

            do
            {
                Console.Write($"{contador}-Ingresa un numero: ");
                stringNumeroIngresado = Console.ReadLine();
                if(int.TryParse(stringNumeroIngresado, out numeroIngresado))
                {
                    if (Validador.Validar(numeroIngresado, -100, 100))
                    {
                        if (contador == 1)
                        {
                            minimoIngresado = numeroIngresado;
                            maximoIngresado = numeroIngresado;
                        }

                        if (numeroIngresado < minimoIngresado)
                            minimoIngresado = numeroIngresado;

                        if (numeroIngresado > maximoIngresado)
                            maximoIngresado = numeroIngresado;

                        totalIngresado += numeroIngresado;
                        contador++;

                    }
                    else
                    {
                        Console.WriteLine("Incorrecto!");
                    }

                }
            } while (contador < 11);

            promedio = totalIngresado / contador;

            Console.WriteLine($"El total es: {totalIngresado}\n" +
                $"El minimo es: {minimoIngresado}\n" +
                $"El maximo es: {maximoIngresado}\n" +
                $"El promedio es: {Math.Ceiling(promedio)}");
        }
    }
}

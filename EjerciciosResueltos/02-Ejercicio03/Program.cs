using System;
using BibliotecaDeClases;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decimal a binario

            /*Console.Write("Ingrese un numero entero: ");

            string stringNumeroIngresado = Console.ReadLine();
            if(int.TryParse(stringNumeroIngresado, out int numeroIngresado))
                Console.WriteLine(Conversor.ConvertirDecimalABinario(numeroIngresado));*/


            //Binario a decimal

            Console.Write("Ingrese un numero binario: ");

            string stringNumeroBinario = Console.ReadLine();
            for (int i = 0; i < stringNumeroBinario.Length; i++)
            {
                if (stringNumeroBinario[i] != '0' && stringNumeroBinario[i] != '1')
                {
                    Console.WriteLine("Incorrecto!");
                    break;
                }
                else
                {
                    if(int.TryParse(stringNumeroBinario, out int numeroBinario))
                        Console.WriteLine(Conversor.ConvertirBinarioADecimal(numeroBinario));
                    break;
                }
            }
                
        }
    }
}

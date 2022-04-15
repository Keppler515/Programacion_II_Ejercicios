using System;

namespace LogicaFactorial
{
    public static class Factorial
    {
        public static int CalcularFactorial(int numero)
        {
            int resultado = numero;

            for (int i = numero - 1; i > 0; i--)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}


/*
Consigna
El factorial de un número es una operación que consiste en multiplicar un numero “n” 
por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial 
de 3 es el resultado de multiplicar 3 por 2 por 1.

En una aplicación de consola, desarrollar un método estático que calcule el factorial 
de un número dado.
*/
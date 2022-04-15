using System;

namespace Biblioteca
{
    public class Calculadora
    {
        public static int resultado;

        public static int Calcular(int operando1, int operando2, string operacion)
        {
            switch (operacion)
            {
                case "+":
                    resultado = operando1 + operando2;
                    break;

                case "-":
                    resultado = operando1 - operando2;
                    break;

                case "*":
                    resultado = operando1 * operando2;
                    break;

                case "/":
                    if (Validar(operando2))
                    {
                        resultado = operando1 / operando2;
                        return resultado;
                    }
                    return -1;
                    break;

                default:
                    return -1;
            }

            return resultado;
        }


        private static bool Validar(int operando2)
        {
            if (operando2 != 0)
            {
                return true;
            }

            return false;
        }
    }
}






/*
Consigna#
Realizar un programa que permita realizar operaciones matemáticas simples 
(suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular(público): Recibirá tres parámetros, el primer operando, el segundo operando y 
la operación matemática. El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe 
utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true 
si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar 
(ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.
*/
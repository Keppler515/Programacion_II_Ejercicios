using System;

namespace Entidades
{
    public static class Calculadora
    {


        private static string ValidarOperador(string operador)
        {
            if (operador != "-" && operador != "*" && operador != "/")
            {
                return "+";
            }

            return operador;
        }


        public static double Operar(Operando num1, Operando num2, string operador)
        {

            double resultado = 0;

            switch (ValidarOperador(operador))
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }

    }
}

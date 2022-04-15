using System;

namespace I04Biblioteca
{
    public class Calculadora
    {

        private static float resultado;

        public static float Calcular(int operando1, int operando2, string operacion)
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
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0");
                        return -1;
                    }
                    break;
            }

            return resultado;

        }

        private static bool Validar(int operando2)
        {
            if (operando2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}

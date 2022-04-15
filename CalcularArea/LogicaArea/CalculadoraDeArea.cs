using System;

namespace LogicaArea
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            double resultado = Math.Pow(longitudLado,2);

            return resultado;
        }
        
        
        public static double CalcularAreaTriangulo(double bbase, double altura) 
        {
            double resultado = (bbase * altura) / 2;

            return resultado;
        }
        
        
        public static double CalcularAreaCirculo(double radio) 
        {
            double resultado = Math.PI * Math.Pow(radio,2);

            return resultado;
        }

    }
}


/*
Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) 
que realicen el cálculo del área que corresponda:

El ingreso de los datos como la visualización se deberán realizar desde el método Main().
 */
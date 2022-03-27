using System;

/*
Consigna#
Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) 
y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total 
(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de 
todas esas operaciones restarle el 13% en concepto de descuentos.

Mostrar el recibo correspondiente con el nombre, la antigüedad, 
el valor hora, el total a cobrar en bruto y el total a cobrar neto 
de todos los empleados ingresados.
 */


namespace LogicaRecibos
{
    public static class CalculadorRecibos
    {
        public static float totalNeto;
        public static float totalBruto;
        public static float descuento;
        public static float final;

        public static float CalcularRecibos(float valorHora, string nombre, int antiguedad, float horasTrabajadas)
        {
            totalNeto = valorHora * horasTrabajadas;
            totalBruto = totalNeto + antiguedad * 150;
            descuento = (totalBruto * 13) / 100;
            final = totalBruto - descuento;
            return final;
        }
    }
}

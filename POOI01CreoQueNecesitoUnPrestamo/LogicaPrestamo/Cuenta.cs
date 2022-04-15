using System;

namespace LogicaPrestamo
{
    public class Cuenta
    {
        public string titular;
        public float cantidad;

        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public float GetCantidad()
        {
            return this.cantidad;
        }


        public string Mostrar()
        {
            return $"Titular: {this.titular}. Cantidad: ${this.cantidad}";
        }

        public void Ingresar(float ingreso)
        {
            if (ingreso > 0)
            {
                this.cantidad = cantidad + ingreso;
            }
        }

        public float Retirar(float retiro)
        {
            return this.cantidad - retiro;
        }
    }
}

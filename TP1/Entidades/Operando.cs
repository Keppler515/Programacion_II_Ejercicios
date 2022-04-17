using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        private double ValidarOperando(string strNumero)
        {
            if (double.TryParse(strNumero, out numero))
            {
                return numero;
            }
            else
            {
                return 0;
            }
        }

        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    return false;
                }
            }

            return true;
        }

        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                int modulo;
                int exponente = 0;
                double resultado = 0;
                int numero;

                int.TryParse(binario, out numero);

                do
                {
                    modulo = numero % 10;
                    numero = numero / 10;
                    resultado += modulo * Math.Pow(2, exponente);
                    exponente++;
                } while (numero != 0);

                resultado = (int)resultado;

                return resultado.ToString();
            }
            return "Valor inválido";
        }

        public string DecimalBinario(double numero)
        {
            string aux = numero.ToString();
            return DecimalBinario(aux);
        }

        public string DecimalBinario(string numero)
        {
            int modulo;
            int numeroAux;
            int calculo;

            int.TryParse(numero, out numeroAux);

            calculo = numeroAux;

            StringBuilder sbResultado = new StringBuilder();

            do
            {
                modulo = calculo % 2;
                calculo = calculo / 2;
                sbResultado.Append(modulo.ToString());
            } while (calculo > 0);

            StringBuilder sb = new StringBuilder();

            for (int i = sbResultado.Length-1; i >= 0; i--)
            {
                sb.Append(sbResultado[i]);
            }

            return sb.ToString();
        }

        public static double operator + (Operando operando1, Operando operando2)
        {
            return operando1.numero + operando2.numero;
        }

        public static double operator - (Operando operando1, Operando operando2)
        {
            return operando1.numero - operando2.numero;
        }

        public static double operator * (Operando operando1, Operando operando2)
        {
            return operando1.numero * operando2.numero;
        }

        public static double operator / (Operando operando1, Operando operando2)
        {
            if (operando2.numero != 0)
            {
                return operando1.numero / operando2.numero;
            }
            else
            {
                return double.MinValue;
            }
   
        }

    }
}


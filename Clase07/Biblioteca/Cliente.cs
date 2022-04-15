using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Cliente
    {

        private string nombreCliente;
        private int numeroCliente;


        public string Nombre
        {
            get
            {
                return nombreCliente;
            }
            set
            {
                nombreCliente = value;
            }
        }

        public int Numero
        {
            get
            {
                return numeroCliente;
            }
        }



        public static int MetodoCliente(int numero)
        {
            return -1;
        }

        public static int MetodoCliente(int numero, string nombre)
        {
            return -1;
        }


    }
}

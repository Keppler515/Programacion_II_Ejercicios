using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Negocio
    {

        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public string Cliente
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }


        public static void MetodoNegocio()
        {

        }

        public static void MetodoNegocio(string nombre)
        {

        }

    }
}

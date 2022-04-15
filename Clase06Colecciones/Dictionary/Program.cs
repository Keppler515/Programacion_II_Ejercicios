using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,int> agenda = new Dictionary<string,int>();

            agenda.Add("Maxi", 1233244568);
            agenda.Add("Yan", 132465749);
            agenda.Add("Kali", 666478736);
            agenda.Add("Tobias", 778321563);


            foreach (KeyValuePair<string,int> contacto in agenda)
            {
                Console.WriteLine($"la key es: {contacto.Key} y el value es {contacto.Value}");
            }

            if (agenda.ContainsKey("Kali"))
            {
                Console.WriteLine("Contiene Kali");
            }

            if (agenda.ContainsValue(4349))
            {
                Console.WriteLine("Contiene el valor");
            }
            else
            {
                Console.WriteLine("No contiene el valor");
            }


            Console.WriteLine(agenda["Kali"]);

        }
    }
}

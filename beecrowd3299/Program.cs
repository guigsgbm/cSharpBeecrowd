using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd3299
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string n;

            n = Console.ReadLine();

            int i = n.IndexOf("13");

            if (i >= 0)
            {
                Console.WriteLine(n + " es de Mala Suerte");
            }
            else
                Console.WriteLine(n + " NO es de Mala Suerte");

            Console.ReadLine();
        }
    }
}

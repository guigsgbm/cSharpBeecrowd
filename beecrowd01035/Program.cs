using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd01035
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, d;



            string l1 = Console.ReadLine();
            string[] v1 = l1.Split(' ');

            a = int.Parse(v1[0]);
            b = int.Parse(v1[1]);
            c = int.Parse(v1[2]);
            d = int.Parse(v1[3]);

            if (b > c & d > a & c + d > a + b & c > 0 & d > 0 & a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
                Console.WriteLine("Valores nao aceitos");

            Console.ReadLine();

        }
    }
}

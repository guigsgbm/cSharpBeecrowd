using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1044
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string l1 = Console.ReadLine();
            string[] v1 = l1.Split(' ');

            int a = int.Parse(v1[0]);
            int b = int.Parse(v1[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
                Console.WriteLine("Nao sao Multiplos");

            Console.ReadLine();
        }
    }
}

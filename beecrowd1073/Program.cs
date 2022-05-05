using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 2; i <= x; i+=2)
            {
                Console.WriteLine("{0}^2 = {1}", i, i * i);
            }

            Console.ReadLine();
        }
    }
}

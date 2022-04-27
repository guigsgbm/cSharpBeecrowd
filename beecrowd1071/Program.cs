using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int r=0;

            if (x < y)
            {
                for (int i = x + 1; i != y; i++)
                {
                    if (i % 2 != 0)
                    {
                        r += i;
                    }
                }
            }

            if (x > y)
            {
                for (int i = x-1; i != y; i--)
                {
                    if (i % 2 != 0)
                    {
                        r += i;
                    }
                }
            }

            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
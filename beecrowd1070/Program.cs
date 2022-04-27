using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[] num = new int[6];

            for (int i = 0; i < num.Length;)
            {
                if (x % 2 != 0)
                {
                    num[i] = x;
                    Console.WriteLine(num[i]);
                    i++;
                }
                x++;
            }
            Console.ReadLine();
        }
    }
}

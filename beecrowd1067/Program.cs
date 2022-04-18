using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = int.Parse(Console.ReadLine());
            //int i = 0;
            
            for (double i = 1; i <= x; i++)
            {
                if(i % 2 != 0)
                    Console.WriteLine(i);
            }
            /*while (i < x)
            {
                if (i % 2 != 0)
                    Console.Write(i + "\n");
                i++;
            }*/

            Console.ReadLine();
        }
    }
}

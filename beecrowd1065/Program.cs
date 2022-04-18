using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPositives = 0;

            for (int i = 0; i < 5; i++)
            {
                double x = double.Parse(Console.ReadLine());
                
                if(x % 2 == 0)
                {
                    numPositives++;
                }
            }
            Console.WriteLine("{0} valores pares", numPositives);
            Console.ReadLine();
        }
    }
}

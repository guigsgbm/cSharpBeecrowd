using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qin = 0, qout=0;
            int testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if(x >= 10 && x <= 20)
                {
                    qin++;
                }
                else
                    qout++;
            }

            Console.WriteLine("{0} in\n{1} out", qin, qout);
            Console.ReadLine();
        }
    }
}

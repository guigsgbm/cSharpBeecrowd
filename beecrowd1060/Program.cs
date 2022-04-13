using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positiveNum=0;

            double [] num = new double[6];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = double.Parse(Console.ReadLine());

                if (num[i] > 0)
                {
                    positiveNum++;
                }
            }

            Console.WriteLine("{0} valores positivos", positiveNum);
            Console.ReadLine();
        }
    }
}

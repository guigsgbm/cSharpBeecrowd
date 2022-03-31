using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1043
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;

            string l1 = Console.ReadLine();
            string[] v1 = l1.Split(' ');

            a = double.Parse(v1[0], System.Globalization.CultureInfo.InvariantCulture);
            b = double.Parse(v1[1], System.Globalization.CultureInfo.InvariantCulture);
            c = double.Parse(v1[2], System.Globalization.CultureInfo.InvariantCulture);

            if(a+b <= c | a+c <= b | b+c <= a)
            {
                double aTrap = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + aTrap.ToString("F1"));    
            }
            else
            {
                double pTriang = a + b + c;
                Console.WriteLine("Perimetro = " + pTriang.ToString("F1"));
            }

            Console.ReadLine();
        }
    }
}

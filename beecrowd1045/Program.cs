using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace beecrowd1045
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("th-TH", false);

            double a, b, c;

            string l1 = Console.ReadLine();
            string[] v1 = l1.Split(' ');

            double[] v11 = v1.Select(double.Parse).ToArray();

            Array.Sort(v11);
            Array.Reverse(v11);

            a = v11[0];
            b = v11[1];
            c = v11[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
                return;
            }

            else if (Math.Pow(a , 2) == (Math.Pow(b,2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }

            else if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }

            else if (Math.Pow(a, 2) < (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (a == c && a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
                return;
            }

            if (a == b || a == c || b == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }

            Console.ReadLine();
        }
    }
}

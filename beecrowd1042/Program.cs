using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1042
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int maiorAB, maiorABC, menorABC;

            string l1 = Console.ReadLine();
            string[] v1 = l1.Split(' ');

            int a = int.Parse(v1[0]);
            int b = int.Parse(v1[1]);
            int c = int.Parse(v1[2]);


            if (a > b & a > c)
            {
                maiorABC = a;
            }
            else if (b > c & b > a)
            {
                maiorABC = b;
            }
            else
                maiorABC = c;



            if (a < b & a > c)
            {
                maiorAB = a;
            }
            else if (b < c & b > a)
            {
                maiorAB = b;
            }
            else if (a > b & a < c)
            {
                maiorAB = a;
            }

            else if (b > c & b < a)
            {
                maiorAB = b;
            }
            else
                maiorAB = c;



            if (a < c & a < b)
            {
                menorABC = a;
            }
            else if (b < a & b < c)
            {
                menorABC = b;
            }
            else
                menorABC = c;


            Console.WriteLine(menorABC + "\n" + maiorAB + "\n" + maiorABC + "\n");
            Console.WriteLine(a + "\n" + b + "\n" + c);

            Console.ReadLine();
        }
    }
}
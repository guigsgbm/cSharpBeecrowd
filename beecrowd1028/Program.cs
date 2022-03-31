using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1028
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int qtdTestCase = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < qtdTestCase; i++)
            {
                string l1 = Console.ReadLine();
                string[] v1 = l1.Split(' ');

                int x = int.Parse(v1[0]);
                int y = int.Parse(v1[1]);

                Console.WriteLine(MDC(y, x));

            }

            Console.ReadLine();
        }

        public static int MDC(int a, int b)
        {
            int resto;

            while (b != 0)
            {
                resto = a % b;
                a = b;
                b = resto;
            }

            return a;
            
        }
    }
}

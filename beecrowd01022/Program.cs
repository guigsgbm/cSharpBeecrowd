using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd01022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int qtdCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdCases; i++)
            {

                string l1 = Console.ReadLine();
                string[] v1 = l1.Split(' ');

                int N1 = int.Parse(v1[0]);
                int D1 = int.Parse(v1[2]);
                int N2 = int.Parse(v1[4]);
                int D2 = int.Parse(v1[6]);
                char op = char.Parse(v1[3]);
                int R1, R2, S1, S2;

                if (op == '+')
                {
                    R1 = (N1 * D2 + N2 * D1);
                    R2 = (D1 * D2);
                }
                else if (op == '-')
                {
                    R1 = ((N1 * D2) - (N2 * D1));
                    R2 = (D1 * D2);
                }
                else if (op == '*')
                {
                    R1 = (N1 * N2);
                    R2 = (D1 * D2);
                }
                else if (op == '/')
                {
                    R1 = (N1 * D2);
                    R2 = (N2 * D1);
                }
                else
                {
                    Console.WriteLine("Erro");
                    return;
                }

                int mdc = MDC(R1, R2);
                S1 = R1 / mdc;
                S2 = R2 / mdc;
                Console.WriteLine("{0}/{1} = {2}/{3}",R1,R2,S1,S2);
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

            if (a < 0)
                a *= -1;
            return a;
        }
    }

}

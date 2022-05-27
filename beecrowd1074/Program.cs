using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdCases = int.Parse(Console.ReadLine());
            int [] dados = new int[qtdCases];
            string [] saida = new string[qtdCases];

            for(int i = 0; i < qtdCases; i++)
            {
                dados[i] = int.Parse(Console.ReadLine());

                if (dados[i] % 2 == 0)
                {
                    saida[i] = "EVEN ";
                }
                else
                {
                    saida[i] = "ODD ";
                }

                if (dados[i] > 0)
                {
                    saida[i]+= "POSITIVE";
                }
                else
                {
                    saida[i] += "NEGATIVE";
                }

                if (dados[i] == 0)
                {
                    saida[i] = "NULL";
                }
            }

            foreach (string i in saida)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

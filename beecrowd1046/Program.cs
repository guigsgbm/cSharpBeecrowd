using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iJogo, fJogo, i=0;

            string l1 = Console.ReadLine();
            string[] v1 = l1.Split(' ');

            iJogo = int.Parse(v1[0]);
            fJogo = int.Parse(v1[1]);

            if (iJogo == fJogo)
            {
                i = 24;
                Console.WriteLine("O JOGO DUROU " + i + " HORA(S)");
                return;
            }

            if (iJogo < fJogo)
            {
                while (iJogo < fJogo)
                {
                    iJogo++;
                    i++;
                }
            }

            if (iJogo > fJogo)
            {
                while (iJogo > fJogo)
                {
                    iJogo++;
                    i++;
                    if(iJogo == 24)
                    {
                        iJogo = 0;

                        if (iJogo < fJogo)
                        {
                            while (iJogo < fJogo)
                            {
                                iJogo++;
                                i++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("O JOGO DUROU " + i + " HORA(S)");
            Console.ReadLine();
        }
    }
}
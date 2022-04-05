using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string iJogo, fJogo;

            string l1 = Console.ReadLine();
            string[] v1 = l1.Split(' ');

            iJogo = String.Join(":", v1[0], v1[1]);
            fJogo = String.Join(":", v1[2], v1[3]);

            var inicioJogo = TimeSpan.Parse(iJogo);
            var finalJogo = TimeSpan.Parse(fJogo);

            int diferença = TimeSpan.Compare(inicioJogo, finalJogo);

            if (diferença == 0)
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");

            if (diferença == -1)
            {
                TimeSpan intervalo1 = finalJogo - inicioJogo;
                double totalMinutes = intervalo1.TotalMinutes;

                double i = Math.Floor(totalMinutes / 60);
                double ii = (totalMinutes % 60);
                Console.WriteLine("O JOGO DUROU "+ i.ToString("F0") +" HORA(S) E " + ii + " MINUTO(S)");
            }

            if (diferença == 1)
            {
                TimeSpan intervalo1 = finalJogo - inicioJogo;
                double totalMinutes = intervalo1.TotalMinutes + 1440;

                double i = Math.Floor(totalMinutes / 60);
                double ii = (totalMinutes % 60);
                Console.WriteLine("O JOGO DUROU " + i.ToString("F0") + " HORA(S) E " + ii + " MINUTO(S)");

            }

            Console.ReadLine();
        }

    }
}
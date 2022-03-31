using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1040
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n1, n2, n3, n4, media;

            string l1 = Console.ReadLine();
            string[] v1 = l1.Split(' ');

            n1 = double.Parse(v1[0], System.Globalization.CultureInfo.InvariantCulture); n1 *= 10; n1 *= 0.2;
            n2 = double.Parse(v1[1], System.Globalization.CultureInfo.InvariantCulture); n2 *= 10; n2 *= 0.3;
            n3 = double.Parse(v1[2], System.Globalization.CultureInfo.InvariantCulture); n3 *= 10; n3 *= 0.4;
            n4 = double.Parse(v1[3], System.Globalization.CultureInfo.InvariantCulture); n4 *= 10; n4 *= 0.1;

            media = Math.Round(media = n1 + n2 + n3 + n4);
            media /= 10;

            if (media >= 7.00)
            {
                Console.WriteLine("Media: " + media.ToString("F1"));
                Console.WriteLine("Aluno aprovado.");

            }
            else if (media <= 4.90)
            {
                Console.WriteLine("Media: " + media.ToString("F1"));
                Console.WriteLine("Aluno reprovado.");
            }

            else if (media >= 5.00 & media <= 6.90)
            {
                Console.WriteLine("Media: " + media.ToString("F1"));
                Console.WriteLine("Aluno em exame.");

                double notaExame = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1"));

                double mediaFinal = (notaExame + media) / 2;

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1"));
                }

                else if (mediaFinal <= 4.9)
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1"));
                }

            }


            Console.ReadLine();
        }
    }
}

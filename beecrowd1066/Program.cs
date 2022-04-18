using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int par = 0, impar = 0, positivo = 0, negativo = 0;

            for (int i = 0; i < 5; i++)
            {
                double x = double.Parse(Console.ReadLine());

                if(x % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }

                if (x > 0)
                {
                    positivo++;
                }
                if( x < 0)
                {
                    negativo++;
                }
            }
            Console.WriteLine("{0} valor(es) par(es)\n{1} valor(es) impar(es)\n{2} valor(es) positivo(s)\n{3} valor(es) negativo(s)",
                par, impar, positivo, negativo);
            Console.ReadLine();
        }
    }
}

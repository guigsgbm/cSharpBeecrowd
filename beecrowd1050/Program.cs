using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ddd;
            string cidade = null;

            ddd = int.Parse(Console.ReadLine());

            switch (ddd)
            {
                case 11:
                    cidade = "Sao Paulo";
                    break;

                case 19:
                    cidade = "Campinas";
                    break;

                case 21:
                    cidade = "Rio de Janeiro";
                    break ;

                case 27:
                    cidade = "Vitoria";
                    break;

                case 31:
                    cidade = "Belo Horizonte";
                    break;

                case 32:
                    cidade = "Juiz de Fora";
                    break;

                case 61:
                    cidade = "Brasilia";
                    break;

                case 71:
                    cidade = "Salvador";
                    break;
            }

            if (string.IsNullOrEmpty(cidade))
            {
                Console.WriteLine("DDD nao cadastrado");
            }
            else
                Console.WriteLine(cidade);


            Console.ReadLine();
        }
    }
}

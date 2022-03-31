using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod, qtd;
            double total;

            string l1 = Console.ReadLine();
            string[] v1 = l1.Split(' ');

            cod = int.Parse(v1[0], System.Globalization.CultureInfo.InvariantCulture);
            qtd = int.Parse(v1[1], System.Globalization.CultureInfo.InvariantCulture);

            switch (cod)
            {
                case 1:
                    {
                        total = qtd * 4.00;
                        Console.WriteLine("Total: R$ " + total.ToString("F2"));
                        break;
                    }

                 case 2:
                    {
                        total = qtd * 4.50;
                        Console.WriteLine("Total: R$ " + total.ToString("F2"));
                        break;
                    }

                  case 3:
                    {
                        total = qtd * 5.00;
                        Console.WriteLine("Total: R$ " + total.ToString("F2"));
                        break;
                    }

                  case 4:
                    {
                        total = qtd * 2.00;
                        Console.WriteLine("Total: R$ " + total.ToString("F2"));
                        break;
                    }

                  case 5:
                    {
                        total = qtd * 1.50;
                        Console.WriteLine("Total: R$ " + total.ToString("F2"));
                        break;
                    }
            }

            Console.ReadLine();

        }
    }
}

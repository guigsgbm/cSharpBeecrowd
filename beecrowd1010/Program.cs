using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total=0;

            for (int i = 0; i < 2; i++)
            {
                string l1 = Console.ReadLine();
                string[] item = l1.Split(' ');

                int cod = int.Parse(item[0]);
                int unit = int.Parse(item[1], System.Globalization.CultureInfo.InvariantCulture);
                double valor = double.Parse(item[2], System.Globalization.CultureInfo.InvariantCulture);

                total += unit * valor;
            }
            Console.Write("VALOR A PAGAR: R$ {0}", total.ToString("F2"));
            Console.ReadLine();
        }
    }
}

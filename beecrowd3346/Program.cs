using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd3346
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double percent1, percent2, percentAcumulado;

            string l1 = Console.ReadLine();
            string[] v1 = l1.Split(' ');

            percent1 = double.Parse(v1[0], System.Globalization.CultureInfo.InvariantCulture);
            percent2 = double.Parse(v1[1], System.Globalization.CultureInfo.InvariantCulture);

            percent1 = percent1 / 100 + 1;
            percent2 = percent2 / 100 + 1;

            percentAcumulado = ((percent1 * percent2) - 1) * 100;

            Console.WriteLine(percentAcumulado.ToString("F6"));

            Console.ReadLine();
        }
    }
}

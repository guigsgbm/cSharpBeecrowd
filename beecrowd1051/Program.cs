using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary, r=0;
            double alq1 = 0.08, alq2 = 0.18, alq3 = 0.28;

            salary = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            if (salary <= 2000.00)
            {
                Console.WriteLine("Isento");
                return;
            }

            if (salary > 2000.00 & salary <= 3000.00)
            {
                r = (salary - 2000) * alq1;
            }

            if (salary > 3000.00 & salary <= 4500.00)
            {
                r = 1000 * alq1;
                r = r + ((salary - 3000) * alq2);
            }

            if (salary > 4500.00)
            {
                r = 1000 * alq1;
                r = r + (1500 * alq2);
                r = r + ((salary - 4500) * alq3);
            }

            
            Console.WriteLine("R$ {0}", r.ToString("F2"));
            Console.ReadLine();
        }
    }
}

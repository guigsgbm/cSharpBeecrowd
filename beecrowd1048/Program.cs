using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nSalary=0;
            double p=0;
            double salary = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            if (salary  <= 400)
            {
                p = 1.15;
                nSalary = salary * p;
                p = 15;
            }

            else if (salary <= 800)
            {
                p = 1.12;
                nSalary = salary * p;
                p = 12;
            }

            else if (salary <= 1200)
            {
                p = 1.10;
                nSalary = salary * p;
                p = 10;
            }

            else if (salary <= 2000)
            {
                p = 1.07;
                nSalary = salary * p;
                p = 7;
            }

            else if (salary > 2000)
            {
                p = 1.04;
                nSalary = salary * p;
                p=4;
            }

            double reajuste = nSalary - salary;

            Console.WriteLine("Novo salario: " + nSalary.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"));
            Console.WriteLine("Em percentual: " + p + " %");

            Console.ReadLine();
        }
    }
}

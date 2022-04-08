using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1052
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());

            string[] mes = {"","January", "February", "March", "April", "May", "June", "July", "August",
                "September", "October", "November", "December"};

                Console.WriteLine(mes[a]);

            Console.ReadLine();
        }
    }
}

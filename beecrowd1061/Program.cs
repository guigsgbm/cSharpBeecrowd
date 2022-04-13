using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day1, day2;

            // captura o inteiro depois da string "dia"
            day1 = Console.ReadLine();
            day1 = String.Join("", System.Text.RegularExpressions.Regex.Split(day1, @"[^\d]"));
            int day11 = int.Parse(day1);

            char[] separator = new char[] {':', ' '}; 
            string l1 = Console.ReadLine();
            string[] result;
            result = l1.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            int[] iHour = result.Select(int.Parse).ToArray();


            TimeSpan date1 = new TimeSpan(day11, iHour[0], iHour[1], iHour[2]);

            // captura o inteiro depois da string "dia"
            day2 = Console.ReadLine();
            day2 = String.Join("", System.Text.RegularExpressions.Regex.Split(day2, @"[^\d]"));
            int day22 = int.Parse(day2);

            string l2 = Console.ReadLine();
            string[] result2;
            result2 = l2.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            int[] fHour = result2.Select(int.Parse).ToArray();


            TimeSpan date2 = new TimeSpan(day22, fHour[0], fHour[1], fHour[2]);


            TimeSpan intervalo = date1 - date2;

            int diferenca =(int)(-1 * intervalo.TotalSeconds);

            int d = diferenca / 86400;
            int resto = diferenca % 86400;
            int h = resto / 3600;
            resto = resto % 3600;
            int m = resto / 60;
            int s = resto % 60;

            Console.WriteLine("{0} dia(s)", d);
            Console.WriteLine("{0} hora(s)", h);
            Console.WriteLine("{0} minuto(s)", m);
            Console.WriteLine("{0} segundo(s)", s);

            Console.ReadLine();
        }
    }
}

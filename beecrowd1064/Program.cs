using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace beecrowd1064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("th-TH", false);

            int pNumbers =0;
            double media, soma=0;

            string[] num = new string[6];
            double[] conj = new double[6];

            for (int i = 0; i < 6; i++)
            {
                num[i] = Console.ReadLine();
            }

            conj = num.Select(double.Parse).ToArray();

            for (int i = 0; i < conj.Length; i++)
            {
                if (conj[i] > 0)
                {
                    pNumbers++;
                    soma += conj[i];
                }
            }
            
            media = soma / pNumbers;
            
            Console.WriteLine("{0} valores positivos", pNumbers);
            Console.WriteLine(media.ToString("F1"));

            Console.ReadLine();
        }
    }
}

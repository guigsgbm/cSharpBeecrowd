using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd01036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. 
            Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, 
            caso haja uma divisão por 0 ou raiz de numero negativo.

            Entrada
            Leia três valores de ponto flutuante (double) A, B e C.

            Saída
            Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". 
            Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo
            abaixo. Imprima sempre o final de linha após cada mensagem
            */

            double a, b, c, delta, x1, x2;

            string l1 = Console.ReadLine();
            string[] v1 = l1.Split(' ');

            a = double.Parse(v1[0], System.Globalization.CultureInfo.InvariantCulture);
            b = double.Parse(v1[1], System.Globalization.CultureInfo.InvariantCulture);
            c = double.Parse(v1[2], System.Globalization.CultureInfo.InvariantCulture);

            delta = (Math.Pow(b, 2) - 4 * a * c);

            x1 = (-b + (Math.Sqrt(delta))) / (2 * a);
            x2 = (-b - (Math.Sqrt(delta))) / (2 * a);

            if (double.IsNaN(x1) == true | double.IsNaN(x2) == true)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
                Console.WriteLine("R1 = " + x1.ToString("F5") + "\nR2 = " + x2.ToString("F5"));

        }
    }
}

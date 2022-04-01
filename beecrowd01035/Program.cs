using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd01035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Leia 4 valores inteiros A, B, C e D. 
            A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se C e D, 
            ambos, forem positivos e se a variável A for par escrever a mensagem "Valores aceitos", 
            senão escrever "Valores nao aceitos".

            Entrada
            Quatro números inteiros A, B, C e D.

            Saída
            Mostre a respectiva mensagem após a validação dos valores.
            */

            int a, b, c, d;

            string l1 = Console.ReadLine();
            string[] v1 = l1.Split(' ');

            a = int.Parse(v1[0]);
            b = int.Parse(v1[1]);
            c = int.Parse(v1[2]);
            d = int.Parse(v1[3]);

            if (b > c & d > a & c + d > a + b & c > 0 & d > 0 & a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
                Console.WriteLine("Valores nao aceitos");

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, i, l;
            string A, B, C, D;
            int p;
            bool Esp;
            D = "";
            for (p = 0; p != 2; ++p)
            {
                A = "";
                B = "";
                C = "";
                x = 0;
                Esp = false;
                A = (Console.ReadLine());
                for (; x != A.Length; ++x)
                {
                    if (Convert.ToString(A[x]) == " ")
                        Esp = true;
                    if (Esp == false)
                    {
                        B = B + Convert.ToString(A[x]);
                    }
                    else
                        C = C + Convert.ToString(A[x]);
                }
                i = Convert.ToInt32(B);
                l = Convert.ToInt32(C);
                B = "";
                C = "";
                A = "";
                for (; i != 0;)
                {
                    if (i % 2 == 1)
                    {
                        A = "1" + A;
                        i = (i - 1) / 2;
                    }
                    else
                    {
                        A = "0" + A;
                        i = i / 2;
                    }
                }

                for (; l != 0;)
                {
                    if (l % 2 == 1)
                    {
                        B = "1" + B;
                        l = (l - 1) / 2;
                    }
                    else
                    {
                        B = "0" + B;
                        l = l / 2;
                    }
                }
                while (A.Length != 32)
                {
                    A = "0" + A;
                }
                while (B.Length != 32)
                {
                    B = "0" + B;
                }
                for (i = 0; i != 32; ++i)
                {
                    if (B[i] == A[i])
                        C = C + "0";
                    else
                        C = C + "1";
                }
                i = 0;
                for (l = 0; l != 32; ++l)
                {
                    i = i * 2;
                    if (Convert.ToString(C[l]) == "1")
                        ++i;
                }
                if (p == 0)
                    D = Convert.ToString(i);
                if (p == 1)
                {

                    Console.WriteLine(D);
                    Console.WriteLine(Convert.ToString(i));

                    Console.ReadLine();
                }
            }

        }

    }
}

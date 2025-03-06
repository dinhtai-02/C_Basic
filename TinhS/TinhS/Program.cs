// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongS
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int n = int.Parse(input[1]);

            if (x < -10 || x > 10 || n <= 0 || n > 10)
            {
                Console.WriteLine("Vui long nhap lai gia tri x, n");
            }
            else
            {
                double ts = 1;
                int ms = 1;
                double S = 0;

                for (int i = 1; i <= n; i++)
                {
                    ts *= x;
                    ms *= i;
                    S += (ts / ms);
                }

                Console.WriteLine(S.ToString("F2"));
            }
        }
    }
}

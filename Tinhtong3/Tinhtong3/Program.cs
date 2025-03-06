// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinhtong
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double S = 0;

            if (n < 2 || n > 10000)
            {
                Console.WriteLine("Moi nhap lai!");
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    S += (double)1 / i;
                }

                Console.WriteLine(S.ToString("F4"));
            }
        }
    }
}

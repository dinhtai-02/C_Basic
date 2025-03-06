// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhHCN
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int d = int.Parse(input[0]);
            int r = int.Parse(input[1]);

            if (d <= 0 || r <= 0 || d > 5000 || r > 5000)
            {
                Console.WriteLine("Vui long nhap lai so lieu");
            }
            else
            {
                int C = (d + r) * 2;
                int S = d * r;
                Console.WriteLine(C);
                Console.WriteLine(S);
            }
        }

    }
}

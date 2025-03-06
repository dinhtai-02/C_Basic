// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPtBac1
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            if (a == 0 && b != 0)
            {
                Console.WriteLine("NO");
            }
            if (a == 0 && b == 0)
            {
                Console.WriteLine("WOW");
            }
            if (a != 0)
            {
                double x = (double)(-b) / a;
                Console.WriteLine(x.ToString("F2"));
            }
        }
    }
}

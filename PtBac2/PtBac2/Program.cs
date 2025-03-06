// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPtBac2
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            if (a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine("NO");
            }
            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("WOW");
            }
            if (a == 0 && b != 0)
            {
                double x = (double)(-c) / b;
                Console.WriteLine(x.ToString("F2"));
            }
            if (a != 0)
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("NO");
                }
                if (delta == 0)
                {
                    double x = (-b) / (2 * a);
                    Console.WriteLine(x.ToString("F2"));
                }
                else
                {
                    double x1 = ((-b) - Math.Sqrt(delta)) / (2 * a);
                    double x2 = ((-b) + Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine(x1.ToString("F2") + " " + x2.ToString("F2"));
                }
                    
            }
        }
    }
}

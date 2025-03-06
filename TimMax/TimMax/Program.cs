// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimMax
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int max;

            if (a >= b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            Console.WriteLine(Math.Max(max, c));
        }
    }
}

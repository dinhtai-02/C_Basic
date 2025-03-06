// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tong2so //Tong3so
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            //int c = int.Parse(input[2]);

            int sum = a + b;
            //int sum = a + b + c;

            Console.WriteLine(sum);
        }
    }
}

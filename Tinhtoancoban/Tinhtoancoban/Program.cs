// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinhtoancoban
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            int sum = a + b; Console.WriteLine(sum);
            int dif = a - b; Console.WriteLine(dif);
            int prod = a * b; Console.WriteLine(prod);
            if (b == 0)
            {
                Console.WriteLine("ERORR");
            }
            else
            {
                double quot = (double) a / b;
                Console.WriteLine(quot.ToString("F2"));
            }  
        }
    }
}

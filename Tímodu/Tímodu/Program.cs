// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timsodu
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            if (a <= 0 || b <= 0 || a >= 1000000 || b >= 1000000)
            {
                Console.WriteLine("Vui long nhap so nguyen duong nho hon 1000000");
            }
            else
            {
                int i = a % b;
                Console.WriteLine(i);
            }
        }
    }
}

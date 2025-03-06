// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giatrituyetdoi
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            if (Math.Abs(a) > 1000000 || Math.Abs(b) > 1000000)
            {
                Console.WriteLine("Nhap lai gia tri trong khoang gioi han");
            }
            else
            {
                Console.WriteLine(Math.Abs(a - b));
            }                
        }
    }
}

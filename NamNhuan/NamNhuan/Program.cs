// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamNhuan
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Moi nhap nam muon kiem tra: ");
            int year = int.Parse(Console.ReadLine());

            if (year <= 0 || year > 100000)
            {
                Console.WriteLine("INVALID");
            }
            else
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}

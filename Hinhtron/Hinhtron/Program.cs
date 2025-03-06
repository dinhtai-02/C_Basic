// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinhtron
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            const double PI = 3.14;

            double C = 2 * PI * r;
            double S = PI * r * r;

            Console.WriteLine(C.ToString("F3") + " " + S.ToString("F3"));
        }
    }
}

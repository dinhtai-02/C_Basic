// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamtronso
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            int a = (int)n;
            double b = n - a;
            double c = a - n;

            if (n >= 0)
            {
                if (b >= 0.5)
                {
                    a++;
                }
            }
            else
            {
                if (c >= 0.5)
                {
                    a--;
                }
            }


                Console.WriteLine(a);
        }
    }
}

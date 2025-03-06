// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinhgiatri
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int S = 0;

            if (n % 2 == 0)
            {
                S = 1 + (int)(3 * n + 1) / 2;
            }
            else
            {
                S = (int)(-(3 * n + 1) / 2);
            }

            Console.WriteLine(S);
        }
    }
}

// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinhtong
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int S = 0;

            for (int i = 1; i <= n; i++)
            {
                S += i;
            }

            Console.WriteLine(S);
        }
    }
}

// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaithua
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int S = 1;

            if (n == 0) Console.WriteLine(1);
            if (n < 0 || n > 12)
            {
                Console.WriteLine("Moi nhap lai!");
            }
            if (n >= 1 && n <= 12)
            {
                for (int i = 1; i <= n; i++)
                {
                    S *= i;
                }

                Console.WriteLine(S);
            }
        }
    }
}

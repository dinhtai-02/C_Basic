// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songuyento
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Moi nhap lai!");
            }
            else
            {
                for (int i = 2; i <= (n/2); i++)
                {
                    int a = n / i;
                    if (a*i == n)
                    {
                        Console.WriteLine("NO"); break;
                    }
                    else
                    {
                        Console.WriteLine("YES"); break;
                    }
                }
            }
        }
    }
}

// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timsecond
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2 || n > 1000000)
            {
                Console.WriteLine("Moi nhap lai!");
                return;
            }

            int[] arr = new int[n];
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            Array.Sort(arr);
            Array.Reverse(arr);
            int num = arr[0];

            if (arr[0] == arr[n - 1])
            {
                Console.WriteLine("NOT FOUND");
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    if (num > arr[i])
                    {
                        num = arr[i]; break;
                    }
                }

                Console.WriteLine(num);
            }
        }
    }
}

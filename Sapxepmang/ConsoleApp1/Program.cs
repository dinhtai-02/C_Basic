// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapxepmang
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 3 || n > 10000)
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

            int[] sortedArr = (int[])arr.Clone();

            Array.Sort(sortedArr, 1, n - 2);

            Console.WriteLine(string.Join(" ", sortedArr));

        }            
    }
}

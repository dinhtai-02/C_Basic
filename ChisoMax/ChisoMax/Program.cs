// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimchisoMax
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 1000000)
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

            int max = arr[0];
            int chisoMax = 0;

            for (int i = 1; i < n; i++)
            {
                if (max <= arr[i])
                {
                    max = arr[i];
                    chisoMax = i;
                }
            }

            Console.WriteLine(chisoMax);
        }
    }
}

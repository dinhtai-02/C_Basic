// See https://aka.ms/new-console-template for more informatio

using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

//namespace MyApplication
//{
//    class Program
//    {
//        static void MyMethod()
//        {

//        }
//    }
//}

int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

foreach (int i in numbers)
{
    Console.WriteLine(i);
}

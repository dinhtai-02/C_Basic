// See https://aka.ms/new-console-template for more informatio

using Microsoft.VisualBasic;
using System.IO.IsolatedStorage;
using System.Runtime.InteropServices;
using System.Xml.Schema;

//namespace MyApplication
//{
//    //class Program
//    //{
//    //    static void MyMethod(string day)
//    //    {
//    //        Console.WriteLine("Hom nay la " + day);
//    //    }
//    //    static void Main(string[] args)
//    //    {
//    //        int i = 34;
//    //        Console.WriteLine("Nhap i: " + i );
//    //        double j = i % 7;
//    //        if ( j < 6 && j > 0 )
//    //        {
//    //            MyMethod("trong tuan");
//    //        } else
//    //        {
//    //            MyMethod("cuoi tuan");
//    //        }
//    //    }
//    //}
//}


//int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}

//int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        Console.WriteLine(numbers[i, j]);
//    }
//}

//namespace MyObj
//{
//    class Program
//    {
//        static void MyMethod(string obj1, string obj2, string obj3)
//        {
//            Console.WriteLine("Vat dat nhat la: " + obj1);
//        }

//        static void Main(string[] args)
//        {
//            MyMethod(obj2: "laptop", obj3: "dien thoai", obj1: "o to");
//        }
//    }

//}

//namespace MyNumber
//{
//    class Program
//    {
//        //static int MyMethodInt(int x, int y)
//        static int MyMethod(int x, int y)
//        {
//            return x + y;
//        }

//        //static double MyMethodDouble(double x, double y)
//        static double MyMethod(double x, double y)
//        {
//            return x + y;
//        }

//        static void Main(string[] args)
//        {
//            //int myNum1 = MyMethodInt(1, 2);
//            //double myNum2 = MyMethodDouble(2.4, 5.6);
//            int myNum1 = MyMethod(1, 2);
//            double myNum2 = MyMethod(2.4, 5.6);
//            Console.WriteLine("Int: " + myNum1);
//            Console.WriteLine("Double: " + myNum2);
//        }
//    }

//}

class Car
{
    string color = "black";

    static void Main(string[] args)
    {
        Car BMW = new Car();
        Console.WriteLine(BMW.color);
    }
}

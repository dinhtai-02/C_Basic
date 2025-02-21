// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*namespace Basic2
{
    class Car
    {
        public string color = "red";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car MyObj = new Car();
            Console.WriteLine(MyObj.color);
        }
    }
}*/

/*namespace Basic2
{
    class MyClass
    {
        public string lt = "Huy";
        public string lp1 = "Duc";
        public string lp2 = "Van";
        public void FullThrottle()
        {
            Console.WriteLine("Nobody can have a score higher than ");
            Console.WriteLine("Nobody can have a weight less than ");
        }
    }

    class Program
    {
        static void Main()
        {
            int maxScore = 10;
            int minWeight = 40;
            MyClass std = new MyClass();
            std.FullThrottle();
        }
    }
}*/

/*class Phone
{
    public string color;
    public string cost;
    public string brand;
    public void fullThrottle()
    {
        Console.WriteLine("The smartphone is wonderfull!");
    }
}
class Program
{

    static void Main()
    {
        Phone myPhone = new Phone();
        myPhone.color = "black";
        myPhone.cost = "1000$";
        myPhone.brand = "Apple";
        Console.WriteLine("Color of the phone is: " + myPhone.color);
        Console.WriteLine("Cost of the phone is: " + myPhone.cost);
        Console.WriteLine("Brand of the phone is: " + myPhone.brand);
        myPhone.fullThrottle();
    }
}*/

/*class School
{
    public string grade;
    public string name;
    //public School()
    public School(string grdName, string clrName)
    {
        grade = grdName;
        name = clrName;
    }

    static void Main(string[] args)
    {
        School clr = new School("12", "12A");
        Console.WriteLine(clr.grade + "-" + clr.name);
    }
}*/

/*class Person
{
    //private string name;
    public string Name
    { get; set; }
    //{
    //    get { return name; }
    //    set { name = value; }
    //}
}
class Program
{
    static void Main(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Huy";
        Console.WriteLine(myObj.Name);
    }
}*/

/*namespace Cat
{
    class Cat
    {
        private int weight;
        public int Weight { get; set; }

        private int height;
        public int Height { get; set; }

        public static int Count = 0;
        public Cat()
        {
            weight = 20;
            height = 300;
            Count++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So luong meo ban dau la: " + Cat.Count);
            Cat BlackCat = new Cat();
            Console.WriteLine("So luong meo hien tai la: " + Cat.Count);
            Cat WhiteCat = new Cat();
            Console.WriteLine("So luong meo hien tai la: " + Cat.Count);
            Cat YellowCat = new Cat();
            Console.WriteLine("So luong meo hien tai la: " + Cat.Count);
        }
    }
}*/

/*namespace Tinhtoan
{
    class Tinhtoan
    {
        public static long LuyThua(int CoSo, int SoMu)
        {
            long KetQua = 1;
            for (int i = 1; i <= SoMu; i++)
            {
                KetQua *= CoSo;
            }

            return KetQua;
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("3^5 = " + LuyThua(3, 5));
            }
        }
    }
}*/

namespace Toan
{
    public static class Toan
    {
        public const double PI = 3.14;
        public const double E = 2.71;
        public static double TinhDienTichHinhTron(double BanKinh)
        {
            return PI * BanKinh * BanKinh;
        }
        public static double TinhChuViHinhTron(double BanKinh)
        {
            return 2 * PI * BanKinh;
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dien tich hinh tron co ban kinh 5 la: " + Toan.TinhDienTichHinhTron(5));
            Console.WriteLine("Chu vi hinh tron co ban kinh 5 la: " + Toan.TinhChuViHinhTron(5));
            Console.WriteLine("Can bac hai cua 16 la: " + Math.Sqrt(16));
            Console.WriteLine("Lam tron so cua PI la: " + Math.Round(Toan.PI));
        }
    }
}
